using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__tourtorial__2021_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.WriteLine("I am Learning C#");

            // Output ( It is awesome 6)
            Console.Write("It is awesome ");
            Console.Write(3 + 3);
            Console.WriteLine("\n");

            //Console.WriteLine();
            /*Console.WriteLine();*/

            //Variables

            //string name = "Athi";
            int Age = 21;
            int In4years = 4;

            //int Age = 21, In4years = 4;

            Console.WriteLine("Enter Name");
            string UserName = Console.ReadLine();
            Console.WriteLine("Name: " + UserName);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Age in 4 years: " + (Age + In4years)); //Age in 4 years
            Console.WriteLine();

            /*Casting
            Type casting is when you assign a value of one data type to another type.*/

            int myInt = 9;
            double myDouble = myInt;  //Implicit casting

            Console.WriteLine(myInt);
            Console.WriteLine(myDouble);


            double myDouble2 = 9.78;
            int myInt2 = (int)myDouble2; //Explicit casting

            Console.WriteLine(myInt2);
            Console.WriteLine(myDouble2);

            Console.WriteLine(Convert.ToBoolean(myDouble2)); //Type Conversion Method 

            //Assignmet Operators
            int x = 100 + 5;
            Console.WriteLine(x);
            x += 5; //Increment
            Console.WriteLine(x);

            //Comparison Operator
            int y = 100;
            Console.WriteLine(x <= y);

            //Logical Operator
            Console.WriteLine(x > 105 || y > 105);

            //MATH
            int a = 5, b = 10;

            Math.Min(a, b);

            Console.WriteLine(Math.Max(a, b));
            Console.WriteLine(Math.Sqrt(a * b));
            Console.WriteLine(Math.Abs(-5.10));
            Console.WriteLine(Math.Round(9.99));

            //String Interpolation

            string firstName = "James";
            string lastName = "Njamela";

            Console.WriteLine();
            string user = $"My full name is: {firstName} {lastName}";
            Console.WriteLine(user);
            Console.WriteLine();

            //Access Strings

            string myString = "Athenkosi";

            Console.WriteLine(myString[0]); //looks for the the first index from the assigned string

            Console.WriteLine(myString.IndexOf("e")); //looks for the position of "e" within the assigned string


            //If...Else

            int c = 10, d = 15;
            bool outcome = false;

            if (c == 10)
            {
                Console.WriteLine("Good");
            }
            
            if (d < c)
            {
                Console.WriteLine("Okay");

            }
            else
            {
                Console.WriteLine(outcome);
            }


            if (c > d)
            {
                Console.WriteLine("okay");
            }
            else if (c < d)
            {
                Console.WriteLine("Okay");
            }
            else
            {
                Console.WriteLine("Error");
            }



        }
     
    }



}
