using System.Collections.Generic;
using System.Linq;

namespace univer
{
    public class Subject
    {
        public string Name { get; set; }
        public List<int> Marks { get; set; }

        public Subject() { }

        public Subject(string Name, List<int> Marks)
        {
            this.Name = Name;
            this.Marks = Marks;
        }

        //возвращает средний балл по одному предмету
        public double MiddleMark(Subject sub)
        {
            return Marks.Average();
        }


        //возвращаетт средний балл по нескольким предметам
        public double MiddleSubject(List<Subject> subjects) {
            double mid = 0.0;

            foreach (var sub in subjects)
            {
                mid += sub.Marks.Average();
            }

          return mid / subjects.Count;
        }
    }
}
