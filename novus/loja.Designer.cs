namespace novus
{
    partial class loja
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loja));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxTamanho = new System.Windows.Forms.ComboBox();
            this.textBoxEstoque = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSelecionarImagem_Click = new System.Windows.Forms.Button();
            this.textBoxImg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.labelPreco = new System.Windows.Forms.Label();
            this.labelDesc = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(255)))), ((int)(((byte)(237)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(170, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "BEM VINDO A LOLJA";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(255)))), ((int)(((byte)(237)))));
            this.panel1.Controls.Add(this.textBoxTamanho);
            this.panel1.Controls.Add(this.textBoxEstoque);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnSelecionarImagem_Click);
            this.panel1.Controls.Add(this.textBoxImg);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBoxValor);
            this.panel1.Controls.Add(this.textBoxDesc);
            this.panel1.Controls.Add(this.textBoxTitulo);
            this.panel1.Controls.Add(this.labelPreco);
            this.panel1.Controls.Add(this.labelDesc);
            this.panel1.Controls.Add(this.labelTitulo);
            this.panel1.Location = new System.Drawing.Point(-2, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(815, 361);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textBoxTamanho
            // 
            this.textBoxTamanho.FormattingEnabled = true;
            this.textBoxTamanho.Items.AddRange(new object[] {
            "Unico",
            "M",
            "G",
            "GG"});
            this.textBoxTamanho.Location = new System.Drawing.Point(156, 185);
            this.textBoxTamanho.Name = "textBoxTamanho";
            this.textBoxTamanho.Size = new System.Drawing.Size(121, 21);
            this.textBoxTamanho.TabIndex = 19;
            // 
            // textBoxEstoque
            // 
            this.textBoxEstoque.Location = new System.Drawing.Point(156, 212);
            this.textBoxEstoque.Name = "textBoxEstoque";
            this.textBoxEstoque.Size = new System.Drawing.Size(268, 20);
            this.textBoxEstoque.TabIndex = 17;
            this.textBoxEstoque.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(255)))), ((int)(((byte)(237)))));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(31, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Estoque";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(510, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 239);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // btnSelecionarImagem_Click
            // 
            this.btnSelecionarImagem_Click.Location = new System.Drawing.Point(34, 251);
            this.btnSelecionarImagem_Click.Name = "btnSelecionarImagem_Click";
            this.btnSelecionarImagem_Click.Size = new System.Drawing.Size(100, 23);
            this.btnSelecionarImagem_Click.TabIndex = 14;
            this.btnSelecionarImagem_Click.Text = "Selecionar img";
            this.btnSelecionarImagem_Click.UseVisualStyleBackColor = true;
            this.btnSelecionarImagem_Click.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxImg
            // 
            this.textBoxImg.Location = new System.Drawing.Point(119, 280);
            this.textBoxImg.Name = "textBoxImg";
            this.textBoxImg.Size = new System.Drawing.Size(125, 20);
            this.textBoxImg.TabIndex = 12;
            this.textBoxImg.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(31, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Caminho da img";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(255)))), ((int)(((byte)(237)))));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(31, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tamanho";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(255)))), ((int)(((byte)(237)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(158, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(326, 39);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cadastrar camisas";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(621, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 33);
            this.button1.TabIndex = 8;
            this.button1.Text = "enviar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxValor
            // 
            this.textBoxValor.Location = new System.Drawing.Point(156, 156);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(268, 20);
            this.textBoxValor.TabIndex = 7;
            this.textBoxValor.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Location = new System.Drawing.Point(156, 129);
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(268, 20);
            this.textBoxDesc.TabIndex = 6;
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Location = new System.Drawing.Point(156, 103);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(268, 20);
            this.textBoxTitulo.TabIndex = 5;
            this.textBoxTitulo.TextChanged += new System.EventHandler(this.textBoxTitulo_TextChanged);
            // 
            // labelPreco
            // 
            this.labelPreco.AutoSize = true;
            this.labelPreco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(255)))), ((int)(((byte)(237)))));
            this.labelPreco.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelPreco.Location = new System.Drawing.Point(31, 163);
            this.labelPreco.Name = "labelPreco";
            this.labelPreco.Size = new System.Drawing.Size(30, 13);
            this.labelPreco.TabIndex = 4;
            this.labelPreco.Text = "valor";
            this.labelPreco.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelDesc
            // 
            this.labelDesc.AutoSize = true;
            this.labelDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(255)))), ((int)(((byte)(237)))));
            this.labelDesc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelDesc.Location = new System.Drawing.Point(31, 136);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(55, 13);
            this.labelDesc.TabIndex = 3;
            this.labelDesc.Text = "Descrição";
            this.labelDesc.Click += new System.EventHandler(this.labelDesc_Click);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(255)))), ((int)(((byte)(237)))));
            this.labelTitulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTitulo.Location = new System.Drawing.Point(31, 110);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(49, 13);
            this.labelTitulo.TabIndex = 2;
            this.labelTitulo.Text = "TITULO ";
            this.labelTitulo.Click += new System.EventHandler(this.labelTitulo_Click);
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(787, 520);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 33);
            this.button2.TabIndex = 20;
            this.button2.Text = "fechar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::novus.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 58);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // loja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(255)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(918, 565);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "loja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "loja";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.loja_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelDesc;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelPreco;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.TextBox textBoxDesc;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxImg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSelecionarImagem_Click;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxEstoque;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox textBoxTamanho;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}