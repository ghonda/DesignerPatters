using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var c1 = ExecutaAbstractFactory.MontarCarro(Tipo.Luxo);
            var c2 = ExecutaAbstractFactory.MontarCarro(Tipo.Popular);

            Console.ReadKey();
        }
    }
}
