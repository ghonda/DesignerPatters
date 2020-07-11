using System;

namespace Bridge.ExemploPratico
{
    public class SmartTv
    {
        public ICanal CanalAtual { get; set; }

        public void ExibeCanalSintonizado()
        {
            if (CanalAtual != null)
                Console.WriteLine(CanalAtual.Canal());
            else
                Console.WriteLine("Por favor, seleione um canal");

        }

        public void PlayTv()
        {
            if (CanalAtual != null)
                Console.WriteLine(CanalAtual.Status());
            else
                Console.WriteLine("Por favor, seleione um canal para assistir");

        }
    }
}
