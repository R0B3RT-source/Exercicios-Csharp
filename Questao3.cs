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
    public partial class Questao3 : Form
    {
        public Questao3()
        {
            InitializeComponent();
        }

        private void Questao3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int contador, numeroIni = Convert.ToInt32(txtNumeroInicial.Text), numeroFim = Convert.ToInt32(txtNumeroFinal.Text);
            float formula;
            if (numeroIni < 0 || numeroIni > 10)
            {
                MessageBox.Show("Digite um numero entre 1 e 10");
                return;
            }
            else if (numeroFim < 0 || numeroFim > 10)
            {
                MessageBox.Show("Digite um numero entre 1 e 10");
                return;
            }
            else
            {
                for (contador = numeroIni; contador <= numeroFim; ++contador)
                {
                    formula = numeroIni + contador;
                    listBox1.Items.Add(numeroIni + " + " + contador + " = " + formula);

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
