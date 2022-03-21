using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09.SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            StringBuilder text = new StringBuilder();
            Stack<string> textStates = new Stack<string>();
            
            for (int i = 0; i < number; i++)
            {
                string[] command = Console.ReadLine().Split();
                int numberCommand = int.Parse(command[0]);
                if (numberCommand==1)
                {
                    textStates.Push(text.ToString());
                    string textToAdd = command[1];
                    text.Append(textToAdd);
                }
                else if (numberCommand==2)
                {
                    textStates.Push(text.ToString());
                    int count = int.Parse(command[1]);

                    for (int j = 0; j < count; j++)
                    {
                        text.Remove(text.Length-1,1);
                    }
                }
                else if (numberCommand == 3)
                {
                    int index = int.Parse(command[1]);
                    Console.WriteLine(text[index-1]);
                }
                else if (numberCommand == 4)
                {
                    text.Clear();
                    text.Append(textStates.Pop());
                }
            }
        }
    }
}
