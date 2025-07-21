using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Section010Codes.ExercicioAula.entities.exceptions
{
    public class DomainExecption(string message) : ApplicationException(message)
    {
        
    }
}