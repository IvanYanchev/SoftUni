using ConsoleForum.Contracts;
using ConsoleForum.Entities.Posts;

namespace ConsoleForum.Commands
{
    public class PostAnswerCommand : AbstractCommand
    {
        public PostAnswerCommand(IForum forum) : base(forum)
        {
        }

        public override void Execute()
        {
            if (!this.Forum.IsLogged)
            {
                throw new CommandException(Messages.NotLogged);
            }

            if (this.Forum.CurrentQuestion == null)
            {
                throw new CommandException(Messages.NoQuestionOpened);
            }

            IUser currentUser = this.Forum.CurrentUser;
            string body = this.Data[1];
            IAnswer answer = new Answer(currentUser, body);

            this.Forum.CurrentQuestion.Answers.Add(answer);
            //this.Forum.Answers.Add(answer);

            this.Forum.Output.AppendLine(string.Format(Messages.PostAnswerSuccess, answer.Id));
        }
    }
}
