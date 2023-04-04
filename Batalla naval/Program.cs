using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batalla_naval
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a Batalla naval." );
            Console.WriteLine("Usted va a marcar la posición inicial de su barco");

            // PEDIR DIRECCIÓN 

            string dir = "";
            int direction = 0;
            Console.WriteLine("¿En qué dirección va a ubicar su barco? Escriba 1 para horizontal o escriba 2 para vertical");
            dir = Console.ReadLine();
            direction = Convert.ToInt32( dir );

            if (direction == 1)
            {
                Console.WriteLine("la dirección de su barco será horizontal");
            }
            else if (direction == 2)
            {
                Console.WriteLine("la dirección de su barco será vertical");
            }
            else
            {
                Console.WriteLine("El valor ingresado no es válido");
            }


            //PEDIR LONGITUD

            Console.WriteLine("¿Cuál será la longitud de su barco? Ingrese un número entre el 1 y el 10");
            int tamano = int.Parse(Console.ReadLine());
            if ( 0 < tamano )
            {
                if (tamano < 10)
                {
                    Console.WriteLine("El tamaño de su barco será: " + tamano);
                } else
                {
                    Console.WriteLine("El tamaño no es válido");
                }
                
            }
            else
            {
                Console.WriteLine("El tamaño no es válido");
            }

            //PEDIR COORDENADA DEL BARCO INICIAL 

            Console.WriteLine("¿Dónde empezará el barco? Ingrese la coordenada de la siguiente forma -> x,y: ");
            string coord = Console.ReadLine();
            string[] coords = coord.Split(',');

            Console.WriteLine(coords[0]);
            Console.WriteLine(coords[1]);

            int[,] multiDimensionalArray1 = new int[2, 3];

            //Declare and set array element values
            int[,] multiDimensionalArray2 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            var rows = multiDimensionalArray2.GetLength(0);
            var columns = multiDimensionalArray2.GetLength(0);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.WriteLine($"The number in the position [{i}][{j}] is {multiDimensionalArray2[i, j]}");
                }

            }



        }
    }
}
