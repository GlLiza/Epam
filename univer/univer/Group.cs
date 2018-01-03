using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace univer
{
    public class Group:Interface
    {
        public int Number { get; set; }
        public List<Student> StudentsList { get; set; }

        public Group() { }

        public Group(int Number, List<Student> Students)
        {
            this.Number = Number;
            this.StudentsList = Students;
        }

        public int GetAverageScore()
        {
            int _groupNotesSum = 0;
            foreach (Student std in StudentsList)
            {
                _groupNotesSum += std.GetAverageScore();
            }
            return _groupNotesSum / StudentsList.Count;
        }
        public void GetInfo()
        {
            Console.WriteLine("Group: {0} {1}", Number);
            Console.WriteLine("Student notes: ");
            foreach (Student std in StudentsList)
            {
                Console.Write("Student: {0} {1} ", std.Name);
                foreach (Subject sbj in std.Subjects)
                {
                    for (int i = 0; i < sbj.Marks.Count; i++)
                    {
                         Console.Write("{0} ", sbj.Marks[i]); 
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("Student average score: {0}",GetAverageScore());
        }

    }
}

