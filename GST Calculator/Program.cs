using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GST_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get the product name from the user
            Console.WriteLine("Pleasee enter the product name :");
            String productName = Console.ReadLine();

            // Get the quantity from user
            Console.WriteLine("Please enter the quantity:");
            int quantity = Convert.ToInt32(Console.ReadLine());

            //Get the product cost from the user
            Console.WriteLine("Please enter the product cost:");
            double productCost = Convert.ToDouble(Console.ReadLine());


            // Check the GST is included or not
            Console.WriteLine("Is product cost included GST (Yes/No):");
            String  checkGst = Console.ReadLine();

            // Dispaly the new value with GST 
            Console.WriteLine("Product name: {0}", productName);
            Console.WriteLine("Quantity: {0}", quantity);
            Console.WriteLine("Product cost: {0}", productCost);

            if (checkGst == "Yes")

            { // Calculate the GST amount and new price after removing GST
                double gstAmount = productCost * quantity * 3 / 23;
                Console.WriteLine("GST Amount: {0}", gstAmount);

                double newPrice = productCost * quantity - gstAmount;
                Console.WriteLine("New price: {0}", newPrice);


            }
            else
            { // Calculate the GST amount and new price after adding GST
                double gstAmount = productCost * quantity * 15 / 100;
                Console.WriteLine("GST Amount: {0}", gstAmount);

                double newPrice = productCost * quantity + gstAmount;
                Console.WriteLine("New price: {0}", newPrice);
            }
           
           
            Console.ReadKey();


        }
    }   
}
