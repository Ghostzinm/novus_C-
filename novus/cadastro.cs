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

namespace novus
{
    public partial class cadastro : Form
    {
        public cadastro()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text;
            string nome = textBoxNome.Text;
            string senha = textBoxSenha.Text;
            string csenha = textBoxCSenha.Text;

            string conexaoBanco = "server=localhost;user id=root;password=;database=db_novus";

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(senha) || string.IsNullOrWhiteSpace(csenha))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if ( !email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("Por favor, insira um email válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (senha != csenha)
            {
                MessageBox.Show("As senhas não coincidem.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {

                using (MySqlConnection conexao = new MySqlConnection(conexaoBanco))
                {
                    try
                    {
                        conexao.Open();
                        string query = "INSERT INTO tb_cadastro (email, nome, senha) VALUES (@Email, @Nome, @Senha)";

                        MySqlCommand cmd = new MySqlCommand(query, conexao);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Nome", nome);
                        cmd.Parameters.AddWithValue("@Senha", senha);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Form1 form = new Form1();
                        form.Show();
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao cadastrar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        } 

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cadastro_Load(object sender, EventArgs e)
        {
            textBoxEmail.Text = "Digite seu email";
            textBoxNome.Text = "Digite seu nome";
            textBoxSenha.Text = "Digite sua senha";
            textBoxCSenha.Text = "Confirme sua senha";

            textBoxEmail.Text = "Digite seu email";
            textBoxSenha.Text = "Digite sua senha";

            textBoxEmail.ForeColor = Color.Gray;
            textBoxNome.ForeColor = Color.Gray;
            textBoxSenha.ForeColor = Color.Gray;
            textBoxCSenha.ForeColor = Color.Gray;

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

            textBoxNome.Enter += (s, ev) =>
            {
                if (textBoxNome.Text == "Digite seu nome")
                {
                    textBoxNome.Text = "";
                    textBoxNome.ForeColor = Color.Black;
                }
            };

            textBoxNome.Leave += (s, ev) =>
            {
                if (string.IsNullOrWhiteSpace(textBoxNome.Text))
                {
                    textBoxNome.Text = "Digite seu nome";
                    textBoxNome.ForeColor = Color.Gray;
                }
            };

            textBoxCSenha.Enter += (s, ev) =>
            {
                if (textBoxCSenha.Text == "Confirme sua senha")
                {
                    textBoxCSenha.Text = "";
                    textBoxCSenha.ForeColor = Color.Black;
                    textBoxCSenha.UseSystemPasswordChar = true;
                }
            };

            textBoxCSenha.Leave += (s, ev) =>
            {
                if (string.IsNullOrWhiteSpace(textBoxCSenha.Text))
                {
                    textBoxCSenha.UseSystemPasswordChar = false;
                    textBoxCSenha.Text = "Confirme sua senha";
                    textBoxCSenha.ForeColor = Color.Gray;
                }

            };

        }
    }
}
