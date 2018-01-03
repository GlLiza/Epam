using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace univer
{
    public class Program
    {
        static void Main(string[] args)
        {

            Subject sb1 = new Subject("English", new List<int> {10, 6, 8, 6,3,10,7 });
            Subject sb2 = new Subject("Germany", new List<int> { 7, 6, 7,6});

            Subject sbj1 = new Subject("Math", new List<int> { 5, 6, 5, 6 });
            Subject sbj2 = new Subject("Physic", new List<int> { 1, 2, 3, 4, 5 });
          
            Student std1 = new Student("Hladkaja Liza",new List<Subject> { sb1, sb2 });
            Student std2 = new Student("Bazhezha Kate", new List<Subject> { sbj1, sbj2 });

            Group two = new Group(2,new List<Student> { std1,std2});

            sb1.GetInfo();
            sbj2.GetInfo();
            

            std1.GetInfo();
            std2.GetInfo();

            two.GetInfo();



        }
    }
}
