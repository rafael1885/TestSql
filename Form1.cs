using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace TestSql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void text_senha_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (text_email.Text == "" || text_senha.Text == "")
            {
                MessageBox.Show(" Caixa de texto vazia", " Formulario incompleto",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                text_senha.Clear();
                text_email.Focus();
             }
            else
            {
                conexao con = new conexao(); // criando objeto de acesso a classe conexao.cd

               try
                {
                    con.conectar(); // abrindo conexao com banco de dados SQlite
                    string sql = " SELECT * FROM usuario WHERE email = '" + text_email.Text + "'AND senha'" + text_senha.Text + "'"; // /Query SQl

                    SQLiteDataAdapter dados = new SQLiteDataAdapter(sql, con.conn); // Realizando Query de consulta
                    DataTable usuario = new DataTable(); // criando data table para receber os dados do banco

                    dados.Fill(usuario);//Passando os dados do meu DataAdapter para meu data table

                    if (usuario.Rows.Count < 0) // testando se existe algum registro
                    {

                        MessageBox.Show("Usuario invalido", "Registro não encontrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        text_senha.Clear();
                        text_email.Focus();
                    } 
                else
                    {
                        string nome = usuario.Rows[0]["nome"].ToString();
                        string sobrenome = usuario.Rows[0]["nome"].ToString();

                        MessageBox.Show("Bem Vindo(a)" + nome + " " + sobrenome, "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        text_email.Clear();
                        text_senha.Clear();
                        text_email.Focus();
                    }
                    con.desconectar();
                }

              
            catch(Exception E)
                {
                    MessageBox.Show(E.Message.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                }



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Nova_conta nova = new Nova_conta();
            nova.ShowDialog();
        }
    }
}
