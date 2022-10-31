using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDemo.Sample2
{
	/// <summary>
	/// Invoker
	/// </summary>
	class User
	{
		double operand;
		Command command;
		int ptr = -1;

		IList<Command> commands = new List<Command>();
		IList<double> operands = new List<double>();

		public User SetCommand(Command cmd, double num)
		{
			ptr++;
			cmd.SetOpNum(num);

			this.operand = num;
			this.command = cmd;
			commands.Add(command);
			operands.Add(num);

			return this;
		}

		public void ExecuteCommand()
		{
			command.Execute();
		}

		public void Undo()
		{
			operand = operands[ptr];
			command = commands[ptr];
			command.SetOpNum(operand);
			command.UnExecute();

			ptr--;
		}

		public void Redo()
		{
			ptr++;

			operand = operands[ptr];
			command = commands[ptr];
			command.SetOpNum(operand);
			command.Execute();
		}


	}
}
