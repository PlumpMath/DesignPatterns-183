using System;
using AbstractFactoryPattern.Demo;

namespace AbstractFactoryPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            new Simple();
            Console.WriteLine($"Demo.Simple();{Environment.NewLine}");

            var user = new User();
            var department = new Department();
            var iu = DataAccess.CreateUser();
            iu.Insert(user);
            iu.GetUser(1);

            var id = DataAccess.CreateDepartment();
            id.Insert(department);
            id.GetDepartment(2);

            Console.ReadKey();
        }
    }
}