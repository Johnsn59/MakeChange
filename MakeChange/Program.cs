using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace MakeChange
{
    class Program
    {
        static void Main(string[] args)
        {

            double purchasePrice = GetPurchasePrice();

            double paymentAmount = GetPaymentAmount();

            double changeDue = paymentAmount - purchasePrice;
            Console.WriteLine($"Change Due: ${changeDue}");
            changeDue += 0.000001;

            // How Many $20s
            int twenties = (int)(changeDue / 20);
            Console.WriteLine($"Twenties: {twenties}");
            changeDue = changeDue - twenties * 20;

            // How Many $10s
            int tens = (int)(changeDue / 10);
            Console.WriteLine($"Tens: {tens}");
            changeDue -= tens * 10;

            // How Many $5s
            int fives = (int)(changeDue / 5);
            Console.WriteLine($"Fives: {fives}");
            changeDue = changeDue % 5;

            // How Many $1s
            int ones = (int)(changeDue / 1);
            Console.WriteLine($"Ones: {ones}");
            changeDue %= 1;

            // How Many Quarters
            int quarters = (int)(changeDue / 0.25);
            Console.WriteLine($"Quarters: {quarters}");
            changeDue %= 0.25;

            // How Many Dimes
            int dimes = (int)(changeDue / 0.1);
            Console.WriteLine($"Dimes: {dimes}");
            changeDue %= 0.1;

            // How Many Nickels
            int nickels = (int)(changeDue / 0.05);
            Console.WriteLine($"Nickels: {nickels}");
            changeDue %= 0.05;

            // How Many Pennies
            int pennies = (int)(changeDue / 0.01);
            Console.WriteLine($"Pennies: {pennies}");

        }// End of Main
        static double GetPurchasePrice()
        {
            Console.Write("Purchase Price: ");
            double purchasePrice;
            purchasePrice = double.Parse(Console.ReadLine());
            return purchasePrice;
        }
        static double GetPaymentAmount()
        {
            Console.Write("Payment Amount: ");
            double paymentAmount = double.Parse(Console.ReadLine());
            return paymentAmount;

        }
    }
}
