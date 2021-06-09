using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaExam
{
    class Formalist : People 
    {
        public Formalist(string name, int years) : base(name, years) { }


        public override string Hello(People Ppl)
        {
            string hello = "Добрий день "+Ppl.Name;
            return hello;
        }
        public override string Info()
        {
            string info = "Мене звати " + name + " Мій вік: " + years + " Я формаліст";
            return info;
        }
    }
}
