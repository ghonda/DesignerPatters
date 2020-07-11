using System;

namespace Flyweight
{
    class Program
    {
        private static string cor;

        static void Main(string[] args)
        {
            var fabrica = new FabricaFlyweight();
            Tartaruga tartaruga;

            while (true)
            {
                Console.WriteLine("Qual tartaruga enviar para tela: ");
                cor = Console.ReadLine();
                tartaruga = fabrica.GetTartaruga(cor);
                tartaruga.Mostra(cor);

                Console.WriteLine();
                Console.WriteLine("--------------------");
            }
        }
    }
}
