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
    public partial class Form1 : Form
    {
        public List<Contato> listaContatos = new List<Contato>();

        public SqlConnection conexao;
        public Form1()
        {
            InitializeComponent();
            conexao = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = AgendaTelefonica; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            try
            {
                conexao.Open();
                //var selectCmd = conexao.CreateCommand();
                //selectCmd.CommandText = "select * FROM Contato";

                //SqlDataReader leitorDados = selectCmd.ExecuteReader();
                //while (leitorDados.Read())
                //{
                //    var id = leitorDados["id"];
                //    var nome = leitorDados["nome"];
                //    var numero = leitorDados["numero"];
                //    //MessageBox.Show($"id: {id} nome: {nome} numero: {numero}", "Contato");
                //}
            }
            catch(Exception e)
            {
                MessageBox.Show("Deu errado aqui ao puxar a conexao", "Erro");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var buscarCmd = conexao.CreateCommand();
            string nome = txtBuscar.Text;
            buscarCmd.CommandText = ($"select * from Contato where Nome = '{nome}'");
            SqlDataReader leitorDados = buscarCmd.ExecuteReader();

            List<Contato> contatosBuscados = new List<Contato>();

            while (leitorDados.Read()){
                Contato contato = new Contato(leitorDados["Id"].ToString(), leitorDados["Nome"].ToString(), leitorDados["numero"].ToString());
                contatosBuscados.Add(contato);
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = contatosBuscados;
            buscarCmd.Cancel();
            leitorDados.Close();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show();
        }

        public void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            
            var selectCmd = conexao.CreateCommand();
            selectCmd.CommandText = "select * FROM Contato";

            SqlDataReader leitorDados = selectCmd.ExecuteReader();
            
            
            while (leitorDados.Read()){
                Contato contato = new Contato(leitorDados["id"].ToString(), leitorDados["nome"].ToString(), leitorDados["numero"].ToString());
                listaContatos.Add(contato);
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaContatos;
            leitorDados.Close();
            selectCmd.Cancel();
        }

        public void RenovarDataGrid()
        {
            var selectCmd = conexao.CreateCommand();
            selectCmd.CommandText = "select * FROM Contato";

            SqlDataReader leitorDados = selectCmd.ExecuteReader();

            while (leitorDados.Read())
            {
                Contato contato = new Contato(leitorDados["id"].ToString(), leitorDados["nome"].ToString(), leitorDados["numero"].ToString());
                listaContatos.Add(contato);
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaContatos;
            leitorDados.Close();
            selectCmd.Cancel();
        }
    }
}
