using System;

namespace AbstractFactoryPattern
{
    public class SqlserverUser : IUser
    {
        public void Insert(User user)
        {
            Console.WriteLine("在Sql server中给User表增加一条记录");
        }

        public User GetUser(int id)
        {
            Console.WriteLine("在Sql server中根据id得到User表一条记录");
            return null;
        }
    }
}