using System;

namespace MultilayerPerceptron.Input
{
    internal class ClearConsoleCommand : Command
    {
        public ClearConsoleCommand(string executeName) : base(executeName)
        {
        }

        protected override void OnExecute(string[] args)
        {
            Console.Clear();
        }
    }
}
