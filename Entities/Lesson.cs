﻿
namespace Course.Entities
{
    abstract class Lesson
    {
        public string Title { get; set; }

        public Lesson() { }

        public Lesson(string title)
        {
            Title = title;
        }

        public abstract int Duration();
    }
}
