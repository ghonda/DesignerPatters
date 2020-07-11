using System;
using System.Collections.Generic;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentRecords = new SortedList();
            studentRecords.Add("Rodrigo");
            studentRecords.Add("Maria");
            studentRecords.Add("João");
            studentRecords.Add("Carlos");
            studentRecords.Add("Ana");

            studentRecords.SetSortStrategy(new QuickSort());
            studentRecords.Sort();

            studentRecords.SetSortStrategy(new ShellSort());
            studentRecords.Sort();

            studentRecords.SetSortStrategy(new MergeSort());
            studentRecords.Sort();

        }
    }

    public abstract class SortStrategy
    {
        public abstract void Sort(List<string> list);
    }

    public class QuickSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            list.Sort();
            Console.WriteLine("Quick Sorted List");
        }
    }

    public class ShellSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            Console.WriteLine("Shell Sorted List");
        }
    }

    public class MergeSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            Console.WriteLine("Merge Sorted List");
        }
    }

    public class SortedList
    {
        private readonly List<string> _list = new List<string>();
        private SortStrategy _sortStrategy;

        public void SetSortStrategy(SortStrategy sortStrategy)
        {
            _sortStrategy = sortStrategy;
        }

        public void Add(string name)
        {
            _list.Add(name);
        }

        public void Sort()
        {
            _sortStrategy.Sort(_list);
            foreach (var name in _list)
            {
                Console.WriteLine(" " + name);
            }
            Console.WriteLine();
        }

    }
}
