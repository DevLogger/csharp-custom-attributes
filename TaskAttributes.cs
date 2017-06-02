using System;

namespace csharp_tests
{
    [AttributeUsage(AttributeTargets.All)]
    public class TaskAttributes : Attribute
    {
        public string Owner { get; set; }
        public string Title { get; set; }

    }
}