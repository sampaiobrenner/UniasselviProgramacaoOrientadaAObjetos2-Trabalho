namespace ChainOfResponsibility
{
    public class DeterminadorDeResposta
    {
        public void executa(Requisicao req, Conta conta)
        {
            IResposta r1 = new RespostaEmXml(
                            new RespostaEmCsv(
                            new RespostaEmPorcentagem()));
            r1.Responde(req, conta);
        }
    }
}