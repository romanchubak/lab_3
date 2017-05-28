using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
    class State
    {
        public State N { get; set; }
        public State K { get; set; }
        public State M { get; set; }
        public bool Finish { get; set; }

        public State()
        {
            N = K = M =  null;
            Finish = false;
        }
        public State(bool fin)
        {
            N = K = M = null;
            Finish = fin;
        }
        public bool Check(string s)
        {
            if( s != "")
                switch (s[0])
                {
                    case 'n': return N != null && N.Check(s.Substring(1));
                    case 'k': return K != null && K.Check(s.Substring(1));
                    case 'm': return M != null && M.Check(s.Substring(1));
                }
            return Finish;
        }
        
    }
}
