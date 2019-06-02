namespace ChainOfResponsibility.Requisicao
{
    public static class DeterminadorDeResposta
    {
        public static void Executa(Requisicao req, Conta conta)
        {
            IResposta r1 = new RespostaEmXml(
                            new RespostaEmCsv(
                            new RespostaEmPorcentagem()));
            r1.Responde(req, conta);
        }
    }
}