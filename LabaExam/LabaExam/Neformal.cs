using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaExam
{
    class Neformal : People
    {

        public Neformal(string name, int years) : base(name, years) { }
        
        public override string Info()
        {
            string info =  "Мене звати " + name + " Мій вік: " + years + " Я неформал" ;
            return info;
        }
        public override string Hello(People Ppl)
        {
            string hello = "Привіт " + Ppl.Name;
            return hello;
        }

    }
}
