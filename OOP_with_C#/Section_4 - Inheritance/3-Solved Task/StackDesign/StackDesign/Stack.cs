using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

namespace StackDesign
{
    public class Stack
    {
        private readonly List<object> myList = new List<object>();

        public Stack()
        {
            Console.WriteLine("Constructor called!!!\n");
            int StackSize = 3;
            object item = new Object[StackSize];
        }

        public void functionPush(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException("Null object cannot be pushed into Stack!!!");
            else
            {
                myList.Add(obj);
                Console.WriteLine("Value " + obj + " is pushed into Stack!!!\n");
            }
        }

        public object functionPop()
        {
                if (myList.Count == 0)
                    throw new InvalidOperationException("No element present in the stack!!!");
                else
                {

                    var lastItem = myList.Last();
                    myList.RemoveAt(myList.Count - 1);
                    return (lastItem);

                }
        }

        public void functionClear()
        {
            myList.Clear();
        }
    }
}