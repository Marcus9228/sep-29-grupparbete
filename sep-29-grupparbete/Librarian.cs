using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sep_29_grupparbete
{
    internal class Librarian : LibraryUser
    {
        private string position;
        private List<Book> libraryCollection;
        private List<Shelf> shelfCollection;

        public Librarian(string name, int id, string position)
        {
            Name = name;
            Id = id;
            Position = position;
            LibraryCollection = new List<Book>();
            ShelfCollection = new List<Shelf>();
        }

        public void AddBook(Book book)
        {
            if (!LibraryCollection.Contains(book))
            {
                LibraryCollection.Add(book);
                Console.WriteLine($"{book.Title} was added to the library collection");
            }
        }

        public void RemoveBook(Book book)
        {
            if (LibraryCollection.Contains(book)) {
                LibraryCollection.Remove(book);
                Console.WriteLine($"{book.Title} was removed to the library collection");
            }
        }

        public void IssueBook(Member member, Book book, Shelf shelf)
        {
            RemoveFromShelf(book, shelf);
            member.CheckOutBook(book);
        }

        public void AcceptReturnedBook(Member member, Book book, Shelf shelf, string category)
        {
            member.ReturnBook(book);
            AddToShelf(book, shelf, category);
        }

        public void SearchForBook(Book searchBook)
        {
            foreach (Book book in libraryCollection)
            {
                if (searchBook.Isbn == book.Isbn || searchBook.Title == book.Title || searchBook.Author == book.Author) 
                {
                    Console.WriteLine(book.Title);
                }
            }
        }

        public void SearchForBook(string category)
        {
            foreach (Shelf shelf in ShelfCollection)
            {
                if (shelf.Category == category)
                {
                   shelf.PrintAllBooks();
                }
            }
        }

        public void AddToShelf(Book book, Shelf shelf, string category)
        {
            if (shelf.Category == category)
            {
                shelf.BookShelf.Add(book);
                Console.WriteLine($"{book.Title} was added to the {category} shelf");
            }
        }

        public void RemoveFromShelf(Book book, Shelf shelf)
        {
            if (shelf.BookShelf.Contains(book))
            {
                shelf.BookShelf.Remove(book);
                Console.WriteLine($"{book.Title} was removed from the shelf");
            }
        }

        public List<Book> LibraryCollection
        {
            get { return libraryCollection; }
            set { libraryCollection = value; }
        }
        public List<Shelf> ShelfCollection
        {
            get { return shelfCollection; }
            set { shelfCollection = value; }
        }

        public string Position
        {
            get { return position; }
            set { position = value; }
        }
    }
}
