using System;
using System.Linq;
using ConsoleForum.Contracts;
using ConsoleForum.Utility;

namespace ConsoleForum.Commands
{
    public class LoginCommand : AbstractCommand
    {
        public LoginCommand(IForum forum) : base(forum)
        {
        }

        public override void Execute()
        {
            if (this.Forum.IsLogged)
            {
                throw new CommandException(Messages.AlreadyLoggedIn);
            }

            var users = this.Forum.Users;
            string username = this.Data[1];
            IUser user = users.FirstOrDefault(x => x.Username == username);
            string password = PasswordUtility.Hash(this.Data[2]);

            if (user == null || user.Password != password)
            {
                throw new CommandException(Messages.InvalidLoginDetails);
            }
            else
            {
                this.Forum.CurrentUser = user;
                this.Forum.Output.AppendLine(string.Format(Messages.LoginSuccess, username));
            }
        }
    }
}
