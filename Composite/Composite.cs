using System;
using System.Collections.Generic;

namespace Composite
{
    partial class Program
    {
        public class Composite : Componente
        {
            public Composite(string nome) : base(nome) { }
            public override void Adicionar(Componente c)
            {
                filhos.Add(c);
            }

            public override void Mostrar(int profundidade)
            {
                Console.WriteLine(new string('-', profundidade) + Nome);
                foreach (var item in filhos)
                    item.Mostrar(profundidade + 2);
            }

            public override void Remover(Componente c)
            {
                filhos.Remove(c);
            }

            private readonly List<Componente> filhos = new List<Componente>();
        }
    }
}
