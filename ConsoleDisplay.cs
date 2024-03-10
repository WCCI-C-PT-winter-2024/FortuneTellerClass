using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    public class ConsoleDisplay : IConsoleDisplay
    {
        public void ClearScreen(string prompt = "")
        {
            Console.Clear();
            Console.WriteLine();
            if (!prompt.CheckForNull())
            {
                Console.WriteLine(prompt);
                Console.WriteLine();
            }
        }

        public string PromptInput(string display, bool isInteger = false, string helpMessage = "")
        {
            string result = string.Empty;
          

            string? lineInput = string.Empty;
            while (result.CheckForNull())
            {
                Console.Write($"{display}? ");
                lineInput = Console.ReadLine();

                if (!lineInput.CheckForNull() && lineInput.ToUpper() == "HELP")
                {
                    lineInput = string.Empty;
                    if (!helpMessage.CheckForNull())
                    {
                        Console.WriteLine(helpMessage);
                    }
                }else if (!lineInput.CheckForNull() && lineInput.ToUpper() == "QUIT")
                {
                    Console.WriteLine("Nobody likes a quitter...");
                    // This is a bad way to exit...
                    Environment.Exit(0);
                }
                if(!lineInput.CheckForNull())
                {
                    result = lineInput;
                }
                else // lineInput is null here
                {
                    Console.WriteLine("Invalid input");
                    continue;
                }
                if (isInteger)
                {
                    int intValue;
                    if(!int.TryParse(lineInput, out intValue))
                    {
                        result = string.Empty;
                        Console.WriteLine("Invalid input");
                        continue;
                    }
                }
            }

            return result;
        }


        public string? ReadLine()
        {
            return Console.ReadLine();
        }

        public void Write(string line)
        {
            Console.Write(line);
        }

        public void WriteLine(string? line = null)
        {
            Console.WriteLine(line);
        }
    }
}
