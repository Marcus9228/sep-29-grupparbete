using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sep_29_grupparbete
{
    internal class Book
    {
        private string title;
        private string author;
        private int isbn;
        private int totalCopies;
        private int availableCopies;

        public Book(string title, string author, int isbn, int totalCopies, int availableCopies) 
        {
            this.title = title;
            this.author = author;
            this.isbn = isbn;
            this.totalCopies = totalCopies;
            this.availableCopies = availableCopies;
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public int Isbn
        {
            get { return isbn; }
            set { isbn = value; }
        }
        public int TotalCopies
        {
            get { return totalCopies; }
            set { totalCopies = value; }
        }
        public int AvailableCopies
        {
            get { return availableCopies; }
            set { availableCopies = value; }
        }
    }
}
