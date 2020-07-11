using System;

namespace Flyweight
{
    public class Verde : Tartaruga
    {
        public Verde()
        {
            condicao = "tartaruga dentro do casco, ";
            acao = "rodando no chao - ";

        }
        public override void Mostra(string qualCor)
        {
            Cor = qualCor;
            Console.WriteLine(condicao + acao + Cor.ToUpper());
        }
    }


}
