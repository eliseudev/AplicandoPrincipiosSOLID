using System;

namespace SRPViolacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Pedido pedido = new Pedido();
            pedido.IncluirPedido();

            Console.ReadLine();
        }
    }
}

