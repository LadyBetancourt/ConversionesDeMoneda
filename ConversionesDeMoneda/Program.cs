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
                    case "3":
                        ConvertirPesosAEuros();
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
            Console.WriteLine("3) Pesos a Euros");
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
        static void ConvertirPesosAEuros()
        {
            Console.WriteLine("Pesos a Euros");
            Console.WriteLine("Introducir tipo de cambio");

            string respuestaUsuario = Console.ReadLine();
            decimal.TryParse(respuestaUsuario, out decimal tipoCambio);

            Console.WriteLine("Introducir la cantidad en pesos");
            respuestaUsuario = Console.ReadLine();
            decimal.TryParse(respuestaUsuario, out decimal pesos);

            decimal Euros = PesosAEuros(tipoCambio, pesos);
            Console.WriteLine($"Cantidad en Euros: {Euros.ToString("N2")}");
        }
        static void ConvertirEurosAPesos()
        {
            Console.WriteLine("Euros a pesos");
            Console.WriteLine("Introducir tipo de cambio");

            string respuestaUsuario = Console.ReadLine();
            decimal.TryParse(respuestaUsuario, out decimal tipoCambio);

            Console.WriteLine("Introducir la cantidad en euros");
            respuestaUsuario= Console.ReadLine();

            decimal.TryParse(respuestaUsuario, out decimal euros);

            decimal pesos = EurosAPesos(tipoCambio, euros);
            Console.WriteLine($"La cantidad en pesos es: {pesos.ToString("N2")}");
        }
        static decimal PesosAEuros(decimal tipoCambio, decimal pesos) 
        {
            decimal euros = 0.00m;
            euros = pesos / tipoCambio;
            return euros;
        }
        static decimal EurosAPesos(decimal tipoCambio, decimal euros) 
        {
            decimal pesos = 0.00m;
            pesos = euros / tipoCambio;
            return pesos;
        }
    }
}
