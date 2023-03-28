using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoPDS.RegrasDeNegocio;
using ProjetoPDS.Contexto;
using MySql.Data.MySqlClient;


namespace ProjetoPDS
{
    public partial class CadastrarContato : Form
    {

        private MySqlConnection _conexao;

        public CadastrarContato()
        {
            InitializeComponent();
            Conexao();
            tbEmail.Enabled = false;
            tbNome.Enabled = false;
            tbTelefone.Enabled = false;
            dtpDataNasc.Enabled = false;
            tbSexo.Enabled = false;
            btCancelar.Enabled = false;
            btSalvar.Enabled = false;

        }

        private void Conexao()
        {
            string conexaoString = "server=localhost;database=app_contato_bd;user=root;password=root;port=3360";
            _conexao = new MySqlConnection(conexaoString);
            _conexao.Open();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            tbEmail.Enabled = true;
            tbNome.Enabled = true;
            tbTelefone.Enabled = true;
            dtpDataNasc.Enabled = true;
            tbSexo.Enabled = true;
            btSalvar.Enabled = true;
            btCancelar.Enabled = true;
            btAdd.Enabled = false;
        }

        public void limpaEspacos()
        {
            tbNome.Clear();
            tbTelefone.Clear();
            tbEmail.Clear();
           
           


        }
        private void btCancelar_Click(object sender, EventArgs e)
        {
            limpaEspacos();
            tbEmail.Enabled = false;
            tbNome.Enabled = false;
            tbTelefone.Enabled = false;
            dtpDataNasc.Enabled = false;
            tbSexo.Enabled = false;
            btCancelar.Enabled = false;
            btSalvar.Enabled = false;
            btAdd.Enabled = true;
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
          
                dtpDataNasc.Format = DateTimePickerFormat.Custom;
                dtpDataNasc.CustomFormat = "yyyy-MM-dd";

                var nome = tbNome.Text;
                var sexo = tbSexo.Text;
                var email = tbEmail.Text;
                var telefone = tbTelefone.Text;
                var dataNascimeto = dtpDataNasc.Text;

                if (nome != "" && sexo != "" && email != "" && telefone != "" && dataNascimeto != "")
                {

                    var slq = "INSERT INTO contato (nome_con, sexo_con, email_con, telefone_con, data_nasc_con) VALUES (@_nome, @_sexo, @_email, @_telefone, @_dataNascimento)";
                    var comando = new MySqlCommand(slq, _conexao);

                    comando.Parameters.AddWithValue("@_nome", nome);
                    comando.Parameters.AddWithValue("@_sexo", sexo);
                    comando.Parameters.AddWithValue("@_email", email);
                    comando.Parameters.AddWithValue("@_telefone", telefone);
                    comando.Parameters.AddWithValue("@_dataNascimento", dataNascimeto);
                    comando.ExecuteNonQuery();

                    limpaEspacos();

                    MessageBox.Show("Contato salvo com sucesso");
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Todos os campos devem ser preenchidos!");
                }

                
            }
            catch (Exception ex) 
            {
               MessageBox.Show("Ocorreu um erro ao salvar as informações. Contate  a equipe de suporte");
            }
            



            Cadastramento objcadastramento = new Cadastramento();
            objcadastramento.Email = tbEmail.Text;
            objcadastramento.Nome = tbNome.Text;
            objcadastramento.Telefone = tbTelefone.Text;
            objcadastramento.Data = dtpDataNasc.Value;
            objcadastramento.Sexo = tbSexo.Text;
            DadosContato.lista.Add(objcadastramento);
            tbEmail.Enabled = false;
            tbNome.Enabled = false;
            tbTelefone.Enabled = false;
            dtpDataNasc.Enabled = false;
            tbSexo.Enabled = false;
            btCancelar.Enabled = false;
            btSalvar.Enabled = false;
            btAdd.Enabled = true;
            tbEmail.Clear();
            tbNome.Clear();
            tbTelefone.Clear();
            tbSexo.Clear();
            //MessageBox.Show("SALVO COM SUCESSO!!!");
        }

        private void CadastrarContato_Load(object sender, EventArgs e)
        {

        }
    }
}