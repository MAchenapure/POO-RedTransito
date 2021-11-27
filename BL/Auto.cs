using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Auto : Vehiculo
    {
        public int Cilindrada { get; set; }

        public bool Deportivo { get; set; }

        public override int Velocidad {
            get {
                if (Avanzando)
                {
                    int mVelocidad = 30 * (Cilindrada / 1000);
                    if (!Deportivo) { return mVelocidad; }
                    else { return (int)(mVelocidad * 1.4); }
                } else
                {
                    return 0;
                }
            } 
            set => throw new NotImplementedException(); 
        }
    }
}
