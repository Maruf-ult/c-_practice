using System.Text.Json;
using System.Text.Unicode;

namespace AsyncHttpClientApp
{
    class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Username { get; set; } = "";
        public string Email { get; set; } = "";
    }

    class PostRequest
    {
        public string Title { get; set; } = "";
        public string Body { get; set; } = "";
        public int UserId { get; set; }
    }
    internal class Program
    {
        static readonly HttpClient client = new HttpClient();



        static async Task<List<User>> GetUserAsync()
        {
            string url = "https://jsonplaceholder.typicode.com/users";

            HttpResponseMessage response = await client.GetAsync(url);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"Failed to get users. Status: {response.StatusCode}");
            }
            string json = await response.Content.ReadAsStringAsync();

            List<User>?users = JsonSerializer.Deserialize<List<User>>(
                json,
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                }
                );

            return users ?? new List<User>();

        }

        static async Task<User> GetUserByIdAsync(int id)
        {
            string url = $"https://jsonplaceholder.typicode.com/users/{id}";

            HttpResponseMessage response = await client.GetAsync(url);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"Failed to get users. Status: {response.StatusCode}");
            }

            string json = await response.Content.ReadAsStringAsync();

            User? user = JsonSerializer.Deserialize<User>(
                json,
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                }
                );
            return user!;

        } 

        static async Task Main(string[] args)
        {
            try
            {
                List<User> users = await GetUserAsync();
                Console.WriteLine("All users");

                foreach(User p in users)
                {
                    Console.WriteLine(p.Name);
                    Console.WriteLine(p.Username);
                    Console.WriteLine(p.Email);
                }
                Console.WriteLine("single user");

                User user = await GetUserByIdAsync(1);
                if (user == null)
                {
                    Console.WriteLine("user not found");
                } else
                Console.WriteLine(user.Name);


                PostRequest post = new PostRequest
                {
                    Title = "Learning async C#",
                    Body = "This is a test post",
                    UserId = 1
                };

                string json = JsonSerializer.Serialize(post);

                StringContent content = new StringContent(
                    json,
                    encoding:System.Text.Encoding.UTF8,
                    "application/json"
                    );

               HttpResponseMessage response = await client.PostAsync(
                   "https://jsonplaceholder.typicode.com/posts",
                    content
               );


              string responseBody = await response.Content.ReadAsStringAsync();

              Console.WriteLine(responseBody);

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
