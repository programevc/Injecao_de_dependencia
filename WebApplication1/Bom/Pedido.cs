namespace InjecaoDeDependância.Bom
{
    public class Pedido
    {
        private EnviarEmail _email;
        public Pedido(EnviarEmail email)
        {
            _email = email;
        }
        public void CriarPedido(PedidoModel pedidoModel)
        {
            //Validações
            //Gravar

            _email.Enviar(pedidoModel.ClienteEmail, $"Seu pedido {pedidoModel.Numero} foi gerado com sucesso");
        }
    }
}
