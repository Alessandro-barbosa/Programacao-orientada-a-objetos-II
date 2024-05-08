using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "" && txtSobrenome.Text != "")
            {
                string nome_completo = txtNome.Text + " " + txtSobrenome.Text;
                txtNomeCompleto.Text = nome_completo;
                comboBoxNomes.Items.Add(nome_completo);
                listBox1.Items.Add(nome_completo);
                txtNome.Clear();
                txtSobrenome.Clear();
            }
            else
            {
                MessageBox.Show("Um dos campos está vazio");
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSelecionado.Text = comboBoxNomes.SelectedItem.ToString();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
