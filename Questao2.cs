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
    public partial class Questao2 : Form
    {
        public Questao2()
        {
            InitializeComponent();
        }

        public void resultado()
        {
            int soma = 0,quantidadeItem = 0,quantiPares = 0,quantiImpar = 0,somaPar = 0, somaImpar = 0;
            foreach (int item in listBoxImpares.Items)
            {
                soma += item;
                quantidadeItem += 1;
                quantiImpar += 1;
                somaImpar += item;
            }
            foreach (int item in listBoxPares.Items)
            {
                soma += item;
                quantidadeItem += 1;
                quantiPares += 1;
                somaPar += item;
            }

            txtSomaTotal.Text = "" + soma;
            txtQtdNumeros.Text = "" + quantidadeItem;
            txtQtdPares.Text = "" + quantiPares;
            txtQtdImpares.Text = "" + quantiImpar;
            txtSomaPares.Text = "" + somaPar;
            txtSomaImpares.Text = "" + somaImpar;
        }

        private void btnAddNum_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(txtNumero.Text);

            if (numero % 2 == 0)
            {
                listBoxPares.Items.Add(numero);
            }
            else
            {
                listBoxImpares.Items.Add(numero);
            }

        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            resultado();
        }
    }
}
