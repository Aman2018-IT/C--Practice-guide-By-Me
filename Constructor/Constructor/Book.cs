using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class Book
    {
        public string title;
        public string Author;
        public int pages;

        public Book(string atitle,string aAuthor,int apages)//Constructor
        {
            Console.WriteLine("creating Book");
            title = atitle;
            Author = aAuthor;
                pages = apages;

        }
        public Book()
        {

        }
    }
}
