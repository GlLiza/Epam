using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace univer
{
    public class Group
    {
        public int Number { get; set; }
        public List<Student> Students { get; set; }

        public Group() { }

        public Group(int Number, List<Student> Students)
        {
            this.Number = Number;
            this.Students = Students;
        }

        public double MiddleGroup(Group group)
        {
            double midSt = 0.0, midGroup = 0.0;


            foreach (var student in group.Students)
            {
                foreach (var sub in student.Subjects)
                {
                    midSt += sub.MiddleMark(sub);
                }

                midSt = midSt / student.Subjects.Count;
                midGroup += midSt;
            }
            return midGroup / group.Students.Count;
        }


    }
}

