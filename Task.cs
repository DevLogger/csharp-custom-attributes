using System;
using System.Reflection;

namespace csharp_tests
{
    public class Task
    {
        public TaskAttributes CustomAttr => this.GetType().GetTypeInfo().GetCustomAttribute<TaskAttributes>();

        public string title;
        public string Title { get { return title != null ? title : CustomAttr.Title; } set { title = value; } }
        public bool Done { get; set; }
        public string Owner { get => CustomAttr.Owner; }

        public void Display()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Owner: {Owner}");
            Console.WriteLine($"Done: {Done}");
        }
    }
}