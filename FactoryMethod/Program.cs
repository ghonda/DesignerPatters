using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var fm = new FactoryMethod();
            Console.WriteLine("Liu Kang | Sub Zero | Scorpion");
            Console.WriteLine();

            Console.WriteLine("Escolha seu personagem");
            string escolha = Console.ReadLine();

            IPersonagem personagem = fm.EscolherPersonagem(escolha);

            if (personagem != null)
            {
                Console.WriteLine();
                Console.WriteLine("Você vai jogar com:");
                personagem.Escolhido();
            }
            else
            {
                Console.WriteLine("Personagem indisponivel");
            }
            Console.ReadKey();
        }
    }
}
