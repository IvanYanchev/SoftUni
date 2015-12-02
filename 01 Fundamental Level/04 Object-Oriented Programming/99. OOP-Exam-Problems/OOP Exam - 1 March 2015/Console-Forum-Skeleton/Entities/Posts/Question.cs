using System.Collections.Generic;
using System.Text;
using ConsoleForum.Contracts;

namespace ConsoleForum.Entities.Posts
{
    public class Question : Post, IQuestion
    {
        private static int _id = 1;

        public Question(IUser author, string title, string body)
        {
            this.Author = author;
            this.Title = title;
            this.Body = body;
            this.Id = Question._id++;
            this.Answers = new List<IAnswer>();
        }

        public string Title { get; set; }
        public IList<IAnswer> Answers { get; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("[ Question ID: {0} ]", this.Id).AppendLine();
            sb.AppendFormat("Posted by: {0}", this.Author.Username).AppendLine();
            sb.AppendFormat("Question Title: {0}", this.Title).AppendLine();
            sb.AppendFormat("Question Body: {0}", this.Body).AppendLine();
            sb.Append("====================");
            return sb.ToString();
        }
    }
}
