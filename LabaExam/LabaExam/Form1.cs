using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabaExam
{
    public partial class Form1 : Form
    {
        public Random rnd = new Random();

        public Form1()
        {

            string[] Names = new string[8]
            {
                 "Andriy","Alex","Dmytro","Barmutov","Bibas","Valakas","Semen","Vlados"
            };
            
            InitializeComponent();
            Info.Text = "";
            People[] ludi = new People[5];
            

            ludi[0]  = new Realist(Names[rnd.Next(0,7)], rnd.Next(20,40));
            ludi[1]  = new Formalist(Names[rnd.Next(0, 7)], rnd.Next(20, 40));
            ludi[2] = new Formalist(Names[rnd.Next(0, 7)], rnd.Next(20, 40));
            ludi[3] = new Neformal(Names[rnd.Next(0, 7)], rnd.Next(20, 40));
            ludi[4] = new Neformal(Names[rnd.Next(0, 7)], rnd.Next(20, 40));

            for(int i = 0; i<5;i++)
            {
                Info.Text += ludi[i].Info()+ "\n";

            }
            Info.Text += "\n";

            for(int i = 0; i<5;i++)
            {
                for(int j = 0; j<5;j++)
                {
                    if (j != i)
                    {
                        Info.Text += ludi[i].Hello(ludi[j]) + "\n";
                    }
                }
                Info.Text += "\n";
            }




        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
