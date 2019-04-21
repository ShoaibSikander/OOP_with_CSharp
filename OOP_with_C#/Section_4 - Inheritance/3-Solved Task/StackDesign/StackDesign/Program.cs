using System;
using System.Collections;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stack Design Task!!!");
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine();
            var stackObject = new Stack();
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("You can push maximum 3 values into Stack.");
            Console.WriteLine("------------------------------------------------------------");

            int val;
            Console.WriteLine("Enter the 1st integer value which you want to push into Stack :");
            val = Convert.ToInt32(Console.ReadLine());
            stackObject.functionPush(val);

            Console.WriteLine("Enter the 2nd integer value which you want to push into Stack :");
            val = Convert.ToInt32(Console.ReadLine());
            stackObject.functionPush(val);

            Console.WriteLine("Enter the 3rd integer value which you want to push into Stack :");
            val = Convert.ToInt32(Console.ReadLine());
            stackObject.functionPush(val);

//            stackObject.functionClear();

            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("Values will be popped out now!!!\n");
            Console.WriteLine("Popping off " + stackObject.functionPop() + " is successful.\n");
            Console.WriteLine("Popping off " + stackObject.functionPop() + " is successful.\n");
            Console.WriteLine("Popping off " + stackObject.functionPop() + " is successful.\n");
        }
    }
}
