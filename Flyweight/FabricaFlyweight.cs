using System.Collections.Generic;

namespace Flyweight
{
    public class FabricaFlyweight
    {
        private Dictionary<string, Tartaruga> listaDeTartarugas = new Dictionary<string, Tartaruga>();

        public Tartaruga GetTartaruga(string cor)
        {

            if (listaDeTartarugas.ContainsKey(cor))
                return listaDeTartarugas[cor];
            else
            {
                Tartaruga t = null;
                switch (cor)
                {
                    case "azul": t = new Azul(); break;
                    case "verde": t = new Verde(); break;
                    case "vermelha": t = new Vermelha(); break;
                    case "laranja": t = new Laranja(); break;
                }
                listaDeTartarugas.Add(cor, t);
                return t;
            }
        }
    }


}
