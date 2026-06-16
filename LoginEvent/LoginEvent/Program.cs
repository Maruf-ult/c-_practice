namespace LoginEvent
{
    class userLoggedInEventArgs : EventArgs
    {
        public string UserName { get; }
        public DateTime LoginTime { get; }

        public userLoggedInEventArgs(string userName,DateTime loginTime)
        {
            UserName = userName;
            LoginTime = loginTime;
        }
    }

    class AuthService
    {
        public event EventHandler<userLoggedInEventArgs> UserLoggedIn;

        public void Login(string username , string password)
        {
            if(username == "Admin" && password == "123")
            {
                Console.WriteLine("Login successfull");

                UserLoggedIn?.Invoke(this, new userLoggedInEventArgs(username, DateTime.Now));
            }
            else
            {
                Console.WriteLine("Invalid userName or password");
            }
        }
    }

    internal class Program
    {
        static void WriteLogin(object sender, userLoggedInEventArgs e)
        {
            Console.WriteLine($"Log: {e.UserName} logged in at {e.LoginTime}");
        }

        static void SecurityNotification(object sender, userLoggedInEventArgs e)
        {
            Console.WriteLine($"Security notification sent for user {e.UserName}");
        }


        static void Main(string[] args)
        {
            AuthService authservice = new AuthService();

            authservice.UserLoggedIn += WriteLogin;
            authservice.UserLoggedIn += SecurityNotification;

            authservice.Login("Admin","123");
            authservice.Login("maruf", "123");
        }
    }
}
