namespace Bridge.ExemploPratico
{
    public class Filme : ICanal
    {
        public string Canal()
        {
            return "Sintonizado no: Canal de Filmes";
        }

        public string Status()
        {
            return $"Você está assistindo os Vingadores";

        }
    }
}
