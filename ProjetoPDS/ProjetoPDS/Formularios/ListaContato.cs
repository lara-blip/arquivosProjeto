using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjetoPDS.Formularios
{
    public partial class ListaContato : Form
    {
        private MySqlConnection _conexao;

        public ListaContato()
        {
            InitializeComponent();
            Listar();
        }

        private void Conexao()
        {
            string conexaoString = "server=localhost;database=app_contato_bd;user=root;password=root;port=3360";
            _conexao = new MySqlConnection(conexaoString);
            _conexao.Open();
        }

        private void Listar()
        {


            Conexao();

            var sql = "Select*From Contato;";
            var comando = new MySqlCommand(sql, _conexao);
            var adptador = new MySqlDataAdapter(comando);
            comando.ExecuteNonQuery();

            DataTable dataTabl = new DataTable();
            adptador.Fill(dataTabl);
         

            dataTabl.Columns["id_con"].ColumnName = "ID";
            dataTabl.Columns["nome_con"].ColumnName = "Nome";
            dataTabl.Columns["data_nasc_con"].ColumnName = "Data de Nascimento";
            dataTabl.Columns["sexo_con"].ColumnName = "Sexo";
            dataTabl.Columns["telefone_con"].ColumnName = "Telefone";
            dataTabl.Columns["email_con"].ColumnName = "Email";

            dgvLista.DataSource = dataTabl;
        }


    } 
       
       

}
