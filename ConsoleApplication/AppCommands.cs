using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;






namespace CshConsoleAPI
{
	public class AppCommands
	{
		public const string CMD_PROMPED = "\n>";
		public const string CMD_ECHO = "echo";





		/***
		* Echo demonstrates a command execution function.
		* the command prints the parameters it receives.
		*/
		public static bool CommandEcho(string[] parameters)
		{
			foreach (string param in parameters){
				Console.WriteLine(param);
			}
			return (true);
		}
	}
}
