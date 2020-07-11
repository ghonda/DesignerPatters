using System;

namespace Flyweight
{
    public class Laranja : Tartaruga
    {
        public Laranja()
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
