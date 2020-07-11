using System;

namespace Facade.Estrutural
{
    public class Facade
    {
        private SubSistemaUm um;
        private SubSistemaDois dois;
        private SubSistemaTres tres;

        public Facade()
        {
            um = new SubSistemaUm();
            dois = new SubSistemaDois();
            tres = new SubSistemaTres();
        }

        public void MetodoA()
        {
            Console.WriteLine("\nMétodoA() -------");
            dois.MetodoDois();
            tres.MetodoTres();
        }

        public void MetodoB()
        {
            Console.WriteLine("\nMétodoB() -------");
            um.MetodoUm();
            tres.MetodoTres();
        }
    }
}
