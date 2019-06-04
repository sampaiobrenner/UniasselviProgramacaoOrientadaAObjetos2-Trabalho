namespace State.Conta
{
    public interface IEstadoDeConta
    {
        void Deposita(Conta conta, double valor);

        void Saca(Conta conta, double valor);
    }
}