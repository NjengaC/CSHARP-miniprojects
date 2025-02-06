using System;
using System.Collections.Generic;

namespace Generics
{
    public class Printer<T>
    {
        public void PrintAll(IEnumerable<T> collection)
        {
            foreach (T item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
