using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {

        static void Main(string[] args)
        {
            // Algorithm1();
            // Algorithm2();
            //Algorithm3();
          // WordProblem();


        }

        static void Algorithm1()
        {
            int firstNumber = 0;
            int secondNumber = 0;
            
            //Sum = firstNumber + secondNumber;

            Console.WriteLine("Welcome to My program which allows you check the sum of two integers");
            Console.WriteLine("Caveat:Integers are numbers without any decimal point. E.g: 1, 20, 40");
            Console.WriteLine("Please enter a first integer");
            firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a second integer");
            secondNumber = Convert.ToInt32(Console.ReadLine());
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
            if (firstNumber + secondNumber == 30)
            {
                int sum = firstNumber + secondNumber;
                Console.WriteLine($"The sum of the first number and second number is {sum}");
                Console.WriteLine("Return true");
                // Console.ReadLine();
            }
            else if (firstNumber == 30 || secondNumber == 30)
            {
                Console.WriteLine("This is true");
                // Console.ReadLine();
            }
            else
            {
                int Number = firstNumber;
                Console.WriteLine($" {Number}\n Note: Number should be 30 or sum of the two numbers 30  ");
                // Console.ReadLine();
            }
            Console.ReadLine();

        }
        static void Algorithm2()
        {

            Console.WriteLine("A program that computes the sum of all positive prime numbers that can be in the int C# data type");
            Console.WriteLine("Type in  4,294,967,295");

            uint Number = 4294967295;
            Console.ReadLine();

            uint sum = 0;
            //for (int i = 0; i < 4000000; i++)
            {
                try
                {

                }
                catch (Exception)
                {

                    throw;
                } bool primeNumber = true;


                for (uint firstNum = 2; firstNum < Number; firstNum++)
                {
                    for (uint j = 2; j < Number; j++)
                    {
                        if (firstNum % j == 0 && firstNum != j)
                        {
                            primeNumber = false;
                            break;
                        }
                    }
                    if (primeNumber)
                    {
                        Console.Write($"\t{firstNum}");
                    //sum += firstNumber;
                   // Number++;
                    }
                }
            }
            Console.WriteLine(sum.ToString());
            Console.ReadLine();
        }

        static void Algorithm3()
        {

            Console.WriteLine("This program will check for a word inputed that contains 'Sa' and return the length of number after removing 'e' and 'm'");
            Console.WriteLine("Enter a word");
            string word = Console.ReadLine();


            if (word.Contains("sa"))
            {

                word = word.Replace("e", "");
                word = word.Replace("m", "");
                for (int j = 0; j < word.Length; j++)
                {
                    Console.WriteLine(word[j]);
                }
                try
                {

                }
                catch (Exception)
                {

                    throw;
                }  Console.WriteLine($"\n{word.Length}");

                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("word inputed");
                Console.WriteLine("Please the word you inputed does not start with sa");
            }
        }


        static void WordProblem()
        {
            Console.WriteLine("A program to determine the best newspapers to buy by a vendor in the 5th WEEK, by comparing sales made over a period of 4 WEEKS");
            Console.WriteLine("The News Papers are: PMNews, Guardian, Punch, and TheSun");
            Console.ReadLine();
            //string PMNews;
            //string Guardian;
            //string Punch;
            //string TheSun;

            //decimal Quantity = 0;
            //decimal Price = 0;

            List<decimal> finalSales = new List<decimal>();


            decimal QuantityPMNews1 = 23m;
            decimal PricePMNews1 = 150m;
            decimal QuantityGuardian1 = 10m;
            decimal PriceGuardian1 = 324.56m;
            decimal QuantityPunch1 = 12m;
            decimal PricePunch1 = 245.35m;
            decimal QuantityTheSun1 = 7m;
            decimal PriceTheSun1 = 420;

            decimal QuantityPMNews2 = 20m;
            decimal PricePMNews2 = 160m;
            decimal QuantityGuardian2 = 32m;
            decimal PriceGuardian2 = 300m;
            decimal QuantityPunch2 = 20m;
            decimal PricePunch2 = 220m;
            decimal QuantityTheSun2 = 10m;
            decimal PriceTheSun2 = 400m;

            decimal QuantityPMNews3 = 15m;
            decimal PricePMNews3 = 155m;
            decimal QuantityGuardian3 = 27m;
            decimal PriceGuardian3 = 315.28m;
            decimal QuantityPunch3 = 35m;
            decimal PricePunch3 = 265.5m;
            decimal QuantityTheSun3 = 13m;
            decimal PriceTheSun3 = 450.24m;

            decimal QuantityPMNews4 = 1m;
            decimal PricePMNews4 = 175m;
            decimal QuantityGuardian4 = 21;
            decimal PriceGuardian4 = 340m;
            decimal QuantityPunch4 = 19m;
            decimal PricePunch4 = 290.14m;
            decimal QuantityTheSun4 = 8m;
            decimal PriceTheSun4 = 400m;

            //Formular for calculating the amount sold in a week is:
            // Sales = Quantity * Price;

            // Case PMNews
            Console.WriteLine("Sales for PMNews in week 1 ");
            decimal PMweek1Sales = QuantityPMNews1 * PricePMNews1;
            Console.WriteLine($"Total sales for week 1 is {PMweek1Sales}");
            Console.ReadLine();
            Console.WriteLine("Sales for PMNews in week 2 ");
            decimal PMweek2Sales = QuantityPMNews2 * PricePMNews2;
            Console.Write($"Total sales for week 2 is  {PMweek2Sales}");
            Console.ReadLine();
            Console.WriteLine("Sales for PMNews in week 3 ");
            decimal PMweek3Sales = QuantityPMNews3 * PricePMNews3;
            Console.WriteLine($"Total sales for week 3 is {PMweek3Sales}");
            Console.ReadLine();
            Console.WriteLine("Sales for PMNews in week 4 ");
            decimal PMweek4Sales = QuantityPMNews4 * PricePMNews4;
            Console.WriteLine($"Total sales for week 4 is {PMweek4Sales}");
            Console.ReadLine();

            decimal PMNewsTotal = PMweek1Sales + PMweek2Sales + PMweek3Sales + PMweek4Sales;
            Console.WriteLine($"\tTotal sales after 4 weeks for PMNews is {PMNewsTotal}");
            Console.ReadLine();
           

            // Case Guardian
            Console.WriteLine("Sales for Guardian in week 1 ");
            decimal GDweek1Sales = QuantityGuardian1 * PriceGuardian1;
            Console.WriteLine($"Total sales for week 1 is {GDweek1Sales}");
            Console.ReadLine();
            Console.WriteLine("Sales for Guardian in week 2 ");
            decimal GDweek2Sales = QuantityGuardian2 * PriceGuardian2;
            Console.WriteLine($"Total sales for week 2 is {GDweek2Sales}");
            Console.ReadLine();
            Console.WriteLine("Sales for Guardian in week 3 ");
            decimal GDweek3Sales = QuantityGuardian3 * PriceGuardian3;
            Console.WriteLine($"Total sales for week 3 is {GDweek3Sales}");
            Console.ReadLine();
            Console.WriteLine("Sales for Guardian in week 4 ");
            decimal GDweek4Sales = QuantityGuardian4 * PriceGuardian4;
            Console.WriteLine($"Total sales for week 4 is {GDweek4Sales}");
            Console.ReadLine();

            decimal GDNewsTotal = GDweek1Sales + GDweek2Sales + GDweek3Sales + GDweek4Sales;
            Console.WriteLine($"\tTotal sales after 4 weeks for Guardian news is {GDNewsTotal}");
            Console.ReadLine();

            // Case Punch
            Console.WriteLine("Sales for Punch in week 1 ");
            decimal PUweek1Sales = QuantityPunch1 * PricePunch1;
            Console.WriteLine($"Total sales for week 1 is {PUweek1Sales}");
            Console.ReadLine();
            Console.WriteLine("Sales for Punch in week 2 ");
            decimal PUweek2Sales = QuantityPunch2 * PricePunch2;
            Console.WriteLine($"Total sales for week 2 is {PUweek2Sales}");
            Console.ReadLine();
            Console.WriteLine("Sales for Punch in week 3 ");
            decimal PUweek3Sales = QuantityPunch3 * PricePunch3;
            Console.WriteLine($"Total sales for week 3 is {PUweek3Sales}");
            Console.ReadLine();
            Console.WriteLine("Sales for Punch in week 4 ");
            decimal PUweek4Sales = QuantityPunch4 * PricePunch4;
            Console.WriteLine($"Total sales for week 4 is {PUweek4Sales}");
            Console.ReadLine();

            decimal PUNewsTotal = PUweek1Sales + PUweek2Sales + PUweek3Sales + PUweek4Sales;
            Console.WriteLine($"\tTotal sales after 4 weeks for Punch news is {PUNewsTotal}");
            Console.ReadLine();

            // Case TheSun
            Console.WriteLine("Sales for TheSun in week 1 ");
            decimal SUweek1Sales = QuantityTheSun1 * PriceTheSun1;
            Console.WriteLine($"Total sales for week 1 is {SUweek1Sales}");
            Console.ReadLine();
            Console.WriteLine("Sales for TheSun in week 2 ");
            decimal SUweek2Sales = QuantityTheSun2 * PriceTheSun2;
            Console.WriteLine($"Total sales for week 2 is {SUweek2Sales}");
            Console.ReadLine();
            Console.WriteLine("Sales for TheSun in week 3 ");
            decimal SUweek3Sales = QuantityTheSun3 * PriceTheSun3;
            Console.WriteLine($"Total sales for week 3 is {SUweek3Sales}");
            Console.ReadLine();
            Console.WriteLine("Sales for TheSun in week 4 ");
            decimal SUweek4Sales = QuantityTheSun4 * PriceTheSun4;
            Console.WriteLine($"Total sales for week 4 is {SUweek4Sales}");
            Console.ReadLine();

            decimal SUNewsTotal = SUweek1Sales + SUweek2Sales + SUweek3Sales + SUweek4Sales;
            Console.WriteLine($"\tTotal sales after 4 weeks for TheSun is {SUNewsTotal}");
            Console.ReadLine();

            //decimal totalSales = Decimal.Parse(Console.ReadLine());
            decimal totalSales = PMNewsTotal + GDNewsTotal + PUNewsTotal + SUNewsTotal;
            Console.WriteLine($"\t\tThe total Sales for all the newspapers in 4 weeks is {totalSales}");
            Console.ReadLine();
          
            //finalSales.Add((decimal)totalSales);
            // int.Compare(PMNewsTotal, GDNewsTotal){
            // }
            //int PMNewsTotal;
            //int GDNewsTotal;
            //int PUNewsTotal;
            //int SUNewsTotal;

            Console.WriteLine("Comparing the total sales of all news papers for 4 WEEKS from sales and quantity recorded, and recommending the best ones to get in the 5th WEEK");

            Console.WriteLine("For PMNews");
            if (PMNewsTotal > GDNewsTotal)
            {
                Console.WriteLine("Recommeded");
            }
            else if (PMNewsTotal > PUNewsTotal)
            {
                Console.WriteLine("Recommended");
            }
            else if (PMNewsTotal > SUNewsTotal)
            {
                Console.WriteLine("Recommended");
            }
            else
            {
                Console.WriteLine("Not recommended");
            }
            Console.ReadLine();

            //Console.WriteLine("Comparing the total sales of all news papers of 4 weeks");
            Console.WriteLine("For The GUARDIAN");
            if (GDNewsTotal > PMNewsTotal)
            {
                Console.WriteLine("Recommeded");
            }
            else if (GDNewsTotal > PUNewsTotal)
            {
                Console.WriteLine("Recommended");
            }
            else if (GDNewsTotal > SUNewsTotal)
            {
                Console.WriteLine("Recommended");
            }
            else
            {
                Console.WriteLine("Not recommended");
            }
            Console.ReadLine();


            Console.WriteLine("For The Punch");
            if (PUNewsTotal > PMNewsTotal)
            {
                Console.WriteLine("Recommeded");
            }
            else if (PUNewsTotal > GDNewsTotal)
            {
                Console.WriteLine("Recommended");
            }
            else if (PUNewsTotal > SUNewsTotal)
            {
                Console.WriteLine("Recommended");
            }
            else
            {
                Console.WriteLine("Not recommended");
            }
            Console.ReadLine();


            Console.WriteLine("For The Sun");
            if (SUNewsTotal > PMNewsTotal && PMNewsTotal > SUNewsTotal) 
            {
                Console.WriteLine("Recommeded");
            }
            else if (SUNewsTotal > GDNewsTotal && PMNewsTotal > SUNewsTotal )
            {
                Console.WriteLine("Recommended");
            }
            else if (SUNewsTotal > PUNewsTotal)
            {
                Console.WriteLine("Recommended");
            }
            else
            {
                Console.WriteLine("Not recommended");
            }
            Console.ReadLine();

            





            //decimal grossSales = 0;
            //foreach (var totalSales in finalSales)
            //{
            //    grossSales += totalSales;

            //}
            // Console.WriteLine("**** THE GROSS OF FIVE INVESTMENTS IS {0:C}", grossSales);
            // Console.ReadLine();

            //Console.WriteLine("Average sales for each News paper");

            // decimal Average = (PUNewsTotal / finalSales) * 100;

            // if (PMNewsTotal)
            // {

        }


    }
}          


        
   




    

