using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPooTransporte
{
    public class Taxi : TransportePublico
    {
        public Taxi(int pasajeros) : base(pasajeros)
        { 
        }
        public override void Avanzar()
        {
            Console.WriteLine("Soy un Taxi y estoy avanzando");
        }

        public override void Detenerse()
        {
            Console.WriteLine("Soy un taxi y me estoy deteniendo");
        }
    }
}
