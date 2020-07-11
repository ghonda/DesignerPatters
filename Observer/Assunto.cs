using System.Collections.Generic;

namespace Observer
{
    public abstract class Assunto
    {
        private readonly List<Observador> _observadores = new List<Observador>();

        public void Anexar(Observador observador)
        {
            _observadores.Add(observador);
        }

        public void Desanexar(Observador observador)
        {
            _observadores.Remove(observador);
        }

        public void Notificar()
        {
            foreach (var observador in _observadores)
            {
                observador.Update();
            }

        }
    }
}
