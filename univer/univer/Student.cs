using System.Collections.Generic;

namespace univer
{
    public class Student
    {
        public string Name { get; set; }

        public List<Subject> Subjects { get; set; }

        public Student() { }
         
        public Student(string Name, List<Subject> Sub)
        {
            this.Name = Name;
            this.Subjects = Sub;
        }

        
        public double MiddleStudent(Student student) {

            double mid = 0.0;
            foreach (var tmp in student.Subjects)
            {
                mid+=tmp.MiddleMark(tmp);
            }

            return mid / student.Subjects.Count;
        }
       
    }
}
