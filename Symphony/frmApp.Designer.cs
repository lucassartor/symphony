namespace Symphony
{
    partial class frmApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmApp));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button14 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.btnMusicasSalvas = new System.Windows.Forms.Button();
            this.btnMusicas = new System.Windows.Forms.Button();
            this.btnAdicionarMusica = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCabecalho = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.ctrlPlaylist1 = new Symphony.ctrlPlaylist();
            this.ctrlUsuarios1 = new Symphony.ctrlUsuarios();
            this.ctrlMusicas1 = new Symphony.ctrlMusicas();
            this.ctrlAdicionarMusica1 = new Symphony.ctrlAdicionarMusica();
            this.ctrlHome1 = new Symphony.ctrlHome();
            this.ctrlPerfil1 = new Symphony.ctrlPerfil();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Symphony";
            // 
            // button14
            // 
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.Color.White;
            this.button14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button14.Location = new System.Drawing.Point(3, 546);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(36, 34);
            this.button14.TabIndex = 7;
            this.button14.Text = "?";
            this.button14.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button14.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(243, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(111, 143);
            this.panel3.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Symphony.Properties.Resources.logoPintada;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(13, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 92);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.SidePanel.Location = new System.Drawing.Point(1, 61);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 54);
            this.SidePanel.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.btnUsuarios);
            this.panel1.Controls.Add(this.btnPerfil);
            this.panel1.Controls.Add(this.btnMusicasSalvas);
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.btnMusicas);
            this.panel1.Controls.Add(this.button14);
            this.panel1.Controls.Add(this.btnAdicionarMusica);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 588);
            this.panel1.TabIndex = 5;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuarios.Image")));
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(12, 299);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(197, 54);
            this.btnUsuarios.TabIndex = 5;
            this.btnUsuarios.Text = "       Usuários";
            this.btnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnPerfil
            // 
            this.btnPerfil.FlatAppearance.BorderSize = 0;
            this.btnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerfil.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerfil.ForeColor = System.Drawing.Color.White;
            this.btnPerfil.Image = ((System.Drawing.Image)(resources.GetObject("btnPerfil.Image")));
            this.btnPerfil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPerfil.Location = new System.Drawing.Point(12, 359);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(197, 54);
            this.btnPerfil.TabIndex = 6;
            this.btnPerfil.Text = "       Perfil";
            this.btnPerfil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPerfil.UseVisualStyleBackColor = true;
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            // 
            // btnMusicasSalvas
            // 
            this.btnMusicasSalvas.FlatAppearance.BorderSize = 0;
            this.btnMusicasSalvas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusicasSalvas.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMusicasSalvas.ForeColor = System.Drawing.Color.White;
            this.btnMusicasSalvas.Image = ((System.Drawing.Image)(resources.GetObject("btnMusicasSalvas.Image")));
            this.btnMusicasSalvas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMusicasSalvas.Location = new System.Drawing.Point(12, 179);
            this.btnMusicasSalvas.Name = "btnMusicasSalvas";
            this.btnMusicasSalvas.Size = new System.Drawing.Size(197, 54);
            this.btnMusicasSalvas.TabIndex = 3;
            this.btnMusicasSalvas.Text = "       Músicas Salvas";
            this.btnMusicasSalvas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMusicasSalvas.UseVisualStyleBackColor = true;
            this.btnMusicasSalvas.Click += new System.EventHandler(this.btnMusicasSalvas_Click);
            // 
            // btnMusicas
            // 
            this.btnMusicas.FlatAppearance.BorderSize = 0;
            this.btnMusicas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusicas.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMusicas.ForeColor = System.Drawing.Color.White;
            this.btnMusicas.Image = ((System.Drawing.Image)(resources.GetObject("btnMusicas.Image")));
            this.btnMusicas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMusicas.Location = new System.Drawing.Point(12, 119);
            this.btnMusicas.Name = "btnMusicas";
            this.btnMusicas.Size = new System.Drawing.Size(197, 54);
            this.btnMusicas.TabIndex = 2;
            this.btnMusicas.Text = "       Músicas";
            this.btnMusicas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMusicas.UseVisualStyleBackColor = true;
            this.btnMusicas.Click += new System.EventHandler(this.btnMúsicas_Click);
            // 
            // btnAdicionarMusica
            // 
            this.btnAdicionarMusica.FlatAppearance.BorderSize = 0;
            this.btnAdicionarMusica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarMusica.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarMusica.ForeColor = System.Drawing.Color.White;
            this.btnAdicionarMusica.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionarMusica.Image")));
            this.btnAdicionarMusica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionarMusica.Location = new System.Drawing.Point(12, 239);
            this.btnAdicionarMusica.Name = "btnAdicionarMusica";
            this.btnAdicionarMusica.Size = new System.Drawing.Size(197, 54);
            this.btnAdicionarMusica.TabIndex = 4;
            this.btnAdicionarMusica.Text = "       + Músicas";
            this.btnAdicionarMusica.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdicionarMusica.UseVisualStyleBackColor = true;
            this.btnAdicionarMusica.Click += new System.EventHandler(this.btnAdicionarMusica_Click);
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(12, 59);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(197, 54);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "       Home";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1044, 10);
            this.panel2.TabIndex = 6;
            // 
            // lblCabecalho
            // 
            this.lblCabecalho.AutoSize = true;
            this.lblCabecalho.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCabecalho.ForeColor = System.Drawing.Color.Black;
            this.lblCabecalho.Location = new System.Drawing.Point(360, 22);
            this.lblCabecalho.Name = "lblCabecalho";
            this.lblCabecalho.Size = new System.Drawing.Size(153, 32);
            this.lblCabecalho.TabIndex = 18;
            this.lblCabecalho.Text = "Symphony";
            // 
            // btnFechar
            // 
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFechar.Location = new System.Drawing.Point(977, 19);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(32, 35);
            this.btnFechar.TabIndex = 8;
            this.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // ctrlPlaylist1
            // 
            this.ctrlPlaylist1.Id_Usuario = ((long)(0));
            this.ctrlPlaylist1.Location = new System.Drawing.Point(213, 149);
            this.ctrlPlaylist1.Name = "ctrlPlaylist1";
            this.ctrlPlaylist1.Size = new System.Drawing.Size(817, 423);
            this.ctrlPlaylist1.TabIndex = 22;
            // 
            // ctrlUsuarios1
            // 
            this.ctrlUsuarios1.Location = new System.Drawing.Point(221, 154);
            this.ctrlUsuarios1.Name = "ctrlUsuarios1";
            this.ctrlUsuarios1.Size = new System.Drawing.Size(817, 423);
            this.ctrlUsuarios1.TabIndex = 21;
            // 
            // ctrlMusicas1
            // 
            this.ctrlMusicas1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlMusicas1.Id_Usuario = ((long)(0));
            this.ctrlMusicas1.Location = new System.Drawing.Point(213, 146);
            this.ctrlMusicas1.Name = "ctrlMusicas1";
            this.ctrlMusicas1.Size = new System.Drawing.Size(817, 425);
            this.ctrlMusicas1.TabIndex = 20;
            // 
            // ctrlAdicionarMusica1
            // 
            this.ctrlAdicionarMusica1.Id_Usuario = ((long)(0));
            this.ctrlAdicionarMusica1.Location = new System.Drawing.Point(214, 149);
            this.ctrlAdicionarMusica1.Name = "ctrlAdicionarMusica1";
            this.ctrlAdicionarMusica1.Size = new System.Drawing.Size(817, 423);
            this.ctrlAdicionarMusica1.TabIndex = 16;
            // 
            // ctrlHome1
            // 
            this.ctrlHome1.Location = new System.Drawing.Point(214, 149);
            this.ctrlHome1.Name = "ctrlHome1";
            this.ctrlHome1.Size = new System.Drawing.Size(817, 423);
            this.ctrlHome1.TabIndex = 15;
            // 
            // ctrlPerfil1
            // 
            this.ctrlPerfil1.Id_Usuario = ((long)(0));
            this.ctrlPerfil1.Location = new System.Drawing.Point(215, 149);
            this.ctrlPerfil1.Name = "ctrlPerfil1";
            this.ctrlPerfil1.Size = new System.Drawing.Size(817, 423);
            this.ctrlPerfil1.TabIndex = 19;
            // 
            // frmApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 598);
            this.Controls.Add(this.ctrlPlaylist1);
            this.Controls.Add(this.ctrlUsuarios1);
            this.Controls.Add(this.ctrlMusicas1);
            this.Controls.Add(this.lblCabecalho);
            this.Controls.Add(this.ctrlAdicionarMusica1);
            this.Controls.Add(this.ctrlHome1);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ctrlPerfil1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmApp";
            this.Load += new System.EventHandler(this.frmApp_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button btnAdicionarMusica;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMusicas;
        private System.Windows.Forms.Panel panel2;
        private ctrlHome ctrlHome1;
        private ctrlAdicionarMusica ctrlAdicionarMusica1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.Button btnMusicasSalvas;
        private System.Windows.Forms.Label lblCabecalho;
        private ctrlPerfil ctrlPerfil1;
        private ctrlMusicas ctrlMusicas1;
        private System.Windows.Forms.Button btnUsuarios;
        private ctrlUsuarios ctrlUsuarios1;
        private ctrlPlaylist ctrlPlaylist1;
    }
}