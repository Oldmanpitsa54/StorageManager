using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DL;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;
            string tName;
            decimal tPrice;
            int tExpirationDate;
            DateTime tProductionDate;
            int productNum;
            string output;
            
            Console.Write("Enter the storage size.");
            string input = Console.ReadLine();
            Validation.Int_Digits_check(input, out size);
            Good[] arr = new Good[size];
            int count = 0;

            do
            {
                Console.Write("1) Add new product \n2) Show te expiration date \n3) Exit \n\nYour choice: ");
                input = Console.ReadLine();
                int cases;
                Validation.Int_Digits_check(input, out cases);
                switch (cases)
                {
                    case 1:
                        Console.WriteLine("Adding new product.");
                      
                        Console.Write("Enter the name of this product.   ");
                        tName = Console.ReadLine();

                        Console.Write("Enter the price of this product.   ");
                        input = Console.ReadLine();
                        Validation.Decimal_Digits_check(input, out tPrice);

                        Console.Write("Enter the production date of this product.  ");
                        input = Console.ReadLine();
                        Validation.Date_check(input, out tProductionDate);

                        Console.Write("Enter the expiration date of this product.  ");
                        input = Console.ReadLine();
                        Validation.Int_Digits_check(input, out tExpirationDate);

                        Good product = new Good(tName, tPrice, tProductionDate, tExpirationDate);
                        
                        arr[count] = product;
                        count++;
                        
                        break;
                    case 2:
                        
                        do
                        {
                            Console.WriteLine("Show the expiration date of the product №: ");
                            input = Console.ReadLine();
                            Validation.Int_Digits_check(input, out productNum);
                        }
                        while (productNum > count || productNum < 0);
                        

                        
                    
                        output = Convert.ToString(arr[productNum].baseGood.Expiration());
                        Console.WriteLine("The expiration term expiring on " + output + "\n");

                        break;
                    case 3:
                        Console.WriteLine("Exit");
                        return;
                   

                    default:
                        Console.WriteLine("Error. Choose the menu item again.");
                        break;
                }
            } while (true);
        }
    }
}
