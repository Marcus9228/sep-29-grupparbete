using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace sep_29_grupparbete
{
    internal class Shelf
    {
        private int id;
        private string category;
        private List<Book> bookShelf;
        private int shelfSize;

        public Shelf(int id, string category) 
        { 
            Id = id;
            Category = category;
            bookShelf = new List<Book>();
            shelfSize = 5;
        }

        public void PrintAllBooks()
        {
            foreach (Book book in bookShelf)
            {
                Console.WriteLine(book.Title);

            }
        }

        public bool IsFull()
        {
            if (bookShelf.Count == shelfSize)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Category
        {
            get { return category; }
            set { category = value; }
        }

        public List<Book> BookShelf
        {
            get { return bookShelf; }
            set { bookShelf = value; }
        }

        public int ShelfSize
        {
            get { return shelfSize; }
            set { shelfSize = value; }
        }
    }
}
