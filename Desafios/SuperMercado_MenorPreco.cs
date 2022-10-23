using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios
{
    public class SuperMercado_MenorPreco
    {
        // nome, fabricante, código de barras, valor unitário, valor de compra e quantidade em estoque
        public string nome_produto { get; set; }
        public string fabricante { get; set; }
        public int codigo { get; set; }
        public double valor_unitario { get; set; }
        public double valor_compra { get; set; }
        public int quantidade_estoque { get; set; }
    }
}
