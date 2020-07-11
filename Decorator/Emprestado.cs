using System;
using System.Collections.Generic;

namespace Decorator
{
    public class Emprestado : Decorator
    {
        protected List<string> emprestados = new List<string>();
        public Emprestado(ItemBiblioteca itemBiblioteca) : base(itemBiblioteca)
        {
        }

        public void EmprestarItem(string nome)
        {
            emprestados.Add(nome);
            _itemBiblioteca.NumeroCopias--;
        }

        public void DevolverItem(string nome)
        {
            emprestados.Remove(nome);
            _itemBiblioteca.NumeroCopias++;
        }

        public override void Exibe()
        {
            base.Exibe();
            foreach (var item in emprestados)
                Console.WriteLine($"Emprestado: {item}");
        }
    }
}
