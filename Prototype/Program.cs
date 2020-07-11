using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            var funcionarioPermanente = new FuncionarioPermanente
            {
                Nome = "João",
                Idade = 30
            };

            var cloneFuncionarioPermanente = (FuncionarioPermanente)funcionarioPermanente.Clone();
            cloneFuncionarioPermanente.Nome = "Carlos";

            Console.WriteLine("Detalhes do funcionário permanente:");
            Console.WriteLine($"Nome: {funcionarioPermanente.Nome}");
            Console.WriteLine($"Idade: {funcionarioPermanente.Idade}");
            Console.WriteLine($"Tipo: {funcionarioPermanente.Tipo}");

            Console.WriteLine("");

            Console.WriteLine("Detalhes do funcionário permanente clonado:");
            Console.WriteLine($"Nome: {cloneFuncionarioPermanente.Nome}");
            Console.WriteLine($"Idade: {cloneFuncionarioPermanente.Idade}");
            Console.WriteLine($"Tipo: {cloneFuncionarioPermanente.Tipo}");
        }
    }

    public interface IFuncionario
    {
        IFuncionario Clone();
    }

    public enum TipoFuncionario
    {
        Permanente,
        Temporario
    }

    public class FuncionarioPermanente : IFuncionario
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public TipoFuncionario Tipo { get; } = TipoFuncionario.Permanente;

        public IFuncionario Clone()
        {
            return MemberwiseClone() as IFuncionario;
        }
    }

    public class FuncionarioTemporario : IFuncionario
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public TipoFuncionario Tipo { get; } = TipoFuncionario.Temporario;


        public IFuncionario Clone()
        {
            return MemberwiseClone() as IFuncionario;
        }
    }
}
