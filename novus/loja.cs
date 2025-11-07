using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace novus
{
    public partial class loja : Form
    {
        public loja()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void loja_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelDesc_Click(object sender, EventArgs e)
        {

        }

        private void labelTitulo_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string origem = textBoxImg.Text;
            string nomeArquivo = Path.GetFileName(origem);
            string nome = textBoxTitulo.Text;
            string descricao = textBoxDesc.Text;
            string img = nomeArquivo;

            if (!decimal.TryParse(textBoxValor.Text, out decimal preco) ||
                !int.TryParse(textBoxEstoque.Text, out int estoque))
            {
                MessageBox.Show("Verifique se os valores de preço e estoque são numéricos válidos.");
                return;
            }

            string tamanho = textBoxTamanho.Text;
            string conexaoBanco = "server=localhost;user id=root;password=;database=db_novus";

            using (MySqlConnection conexao = new MySqlConnection(conexaoBanco))
            {
                conexao.Open();
                MySqlTransaction transacao = conexao.BeginTransaction();

                try
                {
                    // Inserir produto
                    string insertProdutoQuery = @"INSERT INTO tb_produtos (nome, preco, tamanho, descricao, img)
                                              VALUES (@nome, @preco, @tamanho, @descricao, @img)";
                    MySqlCommand insertCmd = new MySqlCommand(insertProdutoQuery, conexao, transacao);
                    insertCmd.Parameters.AddWithValue("@nome", nome);
                    insertCmd.Parameters.AddWithValue("@preco", preco);
                    insertCmd.Parameters.AddWithValue("@tamanho", tamanho);
                    insertCmd.Parameters.AddWithValue("@descricao", descricao);
                    insertCmd.Parameters.AddWithValue("@img", img);
                    insertCmd.ExecuteNonQuery();

                    long novoProdutoId = insertCmd.LastInsertedId;

                    // Inserir estoque do produto
                    string insertEstoqueQuery = @"INSERT INTO tb_estoque (id_produto, quantidade_disponivel, data_atualizacao)
                                              VALUES (@id_produto, @estoque, NOW())";
                    MySqlCommand estoqueCmd = new MySqlCommand(insertEstoqueQuery, conexao, transacao);
                    estoqueCmd.Parameters.AddWithValue("@id_produto", novoProdutoId);
                    estoqueCmd.Parameters.AddWithValue("@estoque", estoque);
                    estoqueCmd.ExecuteNonQuery();

                    transacao.Commit();
                    MessageBox.Show("Produto cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    textBoxDesc.Clear();
                    textBoxEstoque.Clear();
                    textBoxImg.Clear();
                    textBoxTitulo.Clear();
                    textBoxValor.Clear();

                }
                catch (Exception ex)
                {
                    transacao.Rollback();
                    MessageBox.Show("Erro ao cadastrar produto: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            textBoxImg.Enabled = false;

        }

        private void textBoxTitulo_TextChanged(object sender, EventArgs e)
        {

        }
        private string caminhoImagemFinal = "C:\\xampp\\htdocs\\PI\\novus.z7--PI-\\img\\roupas";
        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Arquivos de imagem (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string origem = openFileDialog.FileName;

                    // Pasta destino fixa que você quer
                    string pastaDestino = @"C:\xampp\htdocs\PI\novus.z7--PI-\img\roupas";

                    // Cria a pasta caso não exista
                    if (!Directory.Exists(pastaDestino))
                        Directory.CreateDirectory(pastaDestino);

                    string nomeArquivo = Path.GetFileName(origem);
                    string destino = Path.Combine(pastaDestino, nomeArquivo);

                    try
                    {
                        // Antes de copiar, libera a imagem atual da PictureBox para evitar erro
                        if (pictureBox1.Image != null)
                        {
                            pictureBox1.Image.Dispose();
                            pictureBox1.Image = null;
                        }

                        // Copia o arquivo para a pasta destino
                        File.Copy(origem, destino, true);

                        // Carrega imagem em memória para liberar arquivo
                        using (var tempStream = new MemoryStream(File.ReadAllBytes(destino)))
                        {
                            pictureBox1.Image = Image.FromStream(tempStream);
                        }

                        // Salva o caminho relativo para o banco (exemplo: "roupas/nomeArquivo.jpg")
                        caminhoImagemFinal = Path.Combine("roupas", nomeArquivo).Replace("\\", "/");
                        textBoxImg.Text = caminhoImagemFinal;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao copiar a imagem: " + ex.Message);
                    }
                }
            }
        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Form1 form = new Form1();
            form.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

