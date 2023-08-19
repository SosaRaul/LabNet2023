using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPooTransporte
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese cantidad de taxis a registrar : ");
            int cantidadTaxis = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese cantidad de Omnibus a registrar : ");
            int cantidadOmnibus = Convert.ToInt32(Console.ReadLine());

            RegistroDeTransportes miRegistro = new RegistroDeTransportes(cantidadOmnibus, cantidadTaxis);
            miRegistro.CargarTaxis();
            miRegistro.CargarOmnibus();
            Console.WriteLine("TOTALES :");
            miRegistro.ListarTaxis();
            miRegistro.ListarOmnibus();
            Console.ReadKey();
            
            

        }
    }
    
}
