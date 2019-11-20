using System;
using System.IO;

namespace DIEZ
{
    //------------------UNICAES------------------
    //---Facultad de Ingenería y Arquitectura---
    //--INGENIERÍA EN DESARROLLO DE SOFTWARE--
    //-Última fecha de modificación: 22.10.19
    //-------Luis Adrián Alfonzo Morán-------
    class Program
    {
        //Base
        public static string name;
        public static string DUI;
        public static string NIT;
        public static string mail;
        public static int phone;
        public static decimal money;
        //Main
        static void Main(string[] args)
        {
            //Consulta
            Console.WriteLine("¿Cuál es su nombre?");
            name = Console.ReadLine();
            Console.WriteLine("¿Cuál es el número de su Documento Único de Identidad?");
            DUI = Console.ReadLine();
            Console.WriteLine("¿Cuál es su Número de Identificación Tributario?");
            NIT = Console.ReadLine();
            Console.WriteLine("¿Cuál es su correo electrónico?");
            mail = Console.ReadLine();
            Console.WriteLine("¿Cuál es teléfono?");
            phone = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("¿Cuánto gana mensualmente?");
            money = Convert.ToDecimal(Console.ReadLine());
            Stream();
        }
        //Función para creación de archivo de texto
        static void Stream()
        {
            //Todo el texto a mostrar
            StreamWriter file = new StreamWriter(@"C:\minifiles\empleado.txt", false);
            file.WriteLine("Su nombre es: {0}", name);
            file.WriteLine("========================================================");
            file.WriteLine("Su DUI es: {0}", DUI);
            file.WriteLine("========================================================");
            file.WriteLine("Su NIT es: {0}", NIT);
            file.WriteLine("========================================================");
            file.WriteLine("Su correo electrónico es: {0}", mail);
            file.WriteLine("========================================================");
            file.WriteLine("Su número de teléfono es: {0}", phone);
            file.WriteLine("========================================================");
            file.WriteLine("Su salario mensual es de: ${0}", money);
            //Cierre
            file.Close();
            //Salida
            Console.WriteLine("Presione [ENTER] para salir pues su archivo ha sido guardado exitosamente...");
            Console.ReadKey();
        }
    }
}
