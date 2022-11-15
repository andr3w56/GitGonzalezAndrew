using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

            Random rnd = new Random(Environment.TickCount);
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
            /*
             * 
             * 2 Numeros aleatorios.
             * 
                 */
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n# Múltiples Numeros Aleatorios");

            Console.ForegroundColor = ConsoleColor.DarkRed;
            aleatorio = new Random(Environment.TickCount).Next(1, 7); // Utilizamos una seed para que no se repitan.
            var a1 = aleatorio; // Guardamos el número aleatorio 1 en una variable.
            Console.WriteLine($"\nPrimer número aleatorio: {aleatorio}\n");

            aleatorio = new Random(Environment.TickCount).Next(1, 7);
            var a2 = aleatorio; // Guardamos el número aleatorio 2 en otra variable.
            Console.WriteLine($"Segundo número aleatorio: {aleatorio}\n");

            Console.WriteLine($"Su suma es: {a1 + a2}\n");

            Console.ForegroundColor = ConsoleColor.Yellow;
            if (a1 + a2 < 4 || a1 + a2 == 12)
            {
                Console.WriteLine("Ganaste el premio sorpresa de la trivia");
            }
            else
            {
                Console.WriteLine("Sigue intentando");
            }

            Console.ReadKey();
        }
    }
}
