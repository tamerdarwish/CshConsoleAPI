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
		public const string CMD_ADD = "add";
		public const string CMD_SUB = "sub";
		public const string CMD_MULT = "mult";
		public const string CMD_DIV = "div";





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
		public static bool CommandAdd(string[] parameters)
		{
			int sum = 0;
			foreach (string param in parameters)
			{
				sum += Convert.ToInt32(param);

			}
			Console.WriteLine(sum);
			return (true);
		}
		public static bool CommandSub(string[] parameters)
		{
			int sub1 = 0;
			foreach (string param in parameters)
			{
				sub1 = Convert.ToInt32(param);
				sub1--;

			}
			Console.WriteLine(sub1);
			return (true);
		}
		public static bool CommandMult(string[] parameters)
		{
			int mult = 1;
			foreach (string param in parameters)
			{
				mult *= Convert.ToInt32(param);

			}
			Console.WriteLine(mult);
			return (true);
		}
		public static bool CommandDiv(string[] parameters)
		{
			double div = 0;
			bool first = true;
			foreach (string param in parameters)
			{
				if (first)
				{
					first = false;
					div = Convert.ToDouble(param);

				}
				else
				{
					div /= Convert.ToDouble(param);
				}


			}
			Console.WriteLine(div);
			return (true);
		}
	}
}
