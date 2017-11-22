using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace checkParallelEclipse
{
    class Program
    {
        static void Main(string[] args)
        {
            bool checkParallel= false;
            string filename = "BM_with_Prelude.DATA";

            string[] lines = File.ReadAllLines(filename);
            foreach (var line in lines)
            {
                var newline = line.ToUpper();
                newline = newline.Trim();
                if (newline.StartsWith("PARALLEL"))
                {
                    checkParallel = true;
                }
            }
            //return checkParallel;
            if (checkParallel)
            {
                Console.WriteLine("Eclipse is parallel");
            }
            else
            {
                Console.WriteLine("Eclipse is NOT parallel");
            }

            //*********************************** modification check**********************************************

            //*********************************** parallel deve commits ******************************************


            //*********************************** complete parallel work*******************************************


            Console.ReadKey();
        }
    }
}
