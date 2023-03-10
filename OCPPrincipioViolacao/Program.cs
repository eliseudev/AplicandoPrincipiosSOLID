using System;
using OCPPrincipioViolacao.Enum;

namespace OCPPrincipioViolacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Pedido pedido1 = new Pedido();

            var valorPedidoClienteComun =
               pedido1.DescontoPedido(1000, TipoClienteEnum.Comum);

            var valorPedidoClienteAssociado =
                pedido1.DescontoPedido(1000, TipoClienteEnum.Associado);

            var valorPedidoClienteEspecial =
                pedido1.DescontoPedido(1000, TipoClienteEnum.Especial);

            Console.WriteLine("Principio OCP - Violação");

            Console.WriteLine($"Cliente Comum = " +
                $"{valorPedidoClienteComun}");

            Console.WriteLine($"Cliente Associado = " +
                $"{valorPedidoClienteAssociado}");

            Console.WriteLine($"Cliente Especial = " +
                $" {valorPedidoClienteEspecial}");

            Console.ReadLine();
        }
    }
}

