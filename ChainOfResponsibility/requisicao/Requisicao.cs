namespace ChainOfResponsibility.Requisicao
{
    public class Requisicao
    {
        public Requisicao(Formato formato)
        {
            Formato = formato;
        }

        public Formato Formato { get; }
    }
}