using System;
using System.IO;

namespace DIEZ
{
    //------------------UNICAES------------------
    //---Facultad de Ingenería y Arquitectura---
    //--INGENIERÍA EN DESARROLLO DE SOFTWARE--
    //-Última fecha de modificación: 06.11.19
    //-------Luis Adrián Alfonzo Morán-------
    class Lab2
    {
        static void Main(string[] args)
        {
            Menu();
            Console.ReadKey();
        }
        static void Menu()
        {
            //Base
            int opt;
            Console.WriteLine("Opción [1]: Agregar producto");
            Console.WriteLine("Opción [2]: Mostrar productos");
            Console.WriteLine("Opción [3]: Salir");
            Console.WriteLine();
            opt = Convert.ToInt32(Console.ReadLine());
            //Proceso en SWITCH
            switch (opt)
            {
                case 1:
                    Console.Clear();
                    AddProducto();
                    Menu();
                    break;
                case 2:
                    Console.Clear();
                    ShowProducto();
                    Menu();
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
            }
        }
        static void AddProducto()
        {
            //Proceso en TRY-CATCH
            try
            {
                Console.WriteLine("¿Cuál es el CÓDIGO del producto?");
                int code = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("¿Cuál es el NOMBRE del producto?");
                string pro = Console.ReadLine();
                Console.WriteLine("¿Cuál es el PRECIO del producto?");
                decimal price = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("¿Hay {0} en STOCK?", pro);
                bool simon = false;
                FileStream info = new FileStream("producto.dat", FileMode.OpenOrCreate, FileAccess.Write);
                BinaryWriter infoBinario = new BinaryWriter(info);
                infoBinario.Write(code);
                infoBinario.Write(pro);
                infoBinario.Write(price);
                infoBinario.Write(simon);
                info.Close();
                infoBinario.Close();
                Console.WriteLine();
                Console.WriteLine("El producto fue almacenado satifactoriamente...");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

                Console.WriteLine("Un error ha ocurrido en el proceso...");
            }
            Console.Clear();
            Menu();
        }
        static void ShowProducto()
        {
            try
            {
                FileStream binario = new FileStream("info.bin", FileMode.OpenOrCreate, FileAccess.Read);
                BinaryReader binarioLeer = new BinaryReader(binario);
                do
                {
                    int code = binarioLeer.ReadInt32();
                    string pro = binarioLeer.ReadString();
                    decimal price = binarioLeer.ReadDecimal();
                    bool simon = binarioLeer.ReadBoolean();
                    binario.Close();
                    binarioLeer.Close();
                    Console.WriteLine("Datos del producto:");
                    Console.WriteLine();
                    Console.WriteLine("Código: {0}", code);
                    Console.WriteLine("Producto: {0}", pro);
                    Console.WriteLine("Precio: {0}", price);
                    Console.WriteLine("Stock: {0}", simon);
                    Console.WriteLine("Presione [ENTER] para salir");
                    Console.ReadKey();
                } while (true);
            }
            catch (Exception)
            {
                Console.WriteLine("Un error ha ocurrido en el proceso...");
            }
        }
    }
}