using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sep_29_grupparbete
{
    internal class TransactionClass
    {
        private int transactionID;
        private string book;
        private string member;
        private DateTime issueDate;
        private DateTime returnDate;


        public double CalculateOverdueFee(DateTime DateOfLoan)
        {
            issueDate = DateOfLoan;
            TimeSpan date = returnDate.Subtract(issueDate);
            double overdueDays = date.TotalDays;
            double feeToPay = 0;
            if (overdueDays > 29)
            {
                double temp = overdueDays - 30;
                feeToPay = temp * 10;
            }
            return feeToPay;
        }

        //public double CalculateOverdueFee(DateTime DateOfLoan)
        //{
        //    issueDate = DateOfLoan;
        //    int overdueDays = issueDate.CompareTo(returnDate);
        //    double feeToPay = 0;
        //    if (overdueDays > 29)
        //    {
        //        double temp = overdueDays - 30;
        //        feeToPay = temp * 10;
        //    }
        //    return feeToPay;
        //}

        public int TransactionID
        {
            get { return transactionID; }
            set { transactionID = value; }
        }
        public string Book
        {
            get { return book; }
            set { book = value; }
        }
        public string Member
        {
            get { return member; }
            set { member = value; }
        }
        public DateTime IssueDate
        {
            get { return issueDate; }
            set { issueDate = value; }
        }
        public DateTime ReturnDate
        {
            get { return returnDate; }
            set { returnDate = value; }
        }
    }
}
