using System;
using System.IO;

namespace DIEZ
{
    //------------------UNICAES------------------
    //---Facultad de Ingenería y Arquitectura---
    //--INGENIERÍA EN DESARROLLO DE SOFTWARE--
    //-Última fecha de modificación: 04.11.19
    //-------Luis Adrián Alfonzo Morán-------
    class Ejercicio1Guia10
    {
        static void Main(string[] args)
        {
            Menu();
            Console.ReadKey();
        }
        static void Menu()
        {
            int opt;
            Console.WriteLine("Opción [1]: Agregar país");
            Console.WriteLine("Opción [2]: Mostrar países");
            Console.WriteLine("Opción [3]: Buscar país");
            Console.WriteLine("Opción [4]: Salir");
            Console.WriteLine();
            opt = Convert.ToInt32(Console.ReadLine());
            switch (opt)
            {
                case 1:
                    Console.Clear();
                    AddCountry();
                    break;
                case 2:
                    ShowCountry();
                    Menu();
                    break;
                case 3:
                    FindCountry();
                    break;
                case 4:
                    Exit();
                    break;
                default:
                    Exit();
                    break;
            }
        }
        static void AddCountry()
        {
            //Proceso en TRY-CATCH
            try
            {
                Console.WriteLine("¿Cuál es el país que agregará? (Escriba uno y si desea escribir otro solo presione [ENTER])");
                StreamWriter xd = new StreamWriter("./agregarPais.txt", false);
                string keepgoing = "";
                //Proceso en DO-WHILE
                do
                {
                    Console.Clear();
                    Console.WriteLine("¿Cuál es el nombre del país a agregar?");
                    string nameCountry = Console.ReadLine();
                    xd.WriteLine(nameCountry);
                    Console.WriteLine("===========================================");
                    Console.WriteLine("¿Desea agregar otro país a la lista? si/no");
                    keepgoing = Console.ReadLine();
                } while (keepgoing == "si");
                xd.Close();
                Console.WriteLine();
                Console.WriteLine("Los países han sido agregados exitosamente...");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

                Console.WriteLine("Un error ha ocurrido en el proceso...");
            }
            Console.Clear();
            Menu();
        }
        static void ShowCountry()
        {
            //Base
            //Proceso en FOREACH
            StreamReader xd2 = new StreamReader("./agregarPais.txt");
            Console.WriteLine(xd2.ReadToEnd());
            xd2.Close();
            Console.ReadKey();
            Console.Clear();
        }
        static void FindCountry()
        {
            StreamReader xd3 = new StreamReader("./agregarPais.txt");
            Console.Clear();
            //Consulta
            Console.WriteLine("¿Qué país desea buscar en la lista?");
            //Base
            string find = Console.ReadLine();
            string line = xd3.ReadLine();
            Console.WriteLine(xd3.ReadToEnd());
            while (line != null)
            {
                while (line == find)
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine(find);
                }
                line = xd3.ReadLine();
            }
            xd3.Close();
            Console.ResetColor();
            Menu();
        }
        static void Exit()
        {
            Console.WriteLine("Presione [ENTER] para salir");
            Environment.Exit(0);
        }
    }
}
