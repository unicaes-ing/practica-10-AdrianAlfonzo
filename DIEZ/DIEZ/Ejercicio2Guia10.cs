using System;
using System.IO;

namespace DIEZ
{
    //------------------UNICAES------------------
    //---Facultad de Ingenería y Arquitectura---
    //--INGENIERÍA EN DESARROLLO DE SOFTWARE--
    //-Última fecha de modificación: 04.11.19
    //-------Luis Adrián Alfonzo Morán-------
    class Ejercicio2Guia10
    {
        static void Main(string[] args)
        {
            StreamWriter xdWriter = new StreamWriter("./PaisesDelDos.txt", true);
            Console.WriteLine("¿Cuántos países se agregarán a la lista?");
            int how = Convert.ToInt32(Console.ReadLine());
            string[] nameCountry = new string[how];
            Console.Clear();
            for (int i = 0; i < nameCountry.Length; i++)
            {
                Console.WriteLine("Pais {0}: ", i+1);
                nameCountry[i] = Console.ReadLine();
                xdWriter.WriteLine(nameCountry[i]);
                Console.Clear();
            }
            xdWriter.Close();
            StreamReader xdReader = new StreamReader("./PaisesDelDos.txt");
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Los países de la lista");
            Console.WriteLine("=========================");
            Console.ResetColor();
            Console.WriteLine(xdReader.ReadToEnd());
            xdReader.Close();
        }
    }
}
