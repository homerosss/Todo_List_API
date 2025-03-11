namespace Todo_List_API
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User(1,"homeross", "davit.makhareishvili@gmail.com", "davitaa");
            RegistrationByUsername registration = new RegistrationByUsername();
            registration.RegistrationUsername(user);
        }
    }
}
