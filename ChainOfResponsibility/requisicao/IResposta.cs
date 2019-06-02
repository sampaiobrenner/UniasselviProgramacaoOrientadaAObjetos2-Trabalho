namespace ChainOfResponsibility.Requisicao
{
    public interface IResposta
    {
        IResposta Proximo { get; set; }

        void Responde(Requisicao requisicao, Conta conta);
    }
}