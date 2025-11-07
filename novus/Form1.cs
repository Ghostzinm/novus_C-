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

namespace novus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxEmail.Text = "Digite seu email";
            textBoxSenha.Text = "Digite sua senha";

            textBoxEmail.ForeColor = Color.Gray;
            textBoxSenha.ForeColor = Color.Gray;

            textBoxEmail.Enter += (s, ev) =>
            {
                if (textBoxEmail.Text == "Digite seu email")
                {
                    textBoxEmail.Text = "";
                    textBoxEmail.ForeColor = Color.Black;
                }
            };
            textBoxEmail.Leave += (s, ev) =>
            {
                if (string.IsNullOrWhiteSpace(textBoxEmail.Text))
                {
                    textBoxEmail.Text = "Digite seu email";
                    textBoxEmail.ForeColor = Color.Gray;
                }
            };

            textBoxSenha.Enter += (s, ev) =>
            {
                if (textBoxSenha.Text == "Digite sua senha")
                {
                    textBoxSenha.Text = "";
                    textBoxSenha.ForeColor = Color.Black;
                    textBoxSenha.UseSystemPasswordChar = true;
                }
            };

            textBoxSenha.Leave += (s, ev) =>
            {
                if (string.IsNullOrWhiteSpace(textBoxSenha.Text))
                {
                    textBoxSenha.UseSystemPasswordChar = false;
                    textBoxSenha.Text = "Digite sua senha";
                    textBoxSenha.ForeColor = Color.Gray;
                }
            };
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            cadastro cad = new cadastro();
            cad.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string email = textBoxEmail.Text;
            string senha = textBoxSenha.Text;

            string conexaoBanco = "server=localhost;user id=root;password=;database=db_novus";

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("Por favor, insira um email válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    using (MySql.Data.MySqlClient.MySqlConnection conexao = new MySql.Data.MySqlClient.MySqlConnection(conexaoBanco))
                    {
                        conexao.Open();
                        string consulta = "SELECT * FROM tb_cadastro WHERE email = @Email AND senha = @Senha";
                        using (MySql.Data.MySqlClient.MySqlCommand comando = new MySql.Data.MySqlClient.MySqlCommand(consulta, conexao))
                        {
                            comando.Parameters.AddWithValue("@Email", email);
                            comando.Parameters.AddWithValue("@Senha", senha);
                            using (MySql.Data.MySqlClient.MySqlDataReader leitor = comando.ExecuteReader())
                            {
                                if (leitor.Read())
                                {
                                    MessageBox.Show("Login bem-sucedido!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    loja loja = new loja();
                                    loja.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Email ou senha incorretos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
