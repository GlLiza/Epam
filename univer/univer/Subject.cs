using System;
using System.Collections.Generic;
using System.Linq;

namespace univer
{
    public class Subject : Interface
    {
        public string Name { get; set; }
        public List<int> Marks { get; set; }

        public Subject() { }

        public Subject(string Name, List<int> Marks)
        {
            this.Name = Name;
            this.Marks = Marks;
        }

        public int GetAverageScore()
        {
            return Marks.Sum() / Marks.Count();
        }

        public void GetInfo()
        {
            Console.WriteLine("Subject: {0}",Name);
            Console.Write("Subject {0} markers:",Name);
            foreach (int mark in Marks)
            {
                Console.Write("{0}",mark);
            }
            Console.WriteLine();
            Console.WriteLine("Subject {1} average score:{0}", GetAverageScore(), Name);
        }
    }
}
