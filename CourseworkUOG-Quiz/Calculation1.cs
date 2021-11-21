using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseworkUOG_Quiz
{
    interface Calculation1
    {
        void score(int a);
        void scorePercentage(int a);

        void AveragePercentage(int a);
    }

    public class ImplementationCalculation : Calculation1
    {
        public void score (int a)
        {
            Console.WriteLine(a);
        }

        public void scorePercentage(int a)
        {
            Console.WriteLine(a * 100 % / totalQuestion);

        }

        public void AveragePercentage(int a)
        {
            Console.WriteLine(a / 1);
        }

        static void main()
        {
            ImplementationCalculation obj = new ImplementationCalculation();
            Calculation1 i = obj;
            i.score(5); i.scorePercentage(5); i.AveragePercentage(5);
            Console.ReadLine();
            Console.WriteLine("Would you like to Exit? (Y = yes, N = No):");
            while (Console.ReadLine().ToUpper() == "Y") ;
            Console.WriteLine("bye");
            Console.ReadKey();
        }
    }
}


