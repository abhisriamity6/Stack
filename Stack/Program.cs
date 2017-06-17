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

            StackArray[tos++] = element;


        }
        public char pop(char element)
        {

           return StackArray[tos--];


        }


        static void Main(string[] args)
        {
        }
    }
}
