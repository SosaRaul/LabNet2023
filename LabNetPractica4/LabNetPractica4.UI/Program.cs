using LabNetPractica4.Entities;
using LabNetPractica4.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNetPractica4.UI
{
    public class Program
    {
        static void Main(string[] args)
        {
            int option;
            do
            {
                Menu();
                try
                {   CustomersLogic customerLogic = new CustomersLogic();
                    ProductsLogic productsLogic = new ProductsLogic();
                    option = Int32.Parse(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Customer customer1 = customerLogic.Punto1();
                            Console.WriteLine($"Info del Objeto Customer devuelto:\n{customer1.ContactName} | {customer1.CompanyName}");       
                            Console.WriteLine("\nPresione cualquier tecla para seguir\n");
                            Console.ReadKey();
                            break;

                        case 2:
                            foreach(Product producto in productsLogic.Punto2())
                            {
                                Console.WriteLine($" {producto.ProductID} | {producto.ProductName} ");
                            }
                            Console.WriteLine("\nPresione cualquier tecla para seguir\n");
                            Console.ReadKey();
                            break;

                        case 3:
                            foreach (Product producto in productsLogic.Punto3())
                            {
                                Console.WriteLine($" {producto.ProductID} | {producto.ProductName} ");
                            }
                            Console.WriteLine("\nPresione cualquier tecla para seguir\n");
                            Console.ReadKey();
                            break;
                        
                        case 4:
                            foreach (Customer customer4 in customerLogic.Punto4())
                            {
                                Console.WriteLine($" {customer4.CustomerID} | {customer4.ContactName} ");
                            }
                            Console.WriteLine("\nPresione cualquier tecla para seguir\n");
                            Console.ReadKey();
                            break;

                        case 5:
                            Console.WriteLine(productsLogic.Punto5());
                            Console.WriteLine("\nPresione cualquier tecla para seguir\n");
                            Console.ReadKey();
                            break;

                        case 6:
                            foreach(string customer6 in customerLogic.Punto6())
                            {
                                Console.WriteLine($" {customer6}".ToUpper());
                            }
                            Console.WriteLine("\nPresione cualquier tecla para seguir\n");
                            Console.ReadKey();
                            break;

                        case 7:
                            foreach (string customer7 in customerLogic.Punto6())
                            {
                                Console.WriteLine($" {customer7}".ToLower());
                            }
                            Console.WriteLine("\nPresione cualquier tecla para seguir\n");
                            Console.ReadKey();
                            break;

                        case 9:
                            foreach(Customer customer9 in customerLogic.Punto8())
                            {
                               Console.WriteLine($" {customer9.CustomerID} | {customer9.ContactName} ");
                            }
                            Console.WriteLine("\nPresione cualquier tecla para seguir\n");
                            Console.ReadKey();
                            break;

                        case 10:
                            Menu();
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("opcion invalida");
                    option = 0;
                }


            } while (option != 10);



        }

        public static void Menu()
        {
            Console.WriteLine("Ingrese opcion :\n" +
                "1 - Punto 1\n" +
                "2 - Punto 2\n" +
                "3 - Punto 3\n" +
                "4 - Punto 4\n" +
                "5 - Punto 5\n" +
                "6 - Punto 6 (Nombres en mayusculas)\n" +
                "7 - Punto 6 (Nombres en minusculas)\n" +
                "8 - Punto 7\n" +
                "9 - Punto 8\n " +
                "10 - TERMINAR\n");

        }



    }
}
