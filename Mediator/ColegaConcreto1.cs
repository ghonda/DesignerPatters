using System;

namespace Mediator
{
    public class ColegaConcreto1 : Colega
    {
        public ColegaConcreto1(Mediador mediador) : base(mediador)
        {
        }

        public void Enviar(string mensagem)
        {
            _mediador.Enviar(mensagem, this);
        }

        public void Notificar(string mensagem)
        {
            Console.WriteLine("Mensagem do Colega 1: " + mensagem);
        }

    }
}
