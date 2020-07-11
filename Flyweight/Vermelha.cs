using System;

namespace Flyweight
{
    public class Vermelha : Tartaruga
    {
        public Vermelha()
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
