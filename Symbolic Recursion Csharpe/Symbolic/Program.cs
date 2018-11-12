using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Symbolic
{
    class Program
    {
        static void Main(string[] args)
        {
            Symbolic("%#", 10);
            Console.WriteLine();

        }
        static void Symbolic (string symbole, int iteration)
        {
            Console.Write(symbole[iteration%2]);
            if(iteration>1)Symbolic(symbole, iteration - 1);
        }
    }
}
