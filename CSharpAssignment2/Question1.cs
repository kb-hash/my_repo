using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment2
{
    class CardPayments
    {
        public double totalAmount;
        public int monthlyPayment;

        public void Calculator()
        {
            //to calculate 
            int month = 0;
            while (totalAmount > monthlyPayment)
            {
                totalAmount *= 1.015;
                totalAmount -= monthlyPayment;
                Console.WriteLine("Balance: {0:F3} Month:{1}  Total Payments:{2} ", totalAmount, ++month, monthlyPayment * month);
            }   
        }
        public void GetDetails()
        {
            Console.Write("Enter total balance:");
            totalAmount = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter monthly payment:");
            monthlyPayment = Convert.ToInt32(Console.ReadLine());
        }
    }
    class MonthlyPay
    {
        static void Main()
        {
            CardPayments pay = new CardPayments();
                pay.GetDetails();
            pay.Calculator();

            
        }
    }
}
