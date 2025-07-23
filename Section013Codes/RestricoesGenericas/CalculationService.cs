using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Section013Codes.RestricoesGenericas
{
    public class CalculationService
    {
        public T Max<T>(List<T> list) where T : IComparable
        {
            if (list.Count == 0) throw new ArgumentException("The list can't be empty");
            
            T max = list[0];

            foreach (T t in list)
            {
                if (t.CompareTo(max) > 0) max = t;
            }

            return max;
        }
    }
}