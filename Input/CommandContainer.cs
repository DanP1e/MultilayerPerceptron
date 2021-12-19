using System.Collections.Generic;

namespace MultilayerPerceptron.Input
{

    internal class CommandContainer
    {
        private List<Command> _commands;
        private char _argumentSplitterChar;
        private char _spaceChar;

        public CommandContainer(char argumentSplitterChar, char spaceChar = ' ')
        {
            _commands = new List<Command>();
            _argumentSplitterChar = argumentSplitterChar;
            _spaceChar = spaceChar;
        }
        public CommandContainer(char argumentSplitterChar, char spaceChar, List<Command> commands)
        {
            _commands = commands;
            _argumentSplitterChar = argumentSplitterChar;
            _spaceChar = spaceChar;
        }

        public void ClearCommandsList() => _commands.Clear();
        public void AddCommand(Command command) => _commands.Add(command);
        public IEnumerable<Command> GetAllCommands() => _commands;
        public Command ExecuteCommand(string consoleInput) 
        {
            List<string> argsList = new List<string>(consoleInput.Split(_argumentSplitterChar));
            if (argsList.Count != 1 && argsList[argsList.Count - 1] == "")
                argsList.RemoveAt(argsList.Count - 1);

            string[] args = argsList.ToArray();

            foreach (var item in _commands)
            {
                if (item.IsCanExecute(args))
                {
                    item.Execute(args);
                    return item;
                }
            }

            throw new UnknownCommandException(argsList[0]);
        }
    }
}
