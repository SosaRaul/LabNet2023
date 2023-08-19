using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPooTransporte
{
    public abstract class TransportePublico
    {
        public TransportePublico(int pasajeros)
        {
            this._pasajeros = pasajeros;
        }

        private int _pasajeros;
        public int GetPasajeros()
        {
            return this._pasajeros;
        }
        public void SetPasajeros(int pasajeros)
        {
            this._pasajeros = pasajeros;
        }
        public abstract void Avanzar();
        public abstract void Detenerse();
    }
}
