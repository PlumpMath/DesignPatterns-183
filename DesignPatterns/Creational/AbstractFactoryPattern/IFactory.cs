namespace AbstractFactoryPattern
{
    public interface IFactory
    {
        IUser CreateUser();

        IDepartment CreateDepartment();
    }
}