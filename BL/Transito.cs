using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Transito : IEnumerable<Vehiculo>
    {
        private List<Vehiculo> mLista = new List<Vehiculo>();

        public void Agregar(Vehiculo mVehi)
        {
            mVehi.Marca = "Chevrolet";
            mLista.Add(mVehi);
            SemaforoRojo += mVehi.DetenerMarcha;
            SemaforoVerde += mVehi.Avanzar;
        }

        public IEnumerator<Vehiculo> GetEnumerator()
        {
            return mLista.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return mLista.GetEnumerator();
        }

        public delegate void DelegadoSemaforoRojo();
        public delegate void DelegadoSemaforoVerde();
        DelegadoSemaforoRojo SemaforoRojo;
        DelegadoSemaforoVerde SemaforoVerde;
        public void PonerSemaforoRojo()
        {
            if (SemaforoRojo != null)
            {
                SemaforoRojo();
            }
        }
        public void PonerSemaforoVerde()
        {
            if (SemaforoVerde != null)
            {
                SemaforoVerde();
            }
        }

    }
}
