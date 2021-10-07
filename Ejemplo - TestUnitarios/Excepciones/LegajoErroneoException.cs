using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class LegajoErroneoException : Exception
    {
        public LegajoErroneoException(string message) : base(message)
        {
        }

        public LegajoErroneoException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
