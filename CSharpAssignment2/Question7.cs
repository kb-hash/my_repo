using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment2
{
    class BankDetails
    {
        public string holderName;
        public int accountNo;
        public string typeOfAcc;
        public double balance;
        public void SetValues()
        {

        }
        public void Deposit()
        {
            Console.Write("Enter the amount:");
            double amt = Convert.ToDouble(Console.ReadLine());

        }
        public void Withdraw()
        {
            Console.WriteLine("Balance:{0}", balance);
            Console.Write("Enter amount to withdraw:");
            

        }
        public void Display()
        {

        }

    }
        class Question7
        {
        public static void Main()
        {
            BankDetails obj1 = new BankDetails();

        }
        }
    }


