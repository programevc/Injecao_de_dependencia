using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InjecaoDeDependância;
using InjecaoDeDependância.Otimo;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PedidoController : ControllerBase
    {
        private IPedido _pedido;
        public PedidoController(IPedido pedido)
        {
            _pedido = pedido;
        }

        [HttpGet]
        public ActionResult Get()
        {
            var pedido = new PedidoModel()
            {
                ClienteEmail = "programevc@gmail.com",
                Itens = new List<string>() { "item_01", "item_02" },
                Valor = 100
            };

            _pedido.CriarPedido(pedido);

            return Ok(pedido);
        }
    }
}
