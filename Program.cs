using System;
using System.Collections.Generic;
using System.Text;

namespace Impuesto
{
    class Program
    {
        static void Main(string[] args)
        {
            float impuesto = 15.0f;
            string articulo = "";
            int opcion = 0;
            float costo = 1.0f;
            float total = 1.0f;

            Console.WriteLine("Ingrese el articulo");
            articulo = Console.ReadLine();

            Console.WriteLine("Ingrese el costo");
            costo = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Ingrese opcion");
            
            Console.WriteLine("1- Normal ");

            Console.WriteLine("2- Medicina");
            opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion == 1)
            {
                total = costo + costo * (impuesto / 100);

                Console.WriteLine("El total a pagar son {0} Bs.", total);
            
            }
            else if (opcion == 2)
            {
                total = costo;

                Console.WriteLine("El total a pagar son {0} Bs.", total);

            }
            else
            {
                Console.WriteLine("Opcion no valida");
            }

            Console.ReadKey();

        }
    }
}
