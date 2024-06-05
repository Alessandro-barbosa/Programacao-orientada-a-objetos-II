using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataBase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConexaoString c = new ConexaoString();
            SqlConnection conexao;
            conexao = new SqlConnection(c.conexaoString);
            try
            {
                conexao.Open();
                /* Parte 2 Inserir Dados 
                
                Console.WriteLine("Conexão aberta!");

                var insertCmd = conexao.CreateCommand();
                insertCmd.CommandText = "INSERT INTO Exemplo (Nome, Sobrenome) VALUES (@nome, @sobrenome);";

                var parmNome = new SqlParameter("@nome", "Maria");
                var parmSobrenome = new SqlParameter("@sobrenome", "Joaquina");

                insertCmd.Parameters.Add(parmNome);
                insertCmd.Parameters.Add(parmSobrenome);

                var resultado = insertCmd.ExecuteNonQuery();
                Console.WriteLine("Linhas afetadas: " + resultado.ToString());
                */
                /*Parte 2 Buscar Dados */

                var selectCmd = conexao.CreateCommand();

                selectCmd.CommandText = "SELECT * FROM Exemplo";

                SqlDataReader leitorDados = selectCmd.ExecuteReader();

                while (leitorDados.Read())
                {
                    Console.WriteLine("ID: " + leitorDados["Id"] + " " + leitorDados["Nome"] + " " + leitorDados["Sobrenome"]);
                };
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro na conexão");
            }
            finally
            {
                conexao.Close();
                Console.WriteLine("conexão fechada");
            }


        }
    }
}
