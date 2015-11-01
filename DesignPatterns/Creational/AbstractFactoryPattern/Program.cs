using System;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            new Demo.Simple();
            Console.WriteLine($"Demo.Simple();{Environment.NewLine}");

            User user = new User();
            Department department = new Department();
            IUser iu = DataAccess.CreateUser();
            iu.Insert(user);
            iu.GetUser(1);

            IDepartment id = DataAccess.CreateDepartment();
            id.Insert(department);
            id.GetDepartment(2);

            Console.ReadKey();
        }
    }
}
