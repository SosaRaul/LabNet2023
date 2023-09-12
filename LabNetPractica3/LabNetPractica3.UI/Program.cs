
using LabNetPractica3.Entities;
using LabNetPractica3.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace LabNetPractica3.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ILogic<Suppliers> suppliersLogic = new SuppliersLogic();
            ILogic<Shippers> shippersLogic = new ShippersLogic();
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
                            foreach (Shippers shipper in shippersLogic.GetAll())
                            {
                                Console.WriteLine(shipper.ShipperID + " " + shipper.CompanyName + " " + shipper.Phone);
                            }
                            Console.WriteLine("\nPresione cualquier tecla para seguir\n");
                            Console.ReadKey();
                            break;

                        case 2:
                            foreach (Suppliers supplier in suppliersLogic.GetAll())
                            {
                                Console.WriteLine(supplier.SupplierID + " " + supplier.CompanyName + supplier.Phone);
                            }
                            Console.WriteLine("\nPresione cualquier tecla para seguir\n");
                            Console.ReadKey();
                            break;

                        case 3:
                            Console.WriteLine("Ingrese CompanyName: ");
                            string companyName = Console.ReadLine();
                            Console.WriteLine("Ingrese Phone: ");
                            string phone = Console.ReadLine();
                            Shippers newShipper = new Shippers { CompanyName = companyName, Phone = phone };
                            shippersLogic.Add(newShipper);
                            break;

                        case 4:
                            Console.WriteLine("Ingrese id de registro a borrar ");
                            try
                            {
                                int id = Int32.Parse(Console.ReadLine());
                                shippersLogic.Delete(id);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                                Console.WriteLine("id no valido");
                                option = 0;
                            }
                            break;

                        case 5:
                            Shippers myShipper = new Shippers();
                            Console.WriteLine("Ingrese ID ");
                            myShipper.ShipperID = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese nombre compania ");
                            myShipper.CompanyName = Console.ReadLine();
                            Console.WriteLine("Ingrese telefono ");
                            myShipper.Phone = Console.ReadLine();
                            shippersLogic.Update(myShipper);
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


            } while (option != 6);


        }
        static void Menu()
        {
            Console.WriteLine("Ingrese opcion :\n" +
                "1 - Listar tabla Shippers\n" +
                "2 - Listar tabla Suppliers\n" +
                "3 - Insertar registro en Shippers\n" +
                "4 - Borrar registro en Shippers\n" +
                "5 - Actualizar registro en Shippers\n" +
                "6 - TERMINAR");
        }
    }

}
