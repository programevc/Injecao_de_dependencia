using System;
using System.Collections.Generic;
using System.Text;

namespace InjecaoDeDependância.Otimo
{
    public class Pedido : IPedido
    {
        private IEnviarEmail _enviarEmail;

        public Pedido(IEnviarEmail enviarEmail)
        {
            _enviarEmail = enviarEmail;
        }

        public PedidoModel CriarPedido(PedidoModel pedidoModel)
        {
            //regras de pedido e gravaçao
            pedidoModel.Numero = 5;

            _enviarEmail.Enviar(pedidoModel.ClienteEmail, $"Seu pedido foi gerado com sucesso");

            return pedidoModel;
        }
    }
}
