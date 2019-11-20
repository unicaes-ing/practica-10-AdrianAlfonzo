using System;
using System.IO;

namespace DIEZ
{
    class Ejercicio3Guia10
    {
        //------------------UNICAES------------------
        //---Facultad de Ingenería y Arquitectura---
        //--INGENIERÍA EN DESARROLLO DE SOFTWARE--
        //-Última fecha de modificación: 04.11.19
        //-------Luis Adrián Alfonzo Morán-------
        static void Main(string[] args)
        {
            string name;
            int answer;
            string passworddelMain;
            Console.WriteLine("Identifíquese, ¿cuál es su nombre?");
            name = Console.ReadLine();
            Console.WriteLine();
            Console.Clear();
            Console.WriteLine("¿'Ejercicio 3' o 'Ejercicio 4'?");
            answer = Convert.ToInt32(Console.ReadLine());
            switch (answer)
            {
                case 3:
                    Console.Write("Para entrar al sistema debe ingresar la contraseña: ");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    passworddelMain = Console.ReadLine();
                    PasswordFunction(passworddelMain);
                    Console.ResetColor();
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Bienvenido a la MATRIX, {0}.", name);
                    Console.ResetColor();
                    Console.ReadKey();
                    break;
                case 4:
                    Console.Write("Para entrar al sistema debe ingresar la contraseña: ");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    passworddelMain = Console.ReadLine();
                    Password(passworddelMain);
                    Console.ResetColor();
                    Console.ReadKey();
                    break;
                default:
                    break;
            }
        }
        static void PasswordFunction(string password)
        {
            string answer = password.Replace(password, "M4QU1N4_DE_GUERR4_ES_L4_OND4");
            Stream filestreamxd = new FileStream("./Password.txt", FileMode.Create, FileAccess.ReadWrite);
            StreamWriter streamwriterxd = new StreamWriter(filestreamxd);
            streamwriterxd.WriteLine(answer);
            streamwriterxd.Close();
            StreamReader streamreaderxd = new StreamReader("./Password.txt");
            Console.WriteLine(streamreaderxd.ReadLine());
            filestreamxd.Close();
            streamreaderxd.Close();
        }
        static void Password(string password)
        {
            string pa55w0rd = "M4QU1N4_DE_GUERR4_ES_L4_OND4";
            for (int i = 3; i > 0; i--)
            {
                Console.WriteLine("Aún tienes estos intentos: " + i);
                Console.Write("¿Cuál es la contraseña? ");
                pa55w0rd = Console.ReadLine();
                if (pa55w0rd == password)
                {
                    Console.WriteLine("Bienvenido");
                    i = 1;
                }
                else
                {
                    Console.WriteLine("siga intentando");
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
