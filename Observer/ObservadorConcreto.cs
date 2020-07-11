using System;

namespace Observer
{
    public class ObservadorConcreto : Observador
    {
        private readonly string _nome;
        private string _estadoObservador;
        private readonly AssuntoConcreto _assuntoContreto;

        public ObservadorConcreto(string nome, AssuntoConcreto assuntoContreto)
        {
            _nome = nome;
            _assuntoContreto = assuntoContreto;
        }

        public override void Update()
        {
            _estadoObservador = _assuntoContreto.EstadoAssunto;
            Console.WriteLine($"Observador {_nome} seu novo estado é: {_estadoObservador}");
        }

        public AssuntoConcreto Assunto { get; set; }
    }
}
