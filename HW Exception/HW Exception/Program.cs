using System;

namespace HW_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Person p = new Person { Name = Console.ReadLine(), Age = Convert.ToInt32(Console.ReadLine()) };
            }
            catch (PersonException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine($"{ex.Value} is incorrect!");
            }
            Console.Read();



            ////3)  Simulate following exceptions:
            //IndexOutofBoundsException
            //NullReferenceException
            //ArgumentException
            //They all should occur in one try block but be caught in different catch blocks.

            //int[] number = { 8, 17, 24, 5, 25 };
            //int[] divisor = { 2, 0, 0, 5 };

            

            //for (int j = 0; j < number.Length; j++)

                
            //    try
            //    {

            //        Console.WriteLine("Number: " + number[j]);
            //        Console.WriteLine("Divisor: " + divisor[j]);
            //        Console.WriteLine("Quotient: " + number[j] / divisor[j]);
            //    }

                 
            //    catch (NullReferenceException)
            //    {

            //        Console.WriteLine("Null reference exception");
            //    }

                
            //    catch (IndexOutOfBoundsException)
            //    {
            //        Console.WriteLine("Index is Out of Bounds");
            //    }
                
            //    catch (ArgumentException)
            //    {
            //        Console.Write("Argument Exception");
            //    }
        }
    
    }
}
