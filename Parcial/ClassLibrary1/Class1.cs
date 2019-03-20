using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial
{
    public class Solucion
    {        
        int num1, num2, total;
        string nombre;
        public void METODO_1()
        {
            Console.WriteLine("Ingrese el primer numero: ");
            num1 = int.Parse(Console.ReadLine());

            if (num1 == 0)
            {
                Console.WriteLine("El producto de 0 por cualquier numero es 0");
            }
            else
            {
                Console.WriteLine("Ingrese el segundo numero: ");
                num2 = int.Parse(Console.ReadLine());
            }

            total = num1 * num2;
            Console.WriteLine("el total es; " + total);

            Console.ReadKey();
        }
        
        

        public void METODO_2()
        {
            Console.WriteLine("Ingrese el primer numero: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero: ");
            num2 = int.Parse(Console.ReadLine());

            if (num2 == 0)
            {
                Console.WriteLine("Error: No se puede dividir entre 0");
            }
            else
            {
                total = num1 / num2;
            }
            Console.WriteLine("el total es; " + total);
            Console.ReadKey();
        }

        public void METODO_3()
        {
            int f;
            for (f = 1; f == 5; f++)
            {
                Console.WriteLine("Ingrese su nombre: ");
                nombre = Console.ReadLine();
            }

            Console.WriteLine("Los Estudiantes son: " + nombre);

            Console.ReadKey();
        }
        }

    }


namespace ClassLibrary1
{
    public class Solucion
    {
    }
}
