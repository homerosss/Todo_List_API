namespace Todo_List_API
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User(1, "homeross", "davit.makhareishvili@gmail.com", "davitaa");
            User user1 = new User(2, "homerosss", "davit.makhareishvili@mail.ru", "dato");

            Registration.RegistrationSuccess(user1);
            Registration.RegistrationSuccess(user);
            UserLogin.Access(user);
            UserLogin.Access(user1);
        }
    }
}
