namespace ConversionesDeMoneda
{
    internal class Program
    {

        //Este es el metodo principal
        static void Main(string[] args)
        {

            //Creamos un ciclo infinito
            while (true)
            {

                //Llamamos al metodo MostrarMenu
                MostrarMenu();

                string respuestaUsuario = Console.ReadLine();

                switch (respuestaUsuario)
                {
                    case "1":
                        ConvertirPesosADolares();
                        break;
                    case "2":
                        ConvertirDolaresAPesos();
                        break;
                    default:
                        Console.WriteLine("Opción incorrecta");
                        break;
                }
                Console.ReadKey();

            }
        }

        //Este es un metodo que me imprime las opciones para el usuario
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
            Console.WriteLine($"Cantidad en Dolares:{dolares.ToString("N2")}");
        }
        static void ConvertirDolaresAPesos()
        {
            Console.WriteLine("Dolares a pesos");
            Console.WriteLine("Introducir tipo de cambio");

            string respuestaUsuario = Console.ReadLine();
            decimal.TryParse(respuestaUsuario, out decimal tipoCambio);

            Console.WriteLine("Introducir la cantidad en dolares");
            respuestaUsuario = Console.ReadLine();

            decimal.TryParse(respuestaUsuario, out decimal dolares);

            decimal pesos = DolaresAPesos(tipoCambio, dolares);
            Console.WriteLine($"La cantidad en pesos es: {pesos.ToString("N2")}");
        }
        static decimal PesosADolares(decimal tipoCambio, decimal pesos)
        {
            decimal dolares = 0.00m;
            dolares = pesos / tipoCambio;
            return dolares;
        }

        static decimal DolaresAPesos(decimal tipoCambio, decimal dolares)
        {
            decimal pesos = 0.00m;
            pesos = tipoCambio * dolares;
            return pesos;
        }
    }
}
