using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton jogador_1 = Singleton.GetInstancia;
            jogador_1.Mensagem("Bola está comigo");

            Singleton jogador_2 = Singleton.GetInstancia;
            jogador_2.Mensagem("Recebeu a bola");

            Singleton jogador_3 = Singleton.GetInstancia;
            jogador_3.Mensagem("Chutou a bola");

            Console.ReadKey();
        }
    }
}
