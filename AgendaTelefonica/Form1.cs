using System;
using System.Collections;
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
        List<Pessoa> listaPessoas = new List<Pessoa>();
        public Form1()
        {
            InitializeComponent();
        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void lblTelefone_Click(object sender, EventArgs e)
        {

        }

        private void btnAeitarTermos_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text.ToString();
            string telefone = txtTelefone.Text.ToString();
            string tipo = comboBoxTipos.Text.ToString();
            Pessoa pessoa = new Pessoa(nome, telefone, tipo);
            LimparCampos();

            listaPessoas.Add(pessoa);

            listaNomeTelefone.DataSource = null;
            listaNomeTelefone.DataSource = listaPessoas;
            listaNomeTelefone.DisplayMember = "getNome";
            listaNomeTelefone.SelectedItem = -1;
            listaNomeTelefone.ClearSelected();

            listaNomeTelefone.SelectedValueChanged +=
               new EventHandler(listaNomeTelefone_SelectedValueChanged);
        }

        private void listaNomeTelefone_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if(listaNomeTelefone.SelectedIndex != -1)
            //{
            //    showtxtNome.Visible = true;
            //    showtxtNome.Text = listaPessoas[listaNomeTelefone.SelectedIndex].nome;
            //    showTxtTelefone.Visible = true;
            //    showTxtTelefone.Text = listaPessoas[listaNomeTelefone.SelectedIndex].telefone.ToString();
            //    showTxtTipo.Visible = true;
            //    showTxtTipo.Text = listaPessoas[listaNomeTelefone.SelectedIndex].tipo.ToString();
            //}
        }
        private void listaNomeTelefone_SelectedValueChanged(object sender, EventArgs e)
        {

            if (listaNomeTelefone.SelectedIndex != -1)
            {
                showtxtNome.Visible = true;
                showtxtNome.Text = listaPessoas[listaNomeTelefone.SelectedIndex].nome;
                showTxtTelefone.Visible = true;
                showTxtTelefone.Text = listaPessoas[listaNomeTelefone.SelectedIndex].telefone.ToString();
                showTxtTipo.Visible = true;
                showTxtTipo.Text = listaPessoas[listaNomeTelefone.SelectedIndex].tipo.ToString();
            }
        }
        private void LimparCampos(){
            txtNome.Clear();
            txtTelefone.Clear();
            comboBoxTipos.Text = "";
        }
    }
}
