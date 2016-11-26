using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace OS2
{
    public class Kernel : Sys.Kernel
    {
        public void OS()
        {
            Console.WriteLine("Welcome to my OS. Type help for a list of commands");
            bool on = true;
            while (on == true)
            {
                Console.Write("Input: ");
                var input = Console.ReadLine();
                if (input == "help")
                {
                    Console.WriteLine("Commands:");
                    Console.WriteLine("");
                    Console.WriteLine("about");
                    Console.WriteLine("hello");
                    Console.WriteLine("shutdown");
                    Console.WriteLine("");
                }
                else if (input == "about")
                {
                    Console.WriteLine("this is my first OS");
                }
                else if (input == "hello")
                {
                    Console.WriteLine("Hello what is your name?");
                    input = Console.ReadLine();
                    Console.WriteLine("Hello " + input + " and welcome to my first OS ; )");
                    Console.WriteLine("");
                }
                else if (input == "")
                {
                    
                }
                else if (input == "shutdown")
                {
                    on = false;
                }
                else
                {
                    Console.WriteLine("type help for a list of commands");
                }
            }
        }

        protected override void BeforeRun()
        {
            Console.WriteLine("OS BOOTED SUCCESSFULLY");
        }

        protected override void Run()
        {
            OS();
            this.Stop();
        }
    }
}
