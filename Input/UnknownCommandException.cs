using System;

namespace MultilayerPerceptron.Input
{
    internal class UnknownCommandException : Exception
    {
        public UnknownCommandException(string unknowCommandName) : base($"Can't execute unknown command {unknowCommandName}!")
        {
            
        }
    }
}
