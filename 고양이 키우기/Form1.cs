using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 고양이_키우기
{
    public partial class Form1 : Form
    {
        Cat MyCat = new Cat("Lucas", 1);
        public Form1()
        {
            InitializeComponent();
            CatScreen.Text = MyCat.Express();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Play_Click(object sender, EventArgs e)
        {
            MyCat.Play();
            CatScreen.Text = MyCat.Express();
        }

        private void Eat_Click(object sender, EventArgs e)
        {
            MyCat.Eat();
            CatScreen.Text = MyCat.Express();
        }

        private void CatTimer_Tick(object sender, EventArgs e)
        {
            MyCat.GetBord();
            CatScreen.Text = MyCat.Express();
        }
    }
}