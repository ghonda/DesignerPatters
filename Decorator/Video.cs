using System;

namespace Decorator
{
    public class Video : ItemBiblioteca
    {
        public Video(string diretor, string titulo, int minutosDuracao, int numeroCopias)
        {
            Diretor = diretor;
            Titulo = titulo;
            MinutosDuracao = minutosDuracao;
            NumeroCopias = numeroCopias;
        }

        public string Diretor { get; set; }
        public string Titulo { get; set; }
        public int MinutosDuracao { get; set; }


        public override void Exibe()
        {
            Console.WriteLine("\nVideo ----");
            Console.WriteLine($" Diretor: {Diretor}");
            Console.WriteLine($" Titulo: {Titulo}");
            Console.WriteLine($" Duracao: {MinutosDuracao}");
            Console.WriteLine($" # Cópias: {NumeroCopias}");
        }
    }
}
