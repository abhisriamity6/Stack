using System;
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
        public char pop(char element)
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

        }



    }
}


