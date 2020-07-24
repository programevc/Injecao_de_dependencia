using System;
using System.Collections.Generic;
using System.Text;

namespace InjecaoDeDependância.Otimo
{
    public class EnviarEmail : IEnviarEmail
    {
        public bool Enviar(string email, string conteudo)
        {
            //=funcoes de envio

            return true;
        }
    }
}
