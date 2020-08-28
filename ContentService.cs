using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_IoC
{
    public class ContentService : IContentService
    {
        public string Content { get; private set; }

        public ContentService()
        {
            Content = "ez az egyetlen content";
        }
    }
}
