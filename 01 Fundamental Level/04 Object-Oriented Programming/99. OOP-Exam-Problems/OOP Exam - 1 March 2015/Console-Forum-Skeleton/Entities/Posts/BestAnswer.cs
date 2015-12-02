using ConsoleForum.Contracts;

namespace ConsoleForum.Entities.Posts
{
    public class BestAnswer : Answer
    {
        public BestAnswer(IUser author, string body) : base(author, body)
        {
        }

        public override string ToString()
        {
            return "********************\n" + base.ToString() + "\n********************";
        }
    }
}