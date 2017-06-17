﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class StackClass
    {
        Char[] StackArray;
        int sizeofStack;
        int tos = 0;
        public StackClass(int size)
        {
            sizeofStack = size;
            StackArray = new char[sizeofStack];
        }
        public void push(char element)
        {

            if (tos < sizeofStack)
            {
                StackArray[tos++] = element;
            }

        }
        public char pop()
        {

            if (tos >= 0)
            {
                return StackArray[--tos];
            }
            else
                return '@' ;
        }

        public bool ISFull()
        {
            if(tos == sizeofStack)
            {
                return true;

            }
            else
            {

                return false;
            }

        }
        public bool ISEmpty()
        {
            if (tos == 0)
            {
                return true;

            }
            else
            {

                return false;
            }

        }
    }

    class CallStack
    {

        static void Main(string[] args)
        {

            int sizeofStack;
            Console.Write("Enter the size of Stack: ");
            sizeofStack = int.Parse(Console.ReadLine());
            StackClass Stack = new StackClass(sizeofStack);
            if (!Stack.ISFull())
            {
                Stack.push('A');
            }
            if (!Stack.ISEmpty())
            {
              Char element =   Stack.pop();
              Console.WriteLine(element);
                Console.Read();
            }
        }



    }
}


