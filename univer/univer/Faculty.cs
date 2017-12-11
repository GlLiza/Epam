using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace univer
{
    public class Faculty
    {
        public string Name { get; set; }

        public List<Group> Groups { get; set; }

        public double MiddleFaculty(Faculty faculty)
        {
            double mid = 0.0;

            foreach (var group in faculty.Groups)
            {
                foreach (var students in group.Students)
                {
                    foreach (var sub in students.Subjects)
                    {

                    }
                }

            }


            return
        }

    }
}
