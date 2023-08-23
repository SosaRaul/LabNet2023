using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace LabNetPractica2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PuntoUno();
            //Dividir();
            Logic logic = new Logic();
            try
            {
                logic.GenerarExcepcion();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            

            LogicExcepcionPersonalizada logicExcepcionPersonalizada = new LogicExcepcionPersonalizada();
            try
            {
                logicExcepcionPersonalizada.GenerarExcepcion();
            }
            catch(MyException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }

        
        // Metodo PUNTO 1
        public static void PuntoUno()
        {
            Console.WriteLine("Ingrese valor : ");
            int valor = Convert.ToInt32(Console.ReadLine());
            try
            {
                int resultado = 100 / valor;               
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Operacion finalizada");
            }
        }

        // Metodo PUNTO 2
        public static int Dividir()
        {
            try
            {
                Console.WriteLine("Ingrese dividendo: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese divisor: ");
                int b = Convert.ToInt32(Console.ReadLine());
                return a / b;
            }
            catch(FormatException)
            {
                Console.WriteLine("¡Seguro Ingreso una letra o no ingreso nada!");
                return -1;
            }
            catch(DivideByZeroException divEx)
            {
                Console.WriteLine("¡Solo Chuck Norris divide por cero!");
                Console.WriteLine(divEx.Message);
                return -1;
            }
        }

    }
}
