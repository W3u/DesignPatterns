using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDemo.Sample2
{
	class Client
	{
		static void Main(string[] args)
		{
			Calculator calculator = new Calculator();
			OpAddCommand addCommand = new OpAddCommand(calculator);
			OpSubCommand subCommand = new OpSubCommand(calculator);
			OpMulCommand mulCommand = new OpMulCommand(calculator);
			OpDivCommand divCommand = new OpDivCommand(calculator);

			User user = new User();
			user.SetCommand(addCommand, 100).ExecuteCommand();
			user.SetCommand(subCommand, 50).ExecuteCommand();
			user.SetCommand(mulCommand, 10).ExecuteCommand();
			user.SetCommand(divCommand, 50).ExecuteCommand();

			user.Undo();
			user.Undo();

			user.Redo();

			Console.ReadKey();
		}
	}
}
