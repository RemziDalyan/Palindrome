using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace HW01VY16253018
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack<string> stack2 = new MyStack<string>();
            MyStack<string> stack1 = new MyStack<string>();
            MyStack<string> tempStack = new MyStack<string>();
            while (true)
            {
                Console.Write("\n  Enter the Expression: ");
                string sentence = Console.ReadLine().ToLower();
                Console.WriteLine("\n-------------------------\n");
                if (sentence != "")
                {

                    for (int i = 0; i < sentence.Length; i++)
                    {
                        if (sentence[i] > 96 && sentence[i] < 122)
                        {
                            stack1.push(sentence[i].ToString());
                            tempStack.push(sentence[i].ToString());
                        }
                    }
                    while (!tempStack.isEmpty())
                    {
                        stack2.push(tempStack.pop());
                    }
                    while (!stack2.isEmpty())
                    {
                        if (stack2.pop() != stack1.pop())
                        {
                            Console.WriteLine("This sentence is not palindrome\n");
                            return;
                        }

                    }
                    Console.WriteLine(" This sentence palindrome\n");
                    break;

                }
                Console.WriteLine("  Please enter a phrase");
                Thread.Sleep(1500);
                Console.Clear();
                
            }
            
            
        }
    }
}
