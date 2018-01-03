using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace univer
{
    public class Faculty:Interface
    {
        public string Name { get; set; }

        public List<Group> Groups { get; set; }

        public int GetAverageScore()
        {
            int _groupNotesSum = 0;
            foreach (Group grp in Groups)
            {
                _groupNotesSum += grp.GetAverageScore();
            }
            return _groupNotesSum / Groups.Count;
        }
    }
}
