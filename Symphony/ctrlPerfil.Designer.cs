namespace Symphony
{
    partial class ctrlPerfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlPerfil));
            this.lblNomeUser2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblGosto = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.lblNomeUser = new System.Windows.Forms.Label();
            this.btnPlaylist = new System.Windows.Forms.Button();
            this.picPerfil = new System.Windows.Forms.PictureBox();
            this.dgvPlaylist = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.picPerfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaylist)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomeUser2
            // 
            this.lblNomeUser2.AutoSize = true;
            this.lblNomeUser2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeUser2.Location = new System.Drawing.Point(644, 113);
            this.lblNomeUser2.Name = "lblNomeUser2";
            this.lblNomeUser2.Size = new System.Drawing.Size(128, 21);
            this.lblNomeUser2.TabIndex = 16;
            this.lblNomeUser2.Text = "Fulano Da Silva";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(554, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "Musicas de";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(213, 164);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(100, 21);
            this.lblLogin.TabIndex = 14;
            this.lblLogin.Text = "fualno_silva";
            // 
            // lblGosto
            // 
            this.lblGosto.AutoSize = true;
            this.lblGosto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGosto.Location = new System.Drawing.Point(213, 267);
            this.lblGosto.Name = "lblGosto";
            this.lblGosto.Size = new System.Drawing.Size(97, 21);
            this.lblGosto.TabIndex = 13;
            this.lblGosto.Text = "Curte Rock";
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdade.Location = new System.Drawing.Point(213, 213);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(69, 21);
            this.lblIdade.TabIndex = 12;
            this.lblIdade.Text = "25 anos";
            // 
            // lblNomeUser
            // 
            this.lblNomeUser.AutoSize = true;
            this.lblNomeUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeUser.Location = new System.Drawing.Point(213, 113);
            this.lblNomeUser.Name = "lblNomeUser";
            this.lblNomeUser.Size = new System.Drawing.Size(128, 21);
            this.lblNomeUser.TabIndex = 10;
            this.lblNomeUser.Text = "Fulano Da Silva";
            // 
            // btnPlaylist
            // 
            this.btnPlaylist.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlaylist.BackgroundImage")));
            this.btnPlaylist.FlatAppearance.BorderSize = 0;
            this.btnPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaylist.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaylist.ForeColor = System.Drawing.Color.White;
            this.btnPlaylist.Image = ((System.Drawing.Image)(resources.GetObject("btnPlaylist.Image")));
            this.btnPlaylist.Location = new System.Drawing.Point(540, 137);
            this.btnPlaylist.Name = "btnPlaylist";
            this.btnPlaylist.Size = new System.Drawing.Size(252, 184);
            this.btnPlaylist.TabIndex = 17;
            this.btnPlaylist.Text = "Músicas Postadas";
            this.btnPlaylist.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPlaylist.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPlaylist.UseVisualStyleBackColor = true;
            this.btnPlaylist.Click += new System.EventHandler(this.btnPlaylist_Click);
            // 
            // picPerfil
            // 
            this.picPerfil.Image = ((System.Drawing.Image)(resources.GetObject("picPerfil.Image")));
            this.picPerfil.Location = new System.Drawing.Point(45, 102);
            this.picPerfil.Name = "picPerfil";
            this.picPerfil.Size = new System.Drawing.Size(162, 219);
            this.picPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPerfil.TabIndex = 11;
            this.picPerfil.TabStop = false;
            // 
            // dgvPlaylist
            // 
            this.dgvPlaylist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlaylist.Location = new System.Drawing.Point(540, 137);
            this.dgvPlaylist.Name = "dgvPlaylist";
            this.dgvPlaylist.Size = new System.Drawing.Size(252, 184);
            this.dgvPlaylist.TabIndex = 18;
            // 
            // ctrlPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPlaylist);
            this.Controls.Add(this.lblNomeUser2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblGosto);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.picPerfil);
            this.Controls.Add(this.lblNomeUser);
            this.Controls.Add(this.dgvPlaylist);
            this.Name = "ctrlPerfil";
            this.Size = new System.Drawing.Size(817, 423);
            this.VisibleChanged += new System.EventHandler(this.ctrlPerfil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPerfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaylist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlaylist;
        private System.Windows.Forms.Label lblNomeUser2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblGosto;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.PictureBox picPerfil;
        private System.Windows.Forms.Label lblNomeUser;
        private System.Windows.Forms.DataGridView dgvPlaylist;
    }
}
