using System;
namespace Importer
{
	public class PecaModel
	{
		public int ID { get; set; }
		public string codigo { get; set; }
		public string descricao { get; set; }
		public double preco_bruto { get; set; }
		public int qtd { get; set; }
		public string barras { get; set; }
		public double peso_liq { get; set; }
		public string unidade { get; set; }
		public string ncm { get; set; }
		public double desconto { get; set; }
		public string mic { get; set; }
	}
}

