using System;
using System.Drawing;

namespace Composite
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var root = new Composite("ROOT");
            root.Adicionar(new Folha("Folha A"));
            root.Adicionar(new Folha("Folha B"));

            var comp = new Composite("Composite X");
            comp.Adicionar(new Folha("Folha XA"));
            comp.Adicionar(new Folha("Folha XB"));

            root.Adicionar(comp);
            root.Adicionar(new Folha("Folha C"));

            var folha = new Folha("Folha D");
            root.Adicionar(folha);
            root.Remover(folha);

            root.Mostrar(1);
        }
    }
}
