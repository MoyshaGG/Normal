using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public class Dobriy : Student
    {
        private Random _random;

        public Dobriy(string name, string surname, string middleName, int attendedClasses) : base(name, surname, middleName, attendedClasses)
        {
            _random = new Random();
        }

        public override bool PassExam()
        {
            if (AttendedClasses == CountOfLessons)
                return true;
            if (AttendedClasses > CountOfLessons / 2)
            {
                if (_random.NextDouble() < 0.7)
                    return false;
                else
                    return true;
            }

            return false;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Surname: {Surname}, Middle name: {MiddleName}, Attended classes: {AttendedClasses}";
        }

    }
}
