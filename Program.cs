using System;
using System.Reflection;

namespace csharp_tests
{
    class Program
    {
        static void Main(string[] args)
        {
            BetoTask task = new BetoTask();
            BetoTask task2 = new BetoTask();
            task2.Title = "Tarefa de Beto 2";
            if(args != null && args.Length > 0) {
                task.Done = bool.Parse(args[0]);
                task2.Done = bool.Parse(args[0]);
            }
            task.Display();
            task2.Display();
        }
    }
}
