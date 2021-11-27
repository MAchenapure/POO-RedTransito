using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Colectivo : Vehiculo
    {

        public static Colectivo operator +(Colectivo x, int y)
        {
            Colectivo c = new Colectivo();

            c.Nombre = x.Nombre;
            c.DoblePiso = x.DoblePiso;
            c.Pasajeros = x.Pasajeros + y;

            return c;
        }

        public int Pasajeros { get; set; }
        public bool DoblePiso { get; set; }

        public override int Velocidad {
            get {
                if (Avanzando)
                {
                    if(Pasajeros >= 100)
                    {
                        return 50;
                    } else
                    {
                        return 80;
                    }
                } else
                {
                    return 0;
                }
            }
            set => throw new NotImplementedException(); 
        }
    }
}
