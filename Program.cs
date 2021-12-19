using System;
using MultilayerPerceptron.Core;
using MultilayerPerceptron.Input;

namespace MultilayerPerceptron
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("Neural net initialization...");
            NeuralNetwork nn = new NeuralNetwork(2,2,2,1);
            nn.SetInputValues(1, 0);
            nn.CalculateNetwork();
            //Console.WriteLine("Enter save path: ");
            //string filename = Console.ReadLine();
            //nn.SaveToJson(filename);
            Console.WriteLine("Done!");
                     
            CommandContainer commandContainer = new CommandContainer(';');
            commandContainer.AddCommand(new HelpCommand("help", commandContainer.GetAllCommands()));
            commandContainer.AddCommand(new ClearConsoleCommand("clear"));

            Console.WriteLine("Enter the command: ");
            while (true)
            {
                while (true)
                {
                    try
                    {
                        string input = Console.ReadLine();
                        commandContainer.ExecuteCommand(input);
                        break;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }                
            }
        }
    }
}
