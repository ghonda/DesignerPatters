namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var assuntoConcreto = new AssuntoConcreto();
            assuntoConcreto.Anexar(new ObservadorConcreto("X", assuntoConcreto));
            assuntoConcreto.Anexar(new ObservadorConcreto("Y", assuntoConcreto));
            assuntoConcreto.Anexar(new ObservadorConcreto("Z", assuntoConcreto));

            assuntoConcreto.EstadoAssunto = "ABC";
            assuntoConcreto.Notificar();

        }
        
    }

}
