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
    public partial class Questao4 : Form
    {
        public Questao4()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.listEsq.SelectedItem != null)
            {
                listDir.Items.Add(listEsq.SelectedItem.ToString());
                this.listEsq.Items.Remove(this.listEsq.SelectedItem);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listEsq.Items.Add(txtPalavra.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (this.listDir.SelectedItem != null)
            {
                listEsq.Items.Add(listDir.SelectedItem.ToString());
                this.listDir.Items.Remove(this.listDir.SelectedItem);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (String item in listEsq.Items)
            {
                listDir.Items.Add(item);
            }
            listEsq.Items.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            foreach (String item in listDir.Items)
            {
                listEsq.Items.Add(item);
            }
            listDir.Items.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listDir.Items.Clear();
            listEsq.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
