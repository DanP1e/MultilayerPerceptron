using System;
using System.Collections.Generic;

namespace MultilayerPerceptron.Input
{
    internal class HelpCommand : Command
    {
        private IEnumerable<Command> _commands;

        public HelpCommand(string executeName, IEnumerable<Command> usableCommands) : base(executeName)
        {
            _commands = usableCommands;
        }

        public override bool IsCanExecute(string[] args)
        {
            return base.IsCanExecute(args) || args[0] == "";          
        }

        protected override void OnExecute(string[] args)
        {
            Console.WriteLine("Avaliable commands: ");
            int counter = 0;
            foreach (var item in _commands)
            {
                Console.WriteLine($"{++counter} -> {item.Name} ");          
            }
        }
    }
}
