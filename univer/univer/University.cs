using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace univer
{
    public class University
    {
        public string Name { get; set; }
        public List<Faculty> Faculties{get;set;}

        public University() { }
        public University(string Nam, List<Faculty> Facul)
        {
            this.Name = Nam;
            this.Faculties = Facul;
        }
    }
}
