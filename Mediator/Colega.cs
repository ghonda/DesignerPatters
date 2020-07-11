namespace Mediator
{
    public abstract class Colega
    {
        protected Mediador _mediador;
        public Colega(Mediador mediador)
        {
            _mediador = mediador;
        }
    }
}
