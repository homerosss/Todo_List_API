namespace Todo_List_API
{
    internal class Program
    {
        static void Main()
        {
            User user = new(1, "homeross", "davit.makhareishvili@gmail.com", "davitaa");
            User user1 = new(2, "homeros", "daharhvili@mail.ru", "dato");


            UserManager.Registration(user);
            UserLogin.Approve(user);
            UserManager.Registration(user1);
            UserLogin.Approve(user1);
      
        }
    }
}
