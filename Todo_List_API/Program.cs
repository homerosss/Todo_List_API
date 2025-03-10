namespace Todo_List_API
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User(1,"homeross", "davit.makhareishvili@gmail.com", "davitaa");
            User user1 = new User(1, "homeross", "davit.makhareishvili@gmail.com", "davitaa");
            Console.WriteLine("Registration\nPlease enter username: ");
            

            RegistrationByUsername registration = new RegistrationByUsername();
            registration.RegistrationUsername(user);
            registration.RegistrationUsername(user1);

        }
    }
}
