using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam
{
    public partial class Form1 : Form
    {
        private readonly Student[] _students;

        public Form1()
        {
            InitializeComponent();

            _students = new Student[]
            {

                new UsualStudent("Добрий", "Stoida", "Oleksandrovich", 40),
                new UsualStudent("Добрий", "Stoida1", "Oleksandrovich1", 34),
                new UsualStudent("Добрий", "Stoida2", "Oleksandrovich2", 36),
                new UsualStudent("Добрий", "Stoida3", "Oleksandrovich3", 26),
                new UsualStudent("Добрий", "Stoida4", "Oleksandrovich4", 31),

                new CleverS("Привіт", "Денисов", "Абобов", 35),
                new CleverS("Привіт", "Хумус", "Бобас", 25),
                new CleverS("Привіт", "Сівір", "Сіріус", 24),
                new CleverS("Привіт", "Бібас", "Бобас", 23),
                new GeniusStudent("Валерій", "Жмишенко", "Альбертович", 1),

                new Dobriy("Добрий день", "Zavyalov", "Serggich", 35),
                new Dobriy("Добрий день", "Oler", "Norde", 40),
                new Dobriy("Добрий день", "Plata", "Ohus", 20),
                new Dobriy("Добрий день", "Punk", "Gibis", 27),
                new Dobriy("Добрий день", "Abo", "Vivo", 27),
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var student in _students)
            {
                if (student.PassExam())
                    textBox1.Text += student + ", Student passed exam" + Environment.NewLine;
                else
                    textBox1.Text += student + ", Student doesn't pass exam" + Environment.NewLine;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}