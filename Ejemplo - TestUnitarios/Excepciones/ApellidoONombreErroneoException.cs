﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ApellidoONombreErroneoException : Exception
    {
        public ApellidoONombreErroneoException(string message) : base(message)
        {
        }

        public ApellidoONombreErroneoException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
