using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            var concretAggregate = new ConcretAggregate();
            concretAggregate[0] = "Item A";
            concretAggregate[1] = "Item B";
            concretAggregate[2] = "Item C";
            concretAggregate[3] = "Item D";

            var iterator = concretAggregate.CreateIterator();

            Console.WriteLine("Interagindo com a coleção:");

            object item = iterator.First();

            while (item != null)
            {
                Console.WriteLine(item);
                item = iterator.Next();
            }
        }
    }
}
