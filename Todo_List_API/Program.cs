namespace Todo_List_API
{
    internal class Program
    {
        static void Main()
        {
            User user = new User(1, "homeross", "davit.makhareishvili@gmail.com", "davitaa");
            User user1 = new User(2, "homerosss", "davit.makhareishvili@mail.ru", "dato");

            Registration.RegistrationSuccess(user);
            Registration.RegistrationSuccess(user1);
            UserLogin.Access(user);
        }
    }
}
