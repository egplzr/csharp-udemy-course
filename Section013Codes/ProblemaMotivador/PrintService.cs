using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Section013Codes.ProblemaMotivador
{
    public class PrintService<T>
    {
        private T[] _values = new T[10];
        private int _count = 0;

        public void AddValue(T value)
        {
            if (_count == 10)
            {
                throw new InvalidOperationException("PrintService has reached its maximum length");
            }
            _values[_count] = value;
            _count++;
        }

        public T First()
        {
            if (_count == 0)
            {
                throw new InvalidOperationException("PrintService is empty");
            }
            return _values[0];
        }

        public void Print()
        {
            if (_count == 0)
            {
                throw new InvalidOperationException("PrintService is empty");
            }
            System.Console.Write("[ ");
            foreach (T value in _values)
            {
                System.Console.Write(value + " ");
            }
            System.Console.Write("]");
        }
    }
}