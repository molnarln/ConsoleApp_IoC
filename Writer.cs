using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_IoC
{
    public class Writer : IWriter
    {
        public IContentService ContentService { get; set; }

        public Writer(IContentService cs)
        {
            this.ContentService = cs;
        }
        
        public void Write()
        {
            Console.WriteLine(this.ContentService.Content);
        }
    }
}
