using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            State E = new State(true);
            State GD = new State(false);
            State F = new State(true);
            State H = new State(false);
            State BC = new State { N = E, K = F, M = null, Finish = true };
            State A = new State { N = BC, K = BC, M = GD, Finish = false };
            GD.N = E;
            GD.K = F;
            F.K = H;
            F.N = GD;
            H.N = GD;
            H.K = H;

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Input your string(q -> exit): ");
                string s = Console.ReadLine();
                if (s == "q")
                    exit = true;
                else
                    Console.WriteLine(A.Check(s));
            }
            //Console.ReadKey();
        }
    }
}
