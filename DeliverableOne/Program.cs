using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace DeliverableOne
{
    class Program
    {
        public static void Main(string[] args)

        {

            double dollar1, dollar2, dollar3, totalAmount;
            string answer1, answer2, answer3;


            // insert three different dollar amounts. 

            Console.WriteLine("Hello, please insert a dollar amount.");
            answer1 = Console.ReadLine();
            dollar1 = Convert.ToDouble(answer1);


            Console.WriteLine("Please insert a second dollar amount.");
            answer2 = Console.ReadLine();
            dollar2 = Convert.ToDouble(answer2);

            Console.WriteLine("Please insert the last dollar amount.");
            answer3 = Console.ReadLine();
            dollar3 = Convert.ToDouble(answer3);

            //  Sum the total the amount

           totalAmount = dollar1 + dollar2 + dollar3;

            Console.WriteLine("The total amount is :" + totalAmount);

            //calculate Average, Min and Max


            double[] numbers = new double[] { dollar1, dollar2, dollar3 };
            Console.WriteLine("The average is :" + numbers.Average());
            Console.WriteLine("The smallest value is " + numbers.Min());
            Console.WriteLine("The largest value is " + numbers.Max());

            //Format, convert and print results

            Double value = totalAmount;
            

            Console.WriteLine("USD :  " + value.ToString("C"));
            Console.WriteLine("Swedish : " + value.ToString("C", CultureInfo.CreateSpecificCulture("da-DK")));
            Console.WriteLine("Japanese : " + value.ToString("C", CultureInfo.CreateSpecificCulture("ja-JP")));
            Console.WriteLine("Thai : " + value.ToString("C", CultureInfo.CreateSpecificCulture("th-TH")));



            Console.WriteLine("Thank You");





        }

    }



}
