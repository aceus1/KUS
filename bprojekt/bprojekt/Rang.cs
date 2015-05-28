using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bprojekt
{
    class Rang
    {
        private int rang;
        public Rang(int r)
        {
            rang = r;
        
        }
        public bool rangcheck()
        {
            if (rang==1)
            {
                //das ist ein Admin
                return true;
            }
            return false;
        }
    }
}
