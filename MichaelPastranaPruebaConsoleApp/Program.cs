using System;
using System.Threading;

namespace MichaelPastranaPruebaConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Thread edificio1 = new Thread(CalcularPersonas);
            Thread edificio2 = new Thread(CalcularPersonas);

            Console.WriteLine("Buenas, aquí ejecuto el edificio1");
            edificio1.Start();

            Console.WriteLine("Buenas, aquí ejecuto el edificio2");
            edificio1.Start();

            Thread.Sleep(1000);

            Console.WriteLine("el edificio1 se une");
            edificio1.Join();
            Console.WriteLine("el edificio2 se une");
            edificio2.Join();
        }

        static void CalcularPersonas()
        {

            var edificioReciente = Thread.CurrentThread;

            Console.WriteLine("Edificio reciente {0}: ", edificioReciente.ManagedThreadId);


            int resultado = 0;
            for (int i = 1; i <= 96; i++)
            {
                var gente = new Random().Next(1, 6);
                Console.WriteLine("Hilo {0} Habitacion {1} Gente {2}", edificioReciente.ManagedThreadId, i, gente);
                resultado += gente;

                Thread.Sleep(300);
                Console.WriteLine("Cifra de personas en el edificio: " + resultado);
            }
            

        }
    }
}
