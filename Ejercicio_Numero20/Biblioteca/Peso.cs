using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Peso
    {
        //Hacemos los mismo para Peso
        private double cantidad;
        private static double cotizRespectoDolar;

        //Generamos los constructores para Peso
        static Peso()
        {
            Peso.cotizRespectoDolar = 180;
        }

        public Peso(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Peso(double cantidad, double cotizacion)
            : this(cantidad)
        {
            Peso.cotizRespectoDolar = cotizacion;
        }

        //Generamos los Get para para la clase Peso

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
                return Peso.cotizRespectoDolar;
            }
        }

        //Generamos la sobrecargar implicita para double

        public static implicit operator Peso(double d)
        {
            return new Peso(d);
        }

        // Generamos las sobrecargas explicitas para Dolar y Euro

        public static explicit operator Dolar(Peso p)
        {
            return new Dolar((p.GetCantidad / Peso.GetCotizacion));
        }
        public static explicit operator Euro(Peso p)
        {
            return (Euro)((Dolar)p); // De esta manera re utilizamos las conversiones explicitas, tomamos el peso, lo convertimos a Dolar y el resultado de este a Euro
        }

        //Generamos las sobrecargas para los comparadores y operadores aritmeticos

        public static bool operator ==(Peso p1, Peso p2)
        {
            return (p1.GetCantidad == p2.GetCantidad);
        }
        public static bool operator !=(Peso p1, Peso p2)
        {
            return !(p1==p2);
        }
        public static bool operator ==(Peso p, Dolar d)
        {
            return (p.GetCantidad == ((Peso)d).GetCantidad);
        }
        public static bool operator !=(Peso p, Dolar d)
        {
            return !(p==d);
        }
        public static bool operator ==(Peso p, Euro e)
        {
            return (p.GetCantidad == ((Peso)e).GetCantidad);
        }
        public static bool operator !=(Peso p, Euro e)
        {
            return !(p==e);
        }

        public static Peso operator -(Peso p, Euro e)
        {
            return new Peso((p.GetCantidad - ((Peso)e).GetCantidad));
        }
        public static Peso operator -(Peso p, Dolar d)
        {
            return new Peso((p.GetCantidad - ((Peso)d).GetCantidad));
        }
        public static Peso operator +(Peso p, Euro e)
        {
            return new Peso((p.GetCantidad + ((Peso)e).GetCantidad));
        }
        public static Peso operator +(Peso p, Dolar d)
        {
            return new Peso((p.GetCantidad - ((Peso)d).GetCantidad));
        }
    }
}
