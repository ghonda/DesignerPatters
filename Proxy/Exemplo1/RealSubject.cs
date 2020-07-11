using System;

namespace Proxy.Exemplo1
{
    public class RealSubject : Subject
    {
        public override void Request()
        {
            Console.WriteLine("Chamando RealSubject.Request");
        }
    }
}
