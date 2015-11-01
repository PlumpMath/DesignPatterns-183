using System.Configuration;
using System.Reflection;

namespace AbstractFactoryPattern
{
    public class DataAccess
    {
        private static readonly string AssemblyName = "AbstractFactoryPattern";
        private static readonly string DbType = ConfigurationManager.AppSettings["DbType"];

        public static IUser CreateUser()
        {
            string className = AssemblyName + "." + DbType + "User";
            return (IUser)Assembly.Load(AssemblyName).CreateInstance(className);

            //IUser result = null;
            //switch (DbType)
            //{
            //    case "Sqlserver":
            //        result = new SqlserverUser();
            //        break;
            //    case "Access":
            //        result = new AccessUser();
            //        break;
            //}
            //return result;
        }

        public static IDepartment CreateDepartment()
        {
            string className = AssemblyName + "." + DbType + "Department";
            return (IDepartment)Assembly.Load(AssemblyName).CreateInstance(className);

            //    IDepartment result = null;
            //    switch (DbType)
            //    {
            //        case "Sqlserver":
            //            result = new SqlserverDepartment();
            //            break;
            //        case "Access":
            //            result = new AccessDepartment();
            //            break;
            //    }
            //    return result;
            //}
        }
    }
}