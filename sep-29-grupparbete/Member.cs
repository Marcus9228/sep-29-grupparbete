using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sep_29_grupparbete
{
    internal class Member : LibraryUser
    {
        private string adress;
        private List<Book> checkedOutBooks;
        private double overdueFees;
        TransactionClass transaction;
        private List<String> transactionHistory;

        public Member (string name, int id, string adress, double overdueFees)
        {
            Name = name;
            Id = id;
            Adress = adress;
            OverdueFees = overdueFees;
            checkedOutBooks = new List<Book> ();
            transactionHistory = new List<String> ();
            transaction = new TransactionClass ();
        }

        public void ViewTransactionHistory()
        {
            foreach (String history in transactionHistory)
            {
                Console.WriteLine (history);
            }
        }

        public void CheckOutBook(Book book)
        {
            CheckedOutBooks.Add(book);
            book.AvailableCopies -= 1;
            Console.WriteLine($"{book.Title} was loaned");
            string history = $"{book.Title} with isbn: {book.Isbn} was loaned";
            transactionHistory.Add(history);
        }

        public void ReturnBook(Book book)
        {
            Console.WriteLine("Enter the date you borrowed book: ");
            DateTime timeOfLoan = Convert.ToDateTime(Console.ReadLine());
            transaction.CalculateOverdueFee(timeOfLoan);
            CheckedOutBooks.Remove(book);
            book.AvailableCopies -= 1;
            Console.WriteLine($"{book.Title} was returned");
            string history = $"{book.Title} with isbn: {book.Isbn} was returned";
            transactionHistory.Add(history);
        }

        public string Adress
        {
            get { return adress; }
            set { adress = value; }
        }

        public List<Book> CheckedOutBooks
        {
            get { return checkedOutBooks; }
            set { checkedOutBooks = value; }
        }

        public double OverdueFees
        {
            get { return overdueFees; }
            set { overdueFees = value; }
        }

        public List<String> TransactionHistory
        {
            get { return transactionHistory; }
            set { transactionHistory = value; }
        }
    }
}
