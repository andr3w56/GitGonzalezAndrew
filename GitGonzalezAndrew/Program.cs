using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitGonzalezAndrew
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            /*
             * 
             * Datos Informativos
             * 
             */
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("# Datos Informativos\n");

            const string apellidos = "González Castillo";
            const string nombres = "Andrew Fernando";
            const string curso = "Segundo TICS";
            const string asignatura = "Programación Estructurada";
            const string fecha = "11/11/2022";
            const string tema = "Operadores";

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Apellidos: {apellidos}");
            Console.WriteLine($"Nombres: {nombres}");
            Console.WriteLine($"Curso: {curso}");
            Console.WriteLine($"Asignatura: {asignatura}");
            Console.WriteLine($"Fecha: {fecha}");
            Console.WriteLine($"Tema: {tema}");
            /*
             * 
             * Dias de la semana.
             * 
             */
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n# Número Aleatorio");

            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            var aleatorio = rnd.Next(1, 8);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\nEl número aleatorio es: {aleatorio}");

            string[] diasSemanales = {"Lunes", "Martes", "Miércoles", "Jueves",
                "Viernes", "Sábado", "Domingo"};

            for (int i = 0; i <= 7; i++)
            {
                if (aleatorio == i)
                {
                    Console.WriteLine(diasSemanales[i - 1]);
                }
            }
            /*
             * 
             * Operador NOT
             * 
             */
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n# Operador NOT");

            aleatorio = new Random().Next(1, 101);

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"\nEl número aleatorio es: {aleatorio}");

            if (!(aleatorio >= 18 && aleatorio <= 50))
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("Esta población NO es económicamente activa.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Esta población es trabajadora.");
            }

            Console.ReadKey();
        }
    }
}
