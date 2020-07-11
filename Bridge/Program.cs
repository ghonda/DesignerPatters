using Bridge.ExemploReal;

namespace Bridge
{
    class Program
    {
        //Desacoplar uma abstração de sua implementação 
        //    para que as duas possam variar independentemente.
        static void Main(string[] args)
        {

            //Esse código do mundo real demonstra o padrão Bridge no qual 
            //uma abstração do BusinessObject é dissociada da implementação no DataObject. 
            //As implementações do DataObject podem evoluir dinamicamente sem alterar nenhum cliente.
            Customers customers = new Customers("Chicago");

            // Set ConcreteImplementor

            customers.Data = new CustomersData();

            // Exercise the bridge

            customers.Show();
            customers.Next();
            customers.Show();
            customers.Next();
            customers.Show();
            customers.Add("Henry Velasquez");

            customers.ShowAll();


        }


        /*
        Exemplo Pratico
            var smartTv = new SmartTv();
            Console.WriteLine("Selecione um canal");
                Console.WriteLine("1 - Filmes");
                Console.WriteLine("2 - Documentários");
                Console.WriteLine("3 - Culinaria");
                var input = Console.ReadKey();
                switch (input.KeyChar)
                {
                    case '1':
                        smartTv.CanalAtual = new Filme();
                        break;
                    case '2':
                        smartTv.CanalAtual = new Documenario();
                        break;
                    case '3':
                        smartTv.CanalAtual = new Culinaria();
                        break;
                    default:
                        break;
                }
                Console.WriteLine();
                smartTv.ExibeCanalSintonizado();
                smartTv.PlayTv();
        */
    }
}
