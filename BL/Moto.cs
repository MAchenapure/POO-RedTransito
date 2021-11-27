using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Moto : Vehiculo
    {
        public int Cilindrada { get; set; }
        public enum TipoMoto { Scooter, Enduro, GranTurismo }

        public TipoMoto mTipo { get; set; }
        public override int Velocidad {
            get {
                if (Avanzando)
                {
                    int mVelocidad;
                    if(Cilindrada < 500)
                    {
                        mVelocidad = 70;
                    } else
                    {
                        mVelocidad = 80;
                    }

                    if(Moto.TipoMoto.Scooter == mTipo)
                    {
                        return (int)(mVelocidad * 0.5);
                    } else if(Moto.TipoMoto.GranTurismo == mTipo)
                    {
                        return mVelocidad * 2;
                    } else 
                    {
                        return mVelocidad;
                    }
                }
                else
                {
                    return 0;
                }
            }
            set => throw new NotImplementedException(); 
        }
    }
}
