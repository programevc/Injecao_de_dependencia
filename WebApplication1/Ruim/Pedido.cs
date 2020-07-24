namespace InjecaoDeDependância.Ruim
{
    public class Pedido
    {
        public void CriarPedido(PedidoModel pedidoModel)
        {
            //Validações
            //Gravar

            var email = new EnviarEmail();
            email.Enviar(pedidoModel.ClienteEmail, $"Seu pedido {pedidoModel.Numero} foi gerado com sucesso");
        }
    }
}
