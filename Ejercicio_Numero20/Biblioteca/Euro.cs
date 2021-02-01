using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euro
    {
        //Generamos los atributos para Euro
        private double cantidad;
        private static double cotizRespectoDolar;

        //Generamos los constructores para Euro
        static Euro()
        {
            Euro.cotizRespectoDolar = 1/1.18;
        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, double cotizacion)
            : this(cantidad)
        {
            Euro.cotizRespectoDolar = cotizacion;
        }

        //Generamos los Get para para la clase Euro

        public double GetCantidad
        {
            get
            {
                return this.cantidad;
            }
        }
        public static double GetCotizacion
        {
            get
            {
                return Euro.cotizRespectoDolar;
            }
        }

        //Generamos la sobrecargar implicita para double

        public static implicit operator Euro(double d)
        {
            return new Euro(d);
        }

        //Generamos las sobrecargas explicitas para Peso y Dolar

        public static explicit operator Dolar(Euro e)
        {
            return new Dolar((e.cantidad / Euro.GetCotizacion));
        }
        public static explicit operator Peso(Euro e)
        {
            return (Peso)((Dolar)e); // de esta manera re utilizamos las conversiones explicitas.
        }
        //Generamos las sobrecargas para los comparadores y operadores aritmeticos

        public static bool operator == (Euro e1, Euro e2)
        {
            return (e1.GetCantidad == e2.GetCantidad);
        }
        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1== e2);
        }
        public static bool operator == (Euro e,Dolar d)
        {
            return (e.GetCantidad == ((Euro)d).GetCantidad);
        }
        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e==d);
        }
        public static bool operator == (Euro e, Peso p)
        {
            return (e.GetCantidad == ((Euro)p).GetCantidad);
        }
        public static bool operator !=(Euro e, Peso p)
        {
            return !(e==p);
        }
        public static Euro operator - (Euro e, Peso p)
        {
            return new Euro((e.GetCantidad - ((Euro)p).GetCantidad));
        }
        public static Euro operator -(Euro e, Dolar d)
        {
            return new Euro((e.GetCantidad - ((Euro)d).GetCantidad));
        }
        public static Euro operator +(Euro e, Peso p)
        {
            return new Euro((e.GetCantidad + ((Euro)p).GetCantidad));
        }
        public static Euro operator +(Euro e, Dolar d)
        {
            return new Euro((e.GetCantidad + ((Euro)d).GetCantidad));
        }

    }
}
