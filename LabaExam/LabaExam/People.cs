using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaExam
{
    abstract class People
    {

        protected string name;
        
        protected int years;

        abstract public string Hello(People Ppl);

        abstract public string Info();

        public People(string name, int years)
        {
            this.name = name;
            this.years = years;

        }
        public string Name
        {
            get 
            {
                return name;
            }
            set
            {
                name = value;
            }   
        }
        public int Years
        {
            get
            {
                return years;
            }
            set
            {
                if (value > 10)
                {
                    years = value;
                }
                   
            }
        }
    }
}
