using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class FechaNacimientoErroneaException : Exception
    {
        public FechaNacimientoErroneaException(string message) : base(message)
        {
        }

        public FechaNacimientoErroneaException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
