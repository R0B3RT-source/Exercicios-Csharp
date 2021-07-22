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
    public partial class Questao5 : Form
    {
        public Questao5()
        {
            InitializeComponent();
        }

        public void tamanho()
        {
            txtTotal.Text = "" +txtFrase.Text.Length;
        }

        public static string InverteString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        private void ContarVogais(string palavra)

        {

            txtVoga.Text = "" + palavra.Count(x => (x == 'a') || (x == 'e') || (x == 'i') || (x == 'o') || (x == 'u'));

        }

        public void inverte()
        {
            txtInvertida.Text = InverteString(txtFrase.Text);
        }

        public void retiraEspaco()
        {
            txtEspaco.Text = txtFrase.Text.Replace(" ", "");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tamanho();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            inverte();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ContarVogais(txtFrase.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            retiraEspaco();
        }

        public void quebraLetra()
        {
            foreach (char _char in txtFrase.Text)
            {
                listBox1.Items.Add(_char);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            tamanho();
            inverte();
            ContarVogais(txtFrase.Text);
            retiraEspaco();
            quebraLetra();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            quebraLetra();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
