using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment2
{
    public class BookDetails
    {
        public object isbn;
        public string bookName;
        public string bookTitle;
        public string bookAuthor;
        public int qtyOfBook;
        public double bookPrice;

        public void DisplayDetails()
        {
            Console.WriteLine("Order Details:\n ISBN No: {0}\n Book Name:{1}\n Book Titile: {2}\n Book Author: {3}\n Quantity: {4}\n Price: {5}\n", isbn, bookName, bookTitle, bookAuthor, qtyOfBook, bookPrice);
            Console.WriteLine();
        }
        public void GetBill()
        {
            Console.Write("Enter number of books you want to buy:");
            int n = Convert.ToInt32(Console.ReadLine());
            double bill = n * bookPrice;
            Console.WriteLine("Total Bill amount is {0}", bill);

        }

    }

    class Test_Details
    {
        static void Main()
        {
            BookDetails b1 = new BookDetails();
            b1.isbn = "211 544 556 477";
            b1.bookName = "Prpgramming";
            b1.bookTitle = "Clean Code";
            b1.bookAuthor = "Robert Cecil Martin";
            b1.qtyOfBook = 40;
            b1.bookPrice = 3250;
          

            BookDetails b2 = new BookDetails();
            b2.isbn = "256 154 487 896";
            b2.bookName = "Programming";
            b2.bookTitle = "The Pragmatic Programmer";
            b2.bookAuthor = "Andy Hunt";
            b2.qtyOfBook = 25;
            b2.bookPrice = 4100;

            //asking for book
            Console.WriteLine("Available Books:\n 1.{0}\n 2.{1} ", b1.bookTitle, b2.bookTitle);
            Console.Write("Select one Book (Enter book number):");
            int x = int.Parse(Console.ReadLine());

            switch (x)
            {
                case 1:
                    b1.DisplayDetails();
                    b1.GetBill();
                    break;
                case 2:
                    b2.DisplayDetails();
                    b2.GetBill();
                    break;
                default:
                    Console.WriteLine("Please enter a vaild book number");
                    break;
            }
            
        }

    }
}
