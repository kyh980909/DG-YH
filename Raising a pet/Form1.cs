using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Raising_a_pet
{
    public partial class Form1 : Form
    {
        Pet MyPet = new Pet("대성이", 21);
        public Form1()
        {
            InitializeComponent();
            PetScreen.Text = MyPet.Express();
            PresentHappiness.Text = MyPet.ExpressHappiness();
        }

        private void Play_Click(object sender, EventArgs e)
        {
            MyPet.Play();
            PetScreen.Text = MyPet.Express();
            PresentHappiness.Text = MyPet.ExpressHappiness();
        }

        private void Eat_Click(object sender, EventArgs e)
        {
            MyPet.Eat();
            PetScreen.Text = MyPet.Express();
            PresentHappiness.Text = MyPet.ExpressHappiness();
        }

        private void PetTimer_Tick(object sender, EventArgs e)
        {
            MyPet.Board();
            PresentHappiness.Text = MyPet.ExpressHappiness();
        }
    }
}
