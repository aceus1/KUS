using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bprojekt
{
    class User
    {
        public string Uname; //Uname=ID
        public string Upass;//Passwort
        public int Urang;//Rang
        public User(string name, string password, int rang)
        {
            Uname = name;
            Upass = password;
            Urang = rang;
        }
    }
}
