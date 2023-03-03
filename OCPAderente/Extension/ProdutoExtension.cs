using System;
namespace OCPAderente.Extension
{
	public static class ProdutoExtension
	{
		public static double MargemLucro(this Produto produto)
		{
			try
			{
                var lucroLiquido = produto.Venda - produto.Custo;
                var margemLucro = (lucroLiquido / produto.Venda) * 100;
                return Convert.ToDouble(margemLucro);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Erro ao calcular a mergem de lucro");
            }
        }
	}
}

