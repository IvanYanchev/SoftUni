using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ConsoleForum.Contracts;
using ConsoleForum.Entities.Posts;

namespace ConsoleForum.Commands
{
    public class OpenQuestionCommand : AbstractCommand
    {
        public OpenQuestionCommand(IForum forum) : base(forum)
        {
        }

        public override void Execute()
        {
            int questionId = int.Parse(this.Data[1]);

            IQuestion question = this.Forum.Questions.FirstOrDefault(x => x.Id == questionId);

            if (question == null)
            {
                throw new CommandException(Messages.NoQuestion);
            }

            this.Forum.Output.AppendLine(question.ToString());

            if (question.Answers.Any())
            {
                this.Forum.Output.AppendLine("Answers:");
                foreach (IAnswer answer in question.Answers.OrderByDescending(x => x is BestAnswer))
                {
                    this.Forum.Output.AppendLine(answer.ToString());
                }
            }
            else
            {
                this.Forum.Output.AppendLine("No answers");
            }

            this.Forum.CurrentQuestion = question;
        }
    }
}
