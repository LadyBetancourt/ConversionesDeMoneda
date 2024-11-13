﻿using System.Threading.Channels;

namespace ConversionesDeMoneda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
            MostrarMenu();

                string respuestaUsuario = Console.ReadLine();

                switch (respuestaUsuario)
                {
                    case "1":
                        ConvertirPesosADolares();
                        break;
                    case "2":
                        Console.WriteLine("Dolares a pesos");
                        break;
                    default:
                        Console.WriteLine("Opción incorrecta");
                        break;
            }
                Console.ReadKey();  

        }

            //decimal conversion = PesosADolares(20.43m, 50000m);
            //Console.WriteLine(conversion.ToString("N2"));
        }

        static void MostrarMenu()
        {
            Console.Clear();
            Console.WriteLine("Conversiones");
            Console.WriteLine("1) Pesos a Dolares");
            Console.WriteLine("2) Dolares a pesos");
            Console.WriteLine("");
        }
        static void ConvertirPesosADolares() 
        {
            Console.WriteLine("Pesos a Dolares");
            Console.WriteLine("Introducir tipo de cambio");

            string respuestaUsuario = Console.ReadLine();
            decimal.TryParse(respuestaUsuario, out decimal tipoDeCambio);


            Console.WriteLine("Introduir la cantidad en pesos");
            respuestaUsuario = Console.ReadLine();
            decimal.TryParse(respuestaUsuario, out decimal pesos);

            decimal dolares = PesosADolares(tipoDeCambio, pesos);
            Console.WriteLine($"Cantidad en Dolares:{dolares}");
        }
        static decimal PesosADolares(decimal tipoCambio, decimal pesos)
        {
            decimal dolares = 0.00m;
            dolares = pesos / tipoCambio;
            return dolares;
        }
    }
}
