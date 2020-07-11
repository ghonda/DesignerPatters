namespace Bridge.ExemploPratico
{
    public class Documenario : ICanal
    {
        public string Canal()
        {
            return "Sintonizado no: Canal de Documentários";

        }

        public string Status()
        {
            return $"Você está assistindo a Origem de Tudo";

        }
    }
}
