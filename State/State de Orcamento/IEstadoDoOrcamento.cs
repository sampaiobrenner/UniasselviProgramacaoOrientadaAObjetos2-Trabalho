namespace State.State_de_Orcamento
{
    public interface IEstadoDoOrcamento
    {
        void AplicaDescontoExtra(Orcamento orcamento);

        void Aprova(Orcamento orcamento);

        void Finaliza(Orcamento orcamento);

        void Reprova(Orcamento orcamento);
    }
}