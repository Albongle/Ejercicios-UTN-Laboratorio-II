using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ExtensionInvalidaException : Exception
    {
        public ExtensionInvalidaException(string message) : base(message)
        {
        }

        public ExtensionInvalidaException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
