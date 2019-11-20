using System;
using System.Text;
using System.IO;

namespace DIEZ
{
    //------------------UNICAES------------------
    //---Facultad de Ingenería y Arquitectura---
    //--INGENIERÍA EN DESARROLLO DE SOFTWARE--
    //-Última fecha de modificación: 06.11.19
    //-------Luis Adrián Alfonzo Morán-------
    class Lab
    {
        static void Main(string[] args)
        {
            Menu();
            CapturarName();
            Console.ReadKey();
        }
        static void Menu()
        {
            //Base
            int opt;
            Console.WriteLine("Opción [1]: Agregar nombre");
            Console.WriteLine("Opción [2]: Mostrar nombres");
            Console.WriteLine("Opción [3]: Salir");
            Console.WriteLine();
            opt = Convert.ToInt32(Console.ReadLine());
            //Proceso en SWITCH
            switch (opt)
            {
                case 1:
                    Console.Clear();
                    CapturarName();
                    Menu();
                    break;
                case 2:
                    Console.Clear();
                    MostrarName();
                    Menu();
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
            }
        }
        static void CapturarName()
        {
            //Proceso en TRY-CATCH
            try
            {
                Console.WriteLine("Lista de nombres");
                StreamWriter file = new StreamWriter("./nombres.txt", true, Encoding.ASCII, 60);
                string keepgoing = "";
                //Proceso en DO-WHILE
                do
                {
                    Console.Clear();
                    Console.WriteLine("¿Cuál es su nombre?");
                    string name = Console.ReadLine();
                    file.WriteLine(name);
                    Console.WriteLine("===========================================");
                    Console.WriteLine("¿Desea agregar otro nombre a la lista? si/no");
                    keepgoing = Console.ReadLine();
                } while (keepgoing == "si");
                file.Close();
                Console.WriteLine();
                Console.WriteLine("La información se guardó exitosamente...");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

                Console.WriteLine("Un error ha ocurrido en el proceso...");
            }
            Console.Clear();
            Menu();
        }
        static void MostrarName()
        {
            StreamReader file2 = new StreamReader("./nombres.txt");
            Console.WriteLine(file2.ReadToEnd());
            file2.Close();
            Console.ReadKey();
            Console.Clear();
        }
    }
}
