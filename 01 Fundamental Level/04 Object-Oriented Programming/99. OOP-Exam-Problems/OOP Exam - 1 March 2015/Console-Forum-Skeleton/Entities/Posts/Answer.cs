using System.Text;
using ConsoleForum.Contracts;

namespace ConsoleForum.Entities.Posts
{
    public class Answer : Post, IAnswer
    {
        private static int _id = 1;

        public Answer(IUser author, string body)
        {
            this.Author = author;
            this.Body = body;
            this.Id = Answer._id++;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("[ Answer ID: {0} ]", this.Id).AppendLine();
            sb.AppendFormat("Posted by: {0}", this.Author.Username).AppendLine();
            sb.AppendFormat("Answer Body: {0}", this.Body).AppendLine();
            sb.Append("--------------------");
            return sb.ToString();
        }
    }
}
