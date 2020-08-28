using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_IoC
{
    public class App
    {
        IWriter Writer;

        public App(IWriter writer)
        {
            this.Writer = writer;
        }

        public void Run()
        {
            Writer.Write();
            Console.Read();
        }
    }
}
