namespace ConsoleForum.Entities.Users
{
    public class RegisteredUser : User
    {
        public RegisteredUser(int id, string name, string password, string email)
            : base(id, name, password, email)
        {
        }
    }
}
