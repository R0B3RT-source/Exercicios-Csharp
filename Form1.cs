using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoRobertCosta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Questao1 q = new Questao1();
            q.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Questao2 q = new Questao2();
            q.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Questao3 q = new Questao3();
            q.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Questao4 q = new Questao4();
            q.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Questao5 q = new Questao5();
            q.ShowDialog();
        }
    }
}
