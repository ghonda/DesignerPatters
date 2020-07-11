namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            var m = new MediadorConcreto();
            var c1 = new ColegaConcreto1(m);
            var c2 = new ColegaConcreto2(m);

            m.Colega1 = c1;
            m.Colega2 = c2;

            c1.Enviar("Como vc está?");
            c2.Enviar("Bem, Obrigado");
        }
    }
}
