using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaExam
{
    class Realist : People
    {

        public Realist(string name, int years) : base(name, years) { }

        public override string Hello(People Ppl)
        {
            string hello;
            if(Ppl.Years - years >= 5)
            {
                 hello = "Добрий день " + Ppl.Name;

            }
            else
            {
                hello = "Привіт " + Ppl.Name;
            }
            return hello;
        }
        public override string Info()
        {
            string info = "Мене звати " + name + " Мій вік: " + years + " Я реаліст";
            return info;
        }

        




    }
}
