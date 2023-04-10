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
            const string seaCharacter = "~ ";
            const string boatCell = "Y ";
            const string wrongLocation = "X";
            const string correctLocation = "0";

            // SOLICITUD DE DATOS

            Console.WriteLine("Ingrese la posición del barco Vertical=1 Horizontal=0");
            int direction = Int32.Parse(Console.ReadLine());

            while (direction != 0 && direction != 1)
            {
                Console.WriteLine("La información ingresada no es correcta. Por favor ingrese 0 para Horizontal o 1 para Vertical");
                direction = Int32.Parse(Console.ReadLine());
            }

            Console.WriteLine("Ingrese la longitud del barco (Debe ser menor o igual a 9)");
            int longitud = Int32.Parse(Console.ReadLine());

            while (longitud < 0 || longitud > 9)
            {
                Console.WriteLine("La información ingresada no es correcta, por favor ingrese un numero de 0 al 9");
                longitud = Int32.Parse(Console.ReadLine());
            }

            Console.WriteLine("Ingrese donde se ubica el punto inicial del barco de forma x,y:");
            string coordenada = Console.ReadLine();
            string[] coordenadaFinal = coordenada.Split(',');

            int coor1;
            int coor2;

            while (coordenadaFinal.Length == 1 || int.TryParse(coordenadaFinal[0], out coor1) == false || int.TryParse(coordenadaFinal[1], out coor2) == false)
            {
                Console.WriteLine("Las coordenadas ingresadas son incorrectas. Ingrese la información de la forma (x,y)");
                coordenada = Console.ReadLine();
                coordenadaFinal = coordenada.Split(',');
            }

            Console.WriteLine(coordenadaFinal[0]);
            Console.WriteLine(coordenadaFinal[1]);

            //TABLERO

            string[,] map = new string[10, 10];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {

                    map[i, j] = seaCharacter;
                    Console.Write(map[i, j] + " ");
                }
                Console.WriteLine();
            }

        //VALIDAR

        string[] coor5 = new string[longitud];
        

        if (direction == 0)
        {
            for (int a = 0; a < longitud; a++)
            {
                coor5[a] = coordenadaFinal[0] + "," + coor2;
                coor2++;
            }

}
        else
{
    for (int a = 0; a < longitud; a++)
    {
        coor5[a] = coor1 + "," + coordenadaFinal[1];
        coor1++;
    }

}

        //LIMPIADOR
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkBlue;

        int shot = 0;
        int fail = 0;
        string valid = "";

do
{
    Console.WriteLine("¿En dónde cree que estará el barco? Ingrese las coordenadas de la forma x,y");
    string PlayerCoor = Console.ReadLine();
    string[] atack = PlayerCoor.Split(',');

    int coor3;
    int coor4;

    while (PlayerCoor.Length == 1 || int.TryParse(atack[0], out coor3) == false || int.TryParse(atack[1], out coor4) == false || PlayerCoor == valid)
    {
        Console.WriteLine("Las coordenadas ingresadas son incorrectas. Ingrese la informacion de la siguiente forma (x,y)");
        PlayerCoor = Console.ReadLine();
        atack = PlayerCoor.Split(',');

    }

    if (coor5.Contains(PlayerCoor))
    {
        valid = PlayerCoor;
        shot++;
        for (int i = 0; i < 10; i++)
        {

            for (int j = 0; j < 10; j++)
            {

                if (map[i, j] == correctLocation || map[i, j] == wrongLocation)
                {
                   map[i, j] = map[i, j];
                }
                else if (i == coor3 && j == coor4)
                {
                    map[i, j] = correctLocation;
                }
                else
                {
                    map[i, j] = seaCharacter;
                }

                Console.Write(map[i, j] + " ");

            }

            Console.WriteLine();
        }
    }
    else
    {
        valid = PlayerCoor;
        fail++;
        for (int i = 0; i < 10; i++)
        {

            for (int j = 0; j < 10; j++)
            {
                if (map[i, j] == correctLocation || map[i, j] == wrongLocation)
                {
                    map[i, j] = map[i, j];
                }
                else if (i == coor3 && j == coor4)
                {
                    map[i, j] = wrongLocation;
                }
                else
                {
                    map[i, j] = seaCharacter;
                }

                Console.Write(map[i, j] + " ");

            }

            Console.WriteLine();
        }
    }

        Console.WriteLine("Intentos Correctos: " + shot);
        Console.WriteLine("Intentos Fallidos: " + fail);

        if (shot == longitud)
        {
            for (int i = 0; i < 10; i++)
            {

                for (int j = 0; j < 10; j++)
                {

                    if (map[i, j] == correctLocation)
                    {
                        map[i, j] = boatCell;
                    }
                    else if (map[i, j] == wrongLocation)
                    {
                        map[i, j] = wrongLocation;
                    }
                    else
                    {
                        map[i, j] = seaCharacter;
                    }

                    Console.Write(map[i, j] + " ");

                }

                Console.WriteLine();
            }
            Console.WriteLine("¡Vuelve a jugar pronto!");
        }

        } while (shot != longitud);

        }
    }
}
