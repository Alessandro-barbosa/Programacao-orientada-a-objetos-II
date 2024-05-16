using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaTelefonica
{
    public partial class Form1 : Form
    {
        List<Pessoa> lista;
        public Form1()
        {
            InitializeComponent();
            lista = new List<Pessoa>();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            
            var nome = txtNome.Text;
            var telefone = txtTelefone.Text;
            var trabalho = txtTrabalho.Text;
            var tipo = boxTipo.Text;

            Pessoa p = new Pessoa(nome, telefone, trabalho, tipo);

            lista.Add(p);
            gridView.DataSource = null;
            gridView.DataSource = lista;
            
            limparCampos();
        }

        public void limparCampos()
        {
            txtNome.Clear();
            txtTelefone.Clear();
            txtTrabalho.Clear();
            boxTipo.Text = "";
        }

        private void gridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridView.SelectedCells.Count > 0)
            {
                var celula = gridView.SelectedCells[0];
                int linhaIndice = celula.RowIndex;

                Pessoa pessoa = gridView.Rows[linhaIndice].DataBoundItem as Pessoa;
                MessageBox.Show(pessoa.nome, "Nome");
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (gridView.SelectedCells.Count > 0)
            {
                var celula = gridView.SelectedCells[0];
                lista.RemoveAt(celula.RowIndex);
                gridView.DataSource = null;
                gridView.DataSource = lista;
                MessageBox.Show("Pessoa removida com sucesso");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }
    }
}
