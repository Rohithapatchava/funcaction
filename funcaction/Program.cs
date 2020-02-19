using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using classlibcalculation;


namespace funcaction
{
    class Program
    {
        static void Main(string[] args)

        {
            Action<int, int > Multiply=(x,y)=>Console.WriteLine("{0}",x*y);
            Multiply(5, 8);
            Func<int, int, double> ad = (x, y) => x + y;
            Console.WriteLine("sumis {0}", ad(4, 5));
;                List<Student> lst = new List<Student>
            {
                new Student { ID=1,StudentName="Arvind",Course="c#"},
                new Student { ID=2,StudentName="momeen",Course="VD"},
            };
            //lst.Sort();
            //foreach(var s in lst)
            //{
              //  Console.WriteLine(s);
            //}

        Predicate<Student> fst = x => x.ID == 2;
           var st = lst.Find(fst);
            Console.WriteLine("{0}\t{1}\t{2}", st.ID, st.StudentName, st.Course);
        }
    }

}
