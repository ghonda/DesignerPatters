using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var rx2018 = new TanqueInimigo();
            var r2d2 = new RoboInimigo();

            var robo_adapter = new RoboInimigoAdapter(r2d2);

        }
    }

    public interface IAtaqueInimigo
    {
        void ArmaFogo();
        void Movimenta();
        void Pilotar(string piloto);
    }

    public class TanqueInimigo : IAtaqueInimigo
    {

        public void ArmaFogo()
        {
            var danoAtaque = _gerador.Next(10) + 1;
            Console.WriteLine($"Tanque inimigo fez {danoAtaque} de dano!");
        }

        public void Movimenta()
        {
            var movimento = _gerador.Next(5) + 1;
            Console.WriteLine($"Tanque inimigo andou {movimento} espaços.");
        }

        public void Pilotar(string piloto)
        {
            Console.WriteLine($"{piloto} está no comando do tanque.");
        }

        readonly Random _gerador = new Random();
    }

    public class RoboInimigo
    {
        //Adaptee
        public void EsmagarComMaos()
        {
            var danoAtaque = _gerador.Next(10) + 1;
            Console.WriteLine($"O Robo inimigo causou {danoAtaque} de dano com o ataque esmagar com as mãos!");
        }

        public void AndarFrente()
        {
            var movimento = _gerador.Next(5) + 1;
            Console.WriteLine($"O Robo inimigo andou {movimento} passos para frente!");
        }

        public void ReagirContraHumano(string piloto)
        {
            Console.WriteLine($"O Robo inimigo vai contra {piloto}!");
        }


        readonly Random _gerador = new Random();
    }

    public class RoboInimigoAdapter : IAtaqueInimigo
    {
        private RoboInimigo _roboInimigo;

        //Adaper - o adptador do objeto Robo com o Tanque

        public RoboInimigoAdapter(RoboInimigo roboInimigo)
        {
            _roboInimigo = roboInimigo;
        }
        public void ArmaFogo()
        {
            _roboInimigo.EsmagarComMaos();
        }

        public void Movimenta()
        {
            _roboInimigo.AndarFrente();
        }

        public void Pilotar(string piloto)
        {
            _roboInimigo.ReagirContraHumano(piloto);
        }
    }
}
