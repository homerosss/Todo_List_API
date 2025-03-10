namespace Todo_List_API
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            Console.WriteLine("Registration\nPlease enter username: ");
            string? firstUser = Console.ReadLine();
            

            Registration registration = new Registration();
            registration.RegistrationUsername(user, firstUser);
        }
    }
}
