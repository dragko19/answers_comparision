using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace answers_comparision
{
    class Program
    {
        public static int Main()
        {
            Comparision test = new Comparision();
            /*test.Set_student_answers('A', 'B', 'C', 'D');
            test.Set_teacher_answers('A', 'B', 'E', 'D');

            foreach (char elem in test._student_answers)
                Console.WriteLine(elem);

            foreach (char elem in test._teacher_answers)
                Console.WriteLine(elem);*/

            test.Compare();

            Console.ReadLine();
            return 0;
        }
    }
}
