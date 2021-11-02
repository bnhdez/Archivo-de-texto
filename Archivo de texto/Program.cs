using System;
using System.IO;

namespace ej
{
    class Program
    {
        static void Main(string[] args)
        {
            string id;
            using (var FileStream = new FileStream("C:/Users/boris/Desktop/UNIVERSIDAD/CICLO 2/PROGRAMACION ESTRUCTURADA/Filestream/Archivo de texto/Archivo de texto/archivo.txt", FileMode.CreateNew, FileAccess.Write))
            {
                using (var StreamWriter = new StreamWriter(FileStream))
                {
                    int i = 1;
                    while (i <= 3)
                    {
                        Console.WriteLine("Ingrese sus datos 'id,nombre,apellido y nota'");
                        id = Console.ReadLine();

                        StreamWriter.WriteLine(id);
                        i = i + 1;
                    }
                }
            }
        }
    }
}


