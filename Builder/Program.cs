using System;
using System.Reflection;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var fabricante = new Fabricante();
            ICelular celularBuilder = new AndroidBuilder();
            fabricante.Construtor(celularBuilder);

            Console.WriteLine($"Um novo Celular foi construido: {celularBuilder.Celular.Nome}");

            Console.ReadKey();

        }
    }

    public class Celular
    {
        public Celular(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; set; }
        public string Tela { get; set; }
        public string Bateria { get; set; }
        public string Sistema { get; set; }
        public string Camera { get; set; }
    }

    public interface ICelular
    {
        void BuildTela();
        void BuildBateria();
        void BuildSistema();
        void BuildCamera();

        Celular Celular { get; }
    }

    public class AndroidBuilder : ICelular
    {
        public AndroidBuilder()
        {
            Celular = new Celular("Android");
        }

        public Celular Celular { get; }

        public void BuildBateria()
        {
            Celular.Bateria = "MAH_1500";
        }

        public void BuildCamera()
        {
            Celular.Camera = "15 MP";
        }

        public void BuildSistema()
        {
            Celular.Sistema = "Android 4.5";
        }

        public void BuildTela()
        {
            Celular.Tela = "7";
        }
    }

    public class IPhoneBuilder : ICelular
    {
        public IPhoneBuilder()
        {
            Celular = new Celular("IPhone");
        }

        public Celular Celular { get; }

        public void BuildBateria()
        {
            Celular.Bateria = "MDD_10";
        }

        public void BuildCamera()
        {
            Celular.Camera = "16 MP";
        }

        public void BuildSistema()
        {
            Celular.Sistema = "iOS 11";
        }

        public void BuildTela()
        {
            Celular.Tela = "9";
        }
    }

    public class Fabricante
    {
        public void Construtor(ICelular celularBuilder)
        {
            celularBuilder.BuildBateria();
            celularBuilder.BuildSistema();
            celularBuilder.BuildTela();
            celularBuilder.BuildCamera();
        }
    }
}


