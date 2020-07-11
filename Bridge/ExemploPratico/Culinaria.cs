namespace Bridge.ExemploPratico
{
    public class Culinaria : ICanal
    {
        public string Canal()
        {
            return "Sintonizado no: Canal de Culinaria";

        }

        public string Status()
        {
            return $"Você está assistindo Receita de bolo de laranja";

        }
    }
}
