namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,Employee> employees = new Dictionary<int,Employee>();
            List<Product> products = new List<Product>();

            products.Add(new Product { Name = "barried", Price = 12323 });
            products.Add(new Product ( "maruf", 43232 ));


            employees.Add(1, new Employee("maruf", 10, 1000000));
            employees.Add(2, new Employee("jisan", 11, 2340934));
            employees.Add(3, new Employee("qwewr", 233, 43554323));

            foreach(var employee in employees)
            {
                Console.WriteLine($"ID: {employee.Key} and the employee name is {employee.Value.Name} and the age and salary are {employee.Value.Age} {employee.Value.Salary} ");
            }

        }
    }
}
