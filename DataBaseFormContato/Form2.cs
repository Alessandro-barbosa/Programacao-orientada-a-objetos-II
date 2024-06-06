using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DataBaseFormContato
{
    public partial class Form2 : Form
    {
        Form1 origem = null;
        public Form2(Form1 origem)
        {
            InitializeComponent();
            this.origem = origem;   
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                var insertCmd = origem.conexao.CreateCommand();

                string nome = txtNome.Text;
                string numero = txtNumero.Text;

                var parmNome = new SqlParameter("@Nome", $"{nome}");
                var parmSobrenome = new SqlParameter("@numero", $"{numero}");

                insertCmd.Parameters.Add(parmNome);
                insertCmd.Parameters.Add(parmSobrenome);

                insertCmd.CommandText = ($"INSERT INTO Contato(Nome, numero) VALUES(@nome, @numero)");

                insertCmd.ExecuteNonQuery();
                origem.RenovarDataGrid();
                MessageBox.Show("Insert feito com sucesso", "Sucesso");
            }catch(Exception ex)
            {
                MessageBox.Show("Erro no insert", "Erro"); 
            }
        }
    }
}
