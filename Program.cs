using System;
using BancoCliente.BancoService;

namespace BancoCliente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Instanciamos el objeto 'proxy' para comunicarnos con el servidor
            BancoService.BancoServiceSoapClient servidor = new BancoService.BancoServiceSoapClient();

            Console.WriteLine("--- CONSULTA DE SALDO BANCO ---");

            // 2. Capturamos los datos del usuario
            Console.Write("Número de Cuenta: ");
            string nro = Console.ReadLine();

            Console.Write("Tipo (Ahorros/Corriente): ");
            string tipo = Console.ReadLine();

            Console.Write("Monto de la compra: ");
            decimal monto = decimal.Parse(Console.ReadLine());

            try
            {
                // 3. Llamamos al método que está en el servidor
                bool resultado = servidor.VerificarSaldoParaCompra(nro, tipo, monto);

                // 4. Mostramos respuesta
                if (resultado)
                {
                    Console.WriteLine("RESULTADO: Compra Autorizada.");
                }
                else
                {
                    Console.WriteLine("RESULTADO: Fondos insuficientes o datos erróneos.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error de conexión: " + ex.Message);
            }

            Console.WriteLine("Presione Enter para salir...");
            Console.ReadLine();
        }
    }
}