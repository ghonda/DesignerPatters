using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var h1 = new ConcreteHandler1();
            var h2 = new ConcreteHandler2();
            var h3 = new ConcreteHandler3();


            h1.SetSucessor(h2);
            h2.SetSucessor(h3);

            int[] requests = { 200, 5, 24, 22, 18, 3, 27, 20 };
            foreach (var request in requests)
            {
                h1.HandleRequest(request);
            }

        }
    }

    public abstract class Handler
    {
        protected Handler _sucessor;

        public void SetSucessor(Handler sucessor)
        {
            _sucessor = sucessor;
        }

        public abstract void HandleRequest(int request);
    }

    public class ConcreteHandler1 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 0 && request < 10)
            {
                Console.WriteLine($"{GetType().Name} Handled request {request}");
            }
            else if (_sucessor != null)
            {
                _sucessor.HandleRequest(request);
            }
        }
    }

    public class ConcreteHandler2 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 10 && request < 20)
            {
                Console.WriteLine($"{GetType().Name} Handled request {request}");
            }
            else if (_sucessor != null)
            {
                _sucessor.HandleRequest(request);
            }
        }
    }

    public class ConcreteHandler3 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 20 && request < 30)
            {
                Console.WriteLine($"{GetType().Name} Handled request {request}");
            }
            else if (_sucessor != null)
            {
                _sucessor.HandleRequest(request);
            }
        }
    }
}
