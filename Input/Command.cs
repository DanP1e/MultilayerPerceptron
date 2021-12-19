using System.Collections.Generic;
using System.Linq;

namespace MultilayerPerceptron.Input
{
    internal abstract class Command
    {
        private string[] _aliases;
        private string _commandName;

        public string Name => _commandName;
        public IEnumerable<string> Aliases => _aliases;

        public Command(string commandName)
        {
            _commandName = commandName;
            _aliases = new string[0];
        }
        public Command(string commandName, string[] aliases)
        {
            _commandName = commandName;
            _aliases = aliases;
        }

        protected abstract void OnExecute(string[] args);

        public string GetInfo() 
        {
            return _commandName;
        }
        public virtual bool IsCanExecute(string[] args)
        {
            return args[0] == _commandName || _aliases.Any(x => x == args[0]);
        }
        public void Execute(string[] args) 
        {
            if (!IsCanExecute(args))
                throw new CommandExecuteException(this);
            OnExecute(args);
        }
    }
}
