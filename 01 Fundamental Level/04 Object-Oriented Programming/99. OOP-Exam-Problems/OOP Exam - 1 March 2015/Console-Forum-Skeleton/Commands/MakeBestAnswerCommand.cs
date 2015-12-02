using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleForum.Contracts;
using ConsoleForum.Entities.Posts;
using ConsoleForum.Entities.Users;

namespace ConsoleForum.Commands
{
    public class MakeBestAnswerCommand : AbstractCommand
    {
        public MakeBestAnswerCommand(IForum forum) : base(forum)
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

            int answerId = int.Parse(this.Data[1]);

            IAnswer answer = this.Forum.CurrentQuestion.Answers.FirstOrDefault(x => x.Id == answerId);

            if (answer == null)
            {
                throw new CommandException(Messages.NoAnswer);
            }

            IUser currentUser = this.Forum.CurrentUser;

            if (currentUser == this.Forum.CurrentQuestion.Author || currentUser is Administrator)
            {
                IAnswer currentBestAnswer = this.Forum.CurrentQuestion.Answers.FirstOrDefault(x => x is BestAnswer);
                if (currentBestAnswer != null && currentBestAnswer != answer)
                {
                    currentBestAnswer = (Answer)currentBestAnswer;
                }

                IAnswer newBestAnswer = new BestAnswer(answer.Author, answer.Body);
                newBestAnswer.Id = answer.Id;
                this.Forum.CurrentQuestion.Answers.Remove(answer);
                this.Forum.CurrentQuestion.Answers.Add(newBestAnswer);

                this.Forum.Output.AppendFormat(string.Format(Messages.BestAnswerSuccess, newBestAnswer.Id)).AppendLine();
            }
            else
            {
                throw new CommandException(Messages.NoPermission);
            }

        }
    }
}
