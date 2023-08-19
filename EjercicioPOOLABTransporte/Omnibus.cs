using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPooTransporte
{
    public class Omnibus : TransportePublico
    {
        public Omnibus(int pasajeros) : base(pasajeros) 
        { 
        }

        
        public override void Avanzar()
        {
            
            Console.WriteLine("Soy un Omnibus y estoy avanzando");
        }

        public override void Detenerse()
        {
            Console.WriteLine("Soy un Omnibus y estoy deteniendome");
        }
    }
}
