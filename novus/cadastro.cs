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
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text;
            string nome = textBoxNome.Text;
            string tel = textBoxTel.Text;
            string senha = textBoxSenha.Text;
            string csenha = textBoxCSenha.Text;

            string conexaoBanco = "server=localhost;user id=root;password=;database=db_novus";

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(senha) || string.IsNullOrWhiteSpace(csenha))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(email)) 
            {
                MessageBox.Show("Por favor, insira um email.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(nome)) 
            {
                MessageBox.Show("Por favor, insira um nome.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(senha)) 
            {
                MessageBox.Show("Por favor, insira uma senha.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //validação de senha com numero letras e caracteres especiais e tamanho minimo de 6 caracteres

            if (!senha.Any(char.IsDigit) || !senha.Any(char.IsLetter) || !senha.Any(ch => !char.IsLetterOrDigit(ch)))
            {
                MessageBox.Show("A senha deve conter pelo menos um número, uma letra e um caractere especial.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (senha != "Digite sua senha" && senha.Length < 6)
            {
                MessageBox.Show("A senha deve ter pelo menos 6 caracteres.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (string.IsNullOrWhiteSpace(csenha)) 
            {
                MessageBox.Show("Por favor, confirme sua senha.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (tel != "Digite seu Telefone" && tel.Length < 10)
            {
                MessageBox.Show("Por favor, insira um telefone válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (tel != "Digite seu Telefone" && !tel.All(char.IsDigit))
            {
                MessageBox.Show("O telefone deve conter apenas números.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!email.Contains("@") || !email.Contains("."))
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
                        string checkQuery = "SELECT COUNT(*) FROM tb_cadastro WHERE email = @Email";
                        MySqlCommand checkCmd = new MySqlCommand(checkQuery, conexao);
                        checkCmd.Parameters.AddWithValue("@Email", email);
                        int userCount = Convert.ToInt32(checkCmd.ExecuteScalar());
                        if (userCount > 0)
                        {
                            MessageBox.Show("Este email já está cadastrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            string query = "INSERT INTO tb_cadastro (email, nome, senha, telefone) VALUES (@Email, @Nome, @Senha, @telefone)";

                            MySqlCommand cmd = new MySqlCommand(query, conexao);
                            cmd.Parameters.AddWithValue("@Email", email);
                            cmd.Parameters.AddWithValue("@Nome", nome);
                            cmd.Parameters.AddWithValue("@Senha", senha);
                            cmd.Parameters.AddWithValue("@telefone", tel);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Form1 form = new Form1();
                            form.Show();
                            this.Hide();
                        }
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
            textBoxTel.Text = "Digite seu Telefone";
            textBoxSenha.Text = "Digite sua senha";
            textBoxCSenha.Text = "Confirme sua senha";

            textBoxEmail.Text = "Digite seu email";
            textBoxSenha.Text = "Digite sua senha";
            textBoxNome.Text = "Digite seu nome";
            textBoxTel.Text = "Digite seu Telefone";

            textBoxEmail.ForeColor = Color.Gray;
            textBoxNome.ForeColor = Color.Gray;
            textBoxTel.ForeColor = Color.Gray;
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

            textBoxTel.Enter += (s, ev) =>
            {
                if (textBoxTel.Text == "Digite seu Telefone")
                {
                    textBoxTel.Text = "";
                    textBoxTel.ForeColor = Color.Black;
                }
            };
            textBoxTel.Leave += (s, ev) =>
            {
                if (string.IsNullOrWhiteSpace(textBoxTel.Text))
                {
                    textBoxTel.Text = "Digite seu Telefone";
                    textBoxTel.ForeColor = Color.Gray;
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
