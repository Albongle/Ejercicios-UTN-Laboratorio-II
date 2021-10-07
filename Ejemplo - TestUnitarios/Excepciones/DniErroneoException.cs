using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class DniErroneoException : Exception
    {
        public DniErroneoException(string message) : base(message)
        {
        }

        public DniErroneoException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
