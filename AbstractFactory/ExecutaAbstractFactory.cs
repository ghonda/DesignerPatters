namespace AbstractFactory
{
    public class ExecutaAbstractFactory
    {
        public static Carro MontarCarro(Tipo tipo)
        {
            CarroFactory cf = null;

            switch (tipo)
            {
                case Tipo.Popular:
                    cf = new CarroPopularFactory();
                    break;
                case Tipo.Luxo:
                    cf = new CarroLuxoFactory();
                    break;
                default:
                    break;
            }

            var carro = new Carro
            {
                Roda = cf.MontarRoda(),
                Som = cf.MontarSom()
            };

            return carro;
        }
    }
}
