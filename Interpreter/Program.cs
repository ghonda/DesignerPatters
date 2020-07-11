using System;
using System.Collections.Generic;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            string romano = "MCMXXVIII";
            Contexto contexto = new Contexto(romano);

            List<Expressao> lista = new List<Expressao>
            {
                new MilharesExpressao(),
                new CentenasExpressao(),
                new DezenasExpressao(),
                new UnidadeExpressao()
            };

            foreach (var exp in lista)
            {
                exp.Interpretador(contexto);
            }

            Console.WriteLine($"{romano} = {contexto.Output}");
        }
    }
}
