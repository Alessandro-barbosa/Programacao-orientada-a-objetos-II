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
            Pessoa pessoa = new Pessoa();
            pessoa.nome = txtNome.Text.ToString();
            pessoa.telefone = txtTelefone.Text.ToString();
            pessoa.tipo = comboBoxTipos.ToString();

            List<Pessoa> listaPessoas = new List<Pessoa>();
            Dictionary<string, List<Pessoa>> listaTelefone = new Dictionary<string, List<Pessoa>>();

            listaTelefone.Add(pessoa.telefone, listaPessoas);

            listaNomeTelefone.Items.Add(pessoa.telefone);
        }

        private void listaNomeTelefone_SelectedIndexChanged(object sender, EventArgs e)
        {
            showtxtNome.Text =  ;
        }
    }
}
