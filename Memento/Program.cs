namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            var originator = new Originator
            {
                State = "On"
            };

            var careTaker = new CareTaker
            {
                Memento = originator.CreateMemento()
            };

            originator.State = "Off";

            originator.SetMemento(careTaker.Memento);
        }
    }
}
