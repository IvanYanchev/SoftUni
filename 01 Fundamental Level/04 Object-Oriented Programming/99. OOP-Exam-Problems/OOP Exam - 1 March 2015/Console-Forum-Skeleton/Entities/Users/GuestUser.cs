namespace ConsoleForum.Entities.Users
{
    public class GuestUser : User
    {
        public GuestUser(int id, string name, string password, string email)
            : base(id, name, password, email)
        {
        }
    }
}
