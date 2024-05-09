using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Selecao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if(txtNomeP.Text != "" && txtNomeP.Text != " ") { 
                comboBoxNomeP.Items.Add(txtNomeP.Text.ToString());
                txtNomeP.Clear();
            }
            else
                MessageBox.Show("Entre com um estado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void txtNomeP_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxNomeP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //private void button1_Click(object sender, EventArgs e)
        //{

        //}

        private void btnCopiarTodos_Click(object sender, EventArgs e)
        {
            foreach(var i in comboBoxNomeP.Items)
                lbxTodosEstados.Items.Add(i.ToString());
        }

        private void btnSelecionados_Click(object sender, EventArgs e)
        {
            if (lbxTodosEstados.SelectedItems.Count > 0){
                foreach (var i in lbxTodosEstados.SelectedItems)
                    lbxEstadosSelecionados.Items.Add(i.ToString());
                lbxTodosEstados.SelectedItems.Clear();
            }
            else
                MessageBox.Show("Selecione pelo menos 1 item");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
