using System.Linq;
using ConsoleForum.Contracts;
using ConsoleForum.Entities.Posts;

namespace ConsoleForum.Commands
{
    public class ShowQuestionsCommand : AbstractCommand
    {
        public ShowQuestionsCommand(IForum forum) : base(forum)
        {
        }

        public override void Execute()
        {
            if (!this.Forum.Questions.Any())
            {
                throw new CommandException(Messages.NoQuestions);
            }

            foreach (IQuestion question in this.Forum.Questions.OrderBy(x => x.Id))
            {
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
            }
        }
    }
}
