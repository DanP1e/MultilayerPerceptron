using System;

namespace MultilayerPerceptron.Input
{
    internal class CommandExecuteException : Exception
    {
        public CommandExecuteException(Command command) : base($"Incorrect arguments for {command.Name} command!")
        {
        }       
    }
}
