using System;
using System.IO;

namespace DIEZ
{
    //------------------UNICAES------------------
    //---Facultad de Ingenería y Arquitectura---
    //--INGENIERÍA EN DESARROLLO DE SOFTWARE--
    //-Última fecha de modificación: 19.11.19
    //-------Luis Adrián Alfonzo Morán-------
    class Ejercicio4Guia10
    {
        static void Main(string[] args)
        {
            StreamReader file = new StreamReader("./Password.txt");
            string password = file.ReadLine();
            int counter = 3;
            string pass;
            do
            {
                Console.Clear();
                Console.WriteLine("¿Cuál es la contraseña?");
                Console.WriteLine("Intentos faltantes: " + counter);
                pass = Console.ReadLine();
                pass = pass.Replace("a", "§$%&)=?");
                pass = pass.Replace("e", "©«»¤¼×");
                pass = pass.Replace("i", "8GWs");
                pass = pass.Replace("o", "1~mg");
                pass = pass.Replace("u", "%|P%");
                //Console.WriteLine(contraseña);
                //Console.WriteLine(contra);
                counter--;
            } while (pass != password && counter > 0);
            Console.Clear();
            file.Close();
            if (counter == 0)
            {
                Console.WriteLine("Se ha bloqueado la dirección IP, si quiere volver a intentar, reinicie el Router");
            }
            else
            {
                Console.WriteLine("Bienvenido al sistema");
            }
            Console.ReadKey();
        }
    }
}
