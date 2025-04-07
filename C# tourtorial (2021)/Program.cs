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
            Console.WriteLine("Name: "+UserName);
            Console.WriteLine("Age: "+Age);
            Console.WriteLine("Age in 4 years: " + (Age + In4years)); //Age in 4 years
            Console.WriteLine();

            /*Casting
            Type casting is when you assign a value of one data type to another type.*/

            int myInt = 9;
            double myDouble = myInt;  //Implicit casting

            Console.WriteLine(myInt);
            Console.WriteLine(myDouble);


            double myDouble2 = 9.78;
            int myInt2 = (int) myDouble2; //Explicit casting

            Console.WriteLine(myInt2);
            Console.WriteLine(myDouble2);

            Console.WriteLine(Convert.ToBoolean(myDouble2)); //Type Conversion Method 

            //Operators
            int x = 100 + 5;
            Console.WriteLine(x);




        }

    }


}
