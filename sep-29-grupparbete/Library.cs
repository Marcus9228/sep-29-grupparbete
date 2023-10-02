using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sep_29_grupparbete
{
    internal class Library
    {
        List<Shelf> shelves;
        List<Member> members;
        List<Librarian> librarians;
        List <TransactionClass> transactions;

        Library()
        {
            
            Shelves = new List<Shelf>();
            Members = new List<Member>();
            Librarians = new List<Librarian>();
            Transactions = new List<TransactionClass>();
        }

        public void LibraryStats()
        {
            int totalMembers = 0;
            int totalBooks = 0;
            Console.WriteLine($"Total amount of members: {totalMembers}");
            foreach (Member member in members)
            {
                totalMembers++;
            }
            Console.WriteLine($"Total amount of books registered in the library: {totalBooks}");
            foreach (Book book in Librarians[0].LibraryCollection)
            {
                totalBooks++;
            }
            Console.WriteLine("All available book titles in library: ");
            foreach (Shelf shelf in Shelves)
            {
                shelf.PrintAllBooks();
            }
            Console.WriteLine("All transactions for each registered member: ");
            foreach (Member member in members)
            {
                member.ViewTransactionHistory();
            }
        }

        public void AddShelf(Shelf shelf)
        {
            Shelves.Add(shelf);
        }
        public void RemoveShelf(Shelf shelf)
        {
            Shelves.Remove(shelf);
        }
        public void AddMember(Member member)
        {
            Members.Add(member);
        }
        public void RemoveMember(Member member)
        {
            Members.Remove(member);
        }
        public void HireLibrarian(Librarian librarian)
        {
            Librarians.Add(librarian);
        }
        public void FireLibrarian(Librarian librarian)
        {
            Librarians.Remove(librarian);
        }

        public List<Shelf> Shelves 
        { 
            get { return shelves; } 
            set { shelves = value; }
        }
        public List<Member> Members
        {
            get { return members; }
            set { members = value; }
        }
        public List<Librarian> Librarians
        { 
            get { return librarians; }
            set { librarians = value; }
        }
        public List<TransactionClass> Transactions
        {
            get { return transactions; }
            set { transactions = value; }
        }
    }
}
