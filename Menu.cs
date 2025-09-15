using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Формы_для_добавления;

namespace WindowsFormsApp1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Film().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new FormBilet().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new FormKinoteatr().ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new FormPolzovatel().ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new FormPoseshenie().ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new FormSeans().ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new FormZal().ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new FormQuery().ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
