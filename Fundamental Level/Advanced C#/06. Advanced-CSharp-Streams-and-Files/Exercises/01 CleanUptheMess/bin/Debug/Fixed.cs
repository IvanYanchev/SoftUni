using System;
using Comandos;
namespace VehicleParkSystem2 
{
	classMecanismo :IMecanismo
	{
		private execex;
		Mecanismo(exec ex)
		{
			this.ex =ex;
		}
		public Mecanismo   (): this(new exec())
		{
			
		}
		public voidRunrunrunrunrun()
		{
			while(true)
			{
				string commandLine = Console.ReadLine();
				if (commandLine == null)
				{
					break;
				}
				commandLine.Trim();
				if (string.IsNullOrEmpty(commandLine))
				{
					try
					{
						varcomando=newexec.comando(commandLine);
						string commandResult=ex.execução(comando);
						Console.WriteLine(commandResult);
					}
					catch (Exception ex)
					{
						Console.WriteLine(ex.Message);
					}
				}	
			}
		}
	}
}