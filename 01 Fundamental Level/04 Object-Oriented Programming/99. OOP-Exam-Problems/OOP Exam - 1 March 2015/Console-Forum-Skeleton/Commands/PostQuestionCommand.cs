using ConsoleForum.Contracts;
using ConsoleForum.Entities.Posts;

namespace ConsoleForum.Commands
{
    public class PostQuestionCommand : AbstractCommand
    {
        public PostQuestionCommand(IForum forum) : base(forum)
        {
        }

        public override void Execute()
        {
            if (!this.Forum.IsLogged)
            {
                throw new CommandException(Messages.NotLogged);
            }

            IUser currentUser = this.Forum.CurrentUser;
            string title = this.Data[1];
            string body = this.Data[2];
            IQuestion question = new Question(currentUser, title, body);

            this.Forum.Questions.Add(question);

            this.Forum.Output.AppendLine(string.Format(Messages.PostQuestionSuccess, question.Id));
        }
    }
}
