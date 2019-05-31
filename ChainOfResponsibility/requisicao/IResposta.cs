namespace ChainOfResponsibility
{
    public interface IResposta
    {
        IResposta Proximo { get; set; }

        void Responde(Requisicao requisicao, Conta conta);
    }
}