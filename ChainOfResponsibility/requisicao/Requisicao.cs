namespace ChainOfResponsibility
{
    public class Requisicao
    {
        public Requisicao(Formato formato)
        {
            this.Formato = formato;
        }

        public Formato Formato { get; set; }
    }
}