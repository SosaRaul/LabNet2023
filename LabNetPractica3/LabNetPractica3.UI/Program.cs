
using LabNetPractica3.Entities;
using LabNetPractica3.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNetPractica3.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option;
            do
            {
                Menu();
                try
                {
                    option = Int32.Parse(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            ShippersLogic shippersLogic = new ShippersLogic();
                            foreach (Shippers shipper in shippersLogic.GetAll())
                            {
                                Console.WriteLine(shipper.ShipperID + " " + shipper.CompanyName + shipper.Phone);
                            }
                            Console.WriteLine("\nPresione cualquier tecla para seguir\n");
                            Console.ReadKey();
                            break;

                        case 2:
                            SuppliersLogic suppliersLogic = new SuppliersLogic();
                            foreach (Suppliers supplier in suppliersLogic.GetAll())
                            {
                                Console.WriteLine(supplier.SupplierID + " " + supplier.CompanyName + supplier.Phone);
                            }
                            Console.WriteLine("\nPresione cualquier tecla para seguir\n");
                            Console.ReadKey();
                            break;
                        case 0:
                            Menu();
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("opcion invalida");
                    option = 0;
                }
             

            } while (option != 5);



        }
        static void Menu()
        {
            Console.WriteLine("Ingrese opcion :\n" +
                "1 - Listar tabla Shippers\n" +
                "2 - Listar tabla Suppliers\n" +
                "3 - Insertar registro en Shippers\n" +
                "5 - Borrar registro en Shippers\n" +
                "4 - Actualizar registro en Shippers\n" +
                "5 - TERMINAR");
        }
    }

}
