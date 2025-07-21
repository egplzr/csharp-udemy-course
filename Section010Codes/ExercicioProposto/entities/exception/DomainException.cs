using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Section010Codes.ExercicioProposto.entities.exception
{
    public class DomainException(string m) : ApplicationException(m)
    {
        
    }
}