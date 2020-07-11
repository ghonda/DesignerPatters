namespace Composite
{
    partial class Program
    {
        public abstract class Componente
        {
            protected string Nome;

            public Componente(string nome)
            {
                Nome = nome;
            }

            public abstract void Adicionar(Componente c);
            public abstract void Remover(Componente c);
            public abstract void Mostrar(int profundidade);
        }
    }
}
