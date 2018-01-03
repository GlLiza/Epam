using System;
using System.Collections.Generic;

namespace univer
{
    public class Student:Interface
    {
        public string Name { get; set; }

        public List<Subject> Subjects { get; set; }

        public Student() { }
         
        public Student(string Name, List<Subject> Sub)
        {
            this.Name = Name;
            this.Subjects = Sub;
        }

        public int GetAverageScore()
        {
            int studMarkSum = 0;
            foreach(Subject s in Subjects)
            {
                studMarkSum += s.GetAverageScore();
            }
            return studMarkSum / Subjects.Count;
        }

        public void GetInfo()
        {
            Console.WriteLine("Student: {0} {1}", Name);
            Console.WriteLine("Student notes: ");
            foreach (Subject s in Subjects)
            {
                Console.Write("Subject name: {0} ", s.Name);
                for (int i = 0; i < s.Marks.Count; i++)
                {
                    Console.Write("{0} ", s.Marks[i]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Student average score: {0}", GetAverageScore());
        }

    }
}
