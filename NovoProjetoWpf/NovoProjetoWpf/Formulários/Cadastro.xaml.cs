using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace NovoProjetoWpf.Formulários
{
    /// <summary>
    /// Lógica interna para Cadastro.xaml
    /// </summary>
    public partial class Cadastro : Window
    {

        
        public Cadastro()
        {
            InitializeComponent();
           
            tbNome.IsEnabled = true;
            tbEmail.IsEnabled = true;
            tbTelefone.IsEnabled = true;
            cbSexo.IsEnabled = true;
            dtpNascimento.IsEnabled = true;
            //btAdd.IsEnabled = false;
            btSalvar.IsEnabled = true;  
            btCancelar.IsEnabled = true;
        }

        private void btSalvar_Click(object sender, RoutedEventArgs e)
        {
            var nome = tbNome.Text;
            var sexo = cbSexo.Text;
            var email = tbEmail.Text;
            var telefone = tbTelefone.Text;
            var dataNascimeto = dtpNascimento.Text;

        }
        private void limparEspacos()
        {
            tbEmail.Clear();
            tbTelefone.Clear();
            tbNome.Clear(); 
        }

        private void btCancelar_Click(object sender, RoutedEventArgs e)
        {
            limparEspacos();

        }

       
    }
}
