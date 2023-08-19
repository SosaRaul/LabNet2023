using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPooTransporte
{
    public class RegistroDeTransportes
    {
        private List<Omnibus> _listaOmnibus;
        private List<Taxi> _listaTaxis;
        private int _cantOmnibus;
        private int _cantTaxis;
        public RegistroDeTransportes(int cantOmnibus,int cantTaxis)
        {
            this._cantTaxis = cantTaxis;
            this._cantOmnibus = cantOmnibus;
        }

        public void CargarOmnibus()
        {
            _listaOmnibus = new List<Omnibus>();
            int cantidadPasajeros;
            int i = 0;
            do
            {
                Console.WriteLine($"Ingrese cantidad de pasajeros de Omnibus n° {i+1}: ");
                cantidadPasajeros = Convert.ToInt32(Console.ReadLine());
                Omnibus omnibusActual = new Omnibus(cantidadPasajeros);
                _listaOmnibus.Add(omnibusActual);
                i++;

            } while (i < _cantOmnibus);

        }

        public void CargarTaxis()
        {
            _listaTaxis = new List<Taxi>();
            int cantidadPasajeros;
            int i = 0;

            do
            {
                Console.WriteLine($"Ingrese cantidad de pasajeros de Taxi n° {i+1} ");
                cantidadPasajeros = Convert.ToInt32(Console.ReadLine());
                Taxi taxiActual = new Taxi(cantidadPasajeros);
                _listaTaxis.Add(taxiActual);
                i++;

            } while (i < _cantTaxis);
            
        }
        public void ListarOmnibus()
        {
            
            int contador = 1;
            foreach (Omnibus omnibus in _listaOmnibus)
            {
                Console.WriteLine($"Omnibus n° {contador} : {omnibus.GetPasajeros()} pasajeros");
                contador++; 
            }
        }
        public void ListarTaxis()
        {
            int contador = 1;
            foreach (Taxi taxi in _listaTaxis)
            {
                Console.WriteLine($"Taxi n° {contador} : {taxi.GetPasajeros()} pasajeros");
                contador++;
            }
        }
    }
}
