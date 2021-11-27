using System;

namespace BL
{
    public abstract class Vehiculo
    {
        public string Nombre { get; set; }

        private bool mAvanzando = true;
        public bool Avanzando { get { return mAvanzando; } private set { } }

        private string mMarca;
        public string Marca { get { return mMarca; } internal set { mMarca = value; } }

        public abstract int Velocidad { get; set; }
        public virtual void DetenerMarcha() {
            mAvanzando = false;
        }

        public virtual void Avanzar()
        {
            mAvanzando = true;
        }
    }
}
