using System;

namespace Mediator
{
    public class ColegaConcreto2 : Colega
    {
        public ColegaConcreto2(Mediador mediador) : base(mediador)
        {
        }

        public void Enviar(string mensagem)
        {
            _mediador.Enviar(mensagem, this);
        }

        public void Notificar(string mensagem)
        {
            Console.WriteLine("Mensagem do Colega 2: " + mensagem);
        }

    }
}
