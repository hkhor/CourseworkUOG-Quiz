using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseworkUOG_Quiz
{
    interface calculation
    { 
        void score(int a);
        
    }


    class ImplementationResult : calculation
    {
        // a is stand for total correctly question that you got
        public void score(int a)
        {
           
                Console.WriteLine((int)Math.Round((double)(a * 100) / totalQuestions));
            
        }
     

        static void main()
        {
            ImplementationResult obj = new ImplementationResult();
            calculation i = obj;
            i.score((10 * 100) / totalQuestion); 
            Console.ReadLine();
            Console.WriteLine("Would you like to exit? (Y = yes, N = No):");
            while (Console.ReadLine().ToUpper() == "N") ;
            Console.WriteLine("Bye");
            Console.ReadKey();

              
            
           
        }

    }

}





 

    

