using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class TelefonoErroneoException : Exception
    {
        public TelefonoErroneoException(string message) : base(message)
        {
        }

        public TelefonoErroneoException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
