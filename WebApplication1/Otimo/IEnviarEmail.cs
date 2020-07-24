namespace InjecaoDeDependância.Otimo
{
    public interface IEnviarEmail
    {
        bool Enviar(string email, string conteudo);
    }
}
