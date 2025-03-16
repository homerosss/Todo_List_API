namespace Todo_List_API
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User(1, "homeross", "davit.makhareishvili@gmail.com", "davitaa");
            User user1 = new User(1, "test", "rati", "dato");
            IUserRegistration regisration = new RegistrationByUsername();
            regisration.RegistrationSuccess(user);
            regisration = new RegistrationByID();
            regisration.RegistrationSuccess(user);
            regisration = new RegistrationByEmail();
            regisration.RegistrationSuccess(user);
        }
    }
}
