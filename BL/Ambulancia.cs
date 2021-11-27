using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Ambulancia : Vehiculo
    {
        public bool EnEmergencia { get; set; }

        public override int Velocidad {
            get
            {
                if (Avanzando)
                {
                    return 100;
                }
                else
                {
                    return 0;
                }
            }
            set => throw new NotImplementedException(); 
        }
        public override void DetenerMarcha()
        {
            if (!EnEmergencia)
            {
                base.DetenerMarcha();
            }
        }
    }
}
