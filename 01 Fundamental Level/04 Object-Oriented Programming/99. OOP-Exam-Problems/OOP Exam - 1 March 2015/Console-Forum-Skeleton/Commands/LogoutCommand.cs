﻿using System;
using ConsoleForum.Contracts;

namespace ConsoleForum.Commands
{
    public class LogoutCommand : AbstractCommand
    {
        public LogoutCommand(IForum forum) : base(forum)
        {
        }

        public override void Execute()
        {
            if (!this.Forum.IsLogged)
            {
                throw new CommandException(Messages.NotLogged);
            }
            else
            {
                this.Forum.CurrentUser = null;
                this.Forum.CurrentQuestion = null;
                this.Forum.Output.AppendLine(string.Format(Messages.LogoutSuccess));
            }
        }
    }
}
