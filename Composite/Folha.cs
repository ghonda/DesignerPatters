using System;

namespace Composite
{
    partial class Program
    {
        public class Folha : Componente
        {
            public Folha(string nome) : base(nome)
            {
            }

            public override void Adicionar(Componente c)
            {
                Console.WriteLine("Não foi possível adicionar a folha");
            }

            public override void Mostrar(int profundidade)
            {
                Console.WriteLine(new string('-', profundidade) + Nome);
            }

            public override void Remover(Componente c)
            {
                Console.WriteLine("Não é possível remover a folha!");
            }
        }
    }
}
