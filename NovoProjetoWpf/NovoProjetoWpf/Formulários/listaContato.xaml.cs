using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using NovoProjetoWpf.Formulários;
using MySqlConnector;
using System.Data.SqlClient;
using System.Data;

namespace NovoProjetoWpf.Formulários
{
    /// <summary>
    /// Lógica interna para listaContato.xaml
    /// </summary>
    public partial class listaContato : Window
    {
        private MySqlConnection _conexao;

        public listaContato()
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
            var reader = comando.ExecuteReader();
            var lista = new List<Object> ();

            while (reader.Read ()) 
            {
                var contato = new
                {
                    Codigo = reader.GetString(1),
                    Nome = reader.GetString(2),
                    DataNascimento = reader.GetDateTime(3),
                    Sexo = reader.GetString(4),
                    Email = reader.GetString(5),
                    Telefone = reader.GetString(6),

                };
                lista.Add (contato);
            }
            dgvLista.ItemsSource = lista;

          

            
        }


    }
    
}
