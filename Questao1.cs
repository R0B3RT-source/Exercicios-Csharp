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
    public partial class Questao1 : Form
    {
        public Questao1()
        {
            InitializeComponent();
            cbmOperacao.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int contador,numero = Convert.ToInt32(txtNumero.Text);
            float formula;
            if (numero < 0 || numero > 10)
            {
                MessageBox.Show("Digite um numero entre 1 e 10");
            }
            else
            {
                listBox1.Items.Clear();
                int index = cbmOperacao.SelectedIndex;
                if(index == 0)
                {
                    for (contador = 1; contador <= 10; ++contador)
                    {
                        formula = numero + contador;
                        listBox1.Items.Add(numero + " + " + contador + " = " + formula);

                    }
                }else if (index == 1)
                {
                    for (contador = 1; contador <= 10; ++contador)
                    {
                        formula = numero * contador;
                        listBox1.Items.Add(numero + " * " + contador + " = " + formula);

                    }
                }
                else if (index == 2)
                {
                    for (contador = 1; contador <= 10; ++contador)
                    {
                        formula = numero - contador;
                        listBox1.Items.Add(numero + " - " + contador + " = " + formula);

                    }
                }
                else if (index == 3)
                {
                    for (contador = 1; contador <= 10; ++contador)
                    {
                        formula = numero / contador;
                        listBox1.Items.Add(numero + " / " + contador + " = " + formula);

                    }
                }



            }
        }
    }
}
