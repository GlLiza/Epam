using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace univer
{
    public class University:Interface
    {
        public string Name { get; set; }
        public List<Faculty> Faculties{get;set;}

        public University() { }
        public University(string Nam, List<Faculty> Facul)
        {
            this.Name = Nam;
            this.Faculties = Facul;
        }

        public int GetAverageScore()
        {
            int _facultyNotesSum = 0;
            foreach (Faculty fcl in Faculties)
            {
                _facultyNotesSum += fcl.GetAverageScore();
            }
            return _facultyNotesSum / Faculties.Count;
        }
    }
}
