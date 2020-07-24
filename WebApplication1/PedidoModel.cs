using System;
using System.Collections.Generic;
using System.Text;

namespace InjecaoDeDependância
{
    public class PedidoModel
    {
        public int Numero { get; set; }
        public decimal Valor { get; set; }
        public string ClienteEmail { get; set; }
        public List<string> Itens { get; set; }
    }
}
