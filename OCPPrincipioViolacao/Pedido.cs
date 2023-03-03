using System;
using OCPPrincipioViolacao.Enum;

namespace OCPPrincipioViolacao
{
	public class Pedido
	{
        public double DescontoPedido(double valor, TipoClienteEnum tipoCliente)
        {
            double valorFinal;

            if (tipoCliente == TipoClienteEnum.Especial)
            {
                valorFinal = valor - 50;
            }
            else if (tipoCliente == TipoClienteEnum.Associado)
            {
                valorFinal = valor - 10;
            }
            else
            {
                valorFinal = valor;
            }
            return valorFinal;
        }
    }
}

