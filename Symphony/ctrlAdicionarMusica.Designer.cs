namespace Symphony
{
    partial class ctrlAdicionarMusica
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlAdicionarMusica));
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAlbum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAlbum = new System.Windows.Forms.Label();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picMusica = new System.Windows.Forms.PictureBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.mskData = new System.Windows.Forms.MaskedTextBox();
            this.txtArtista = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picMusica)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(398, 339);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(119, 36);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // cmbGenero
            // 
            this.cmbGenero.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.IntegralHeight = false;
            this.cmbGenero.ItemHeight = 13;
            this.cmbGenero.Items.AddRange(new object[] {
            "Rock",
            "Pop",
            "Rap",
            "Sertanejo",
            "Axé",
            "Pagode",
            "MPB",
            "Clássica",
            "Eletrônica",
            "Reggae"});
            this.cmbGenero.Location = new System.Drawing.Point(575, 146);
            this.cmbGenero.MaxDropDownItems = 3;
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(152, 21);
            this.cmbGenero.TabIndex = 2;
            this.cmbGenero.Text = "Selecione um";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label7.Location = new System.Drawing.Point(394, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 21);
            this.label7.TabIndex = 48;
            this.label7.Text = "Gênero Musical:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label4.Location = new System.Drawing.Point(394, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 21);
            this.label4.TabIndex = 47;
            this.label4.Text = "Ano de lançamento:";
            // 
            // txtAlbum
            // 
            this.txtAlbum.Location = new System.Drawing.Point(575, 241);
            this.txtAlbum.Name = "txtAlbum";
            this.txtAlbum.Size = new System.Drawing.Size(152, 20);
            this.txtAlbum.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label3.Location = new System.Drawing.Point(394, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 21);
            this.label3.TabIndex = 45;
            this.label3.Text = "Nome do Albúm:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(575, 77);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(152, 20);
            this.txtNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(394, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 21);
            this.label2.TabIndex = 43;
            this.label2.Text = "Nome da Música:";
            // 
            // lblAlbum
            // 
            this.lblAlbum.AutoSize = true;
            this.lblAlbum.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblAlbum.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAlbum.Location = new System.Drawing.Point(84, 34);
            this.lblAlbum.Name = "lblAlbum";
            this.lblAlbum.Size = new System.Drawing.Size(139, 21);
            this.lblAlbum.TabIndex = 54;
            this.lblAlbum.Text = "Cover do Albúm";
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(575, 296);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(152, 20);
            this.txtLink.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label1.Location = new System.Drawing.Point(394, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 21);
            this.label1.TabIndex = 56;
            this.label1.Text = "Link do Youtube:";
            // 
            // picMusica
            // 
            this.picMusica.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picMusica.BackgroundImage")));
            this.picMusica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picMusica.InitialImage = null;
            this.picMusica.Location = new System.Drawing.Point(32, 58);
            this.picMusica.Name = "picMusica";
            this.picMusica.Size = new System.Drawing.Size(250, 250);
            this.picMusica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMusica.TabIndex = 53;
            this.picMusica.TabStop = false;
            this.picMusica.Tag = "";
            this.picMusica.Click += new System.EventHandler(this.picMusica_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnLimpar.Location = new System.Drawing.Point(608, 339);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(119, 36);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // mskData
            // 
            this.mskData.Location = new System.Drawing.Point(575, 192);
            this.mskData.Mask = "0000";
            this.mskData.Name = "mskData";
            this.mskData.Size = new System.Drawing.Size(152, 20);
            this.mskData.TabIndex = 3;
            this.mskData.ValidatingType = typeof(System.DateTime);
            // 
            // txtArtista
            // 
            this.txtArtista.Location = new System.Drawing.Point(575, 109);
            this.txtArtista.Name = "txtArtista";
            this.txtArtista.Size = new System.Drawing.Size(152, 20);
            this.txtArtista.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label5.Location = new System.Drawing.Point(394, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 21);
            this.label5.TabIndex = 58;
            this.label5.Text = "Artista:";
            // 
            // ctrlAdicionarMusica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtArtista);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAlbum);
            this.Controls.Add(this.picMusica);
            this.Controls.Add(this.mskData);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.cmbGenero);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAlbum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Name = "ctrlAdicionarMusica";
            this.Size = new System.Drawing.Size(817, 423);
            ((System.ComponentModel.ISupportInitialize)(this.picMusica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picMusica;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAlbum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAlbum;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.MaskedTextBox mskData;
        private System.Windows.Forms.TextBox txtArtista;
        private System.Windows.Forms.Label label5;
    }
}
