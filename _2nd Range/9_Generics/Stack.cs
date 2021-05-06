using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Generics
{
    //classes and arrays can also be generic so there's flexibility when handling different types of values
    
    class Stack<T>
    {
        int index = 0;
        T[] innerArray = new T[100];

        public void push(T item)
        {
            innerArray[index++] = item;
        }

        public T Pop()
        {
            return innerArray[--index];
        }

        public T get(int k)
        {
            return innerArray[k];
        }
    }
}
