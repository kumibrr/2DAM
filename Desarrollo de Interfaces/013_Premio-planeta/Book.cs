using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013_Premio_planeta
{
    class Book
    {
        private string writer;
        private string title;
        private string bookCover;
        private string synopsis;

        public Book(string writer, string title, string bookCover)
        {
            this.writer = writer;
            this.title = title;
            this.bookCover = bookCover;
        }

        public void addSynopsis (string synopsis)
        {
            this.synopsis = synopsis;
        }

        public string getWriter()
        {
            return this.writer;
        }

        public string getTitle()
        {
            return this.title;
        }

        public string getBookCover()
        {
            return this.bookCover;
        }

        public string getSynopsis()
        {
            return this.synopsis;
        }

    }
}
