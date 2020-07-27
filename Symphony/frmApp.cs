using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Symphony
{
    public partial class frmApp : Form
    {
        Int64 id_usuario;
        public frmApp(Int64 id_usu)
        {
            InitializeComponent();
            SidePanel.Height = btnHome.Height;
            SidePanel.Top = btnHome.Top;
            id_usuario = id_usu;
        }

        private void frmApp_Load(object sender, EventArgs e)
        {
            SidePanel.Height = btnHome.Height;
            SidePanel.Top = btnHome.Top;
            lblCabecalho.Text = Convert.ToString("Home");
            this.ctrlMusicas1.Id_Usuario = id_usuario;
            this.ctrlPerfil1.Id_Usuario = id_usuario;
            this.ctrlAdicionarMusica1.Id_Usuario = id_usuario;
            this.ctrlPlaylist1.Id_Usuario = id_usuario;
            
            this.ctrlHome1.Show();
            this.ctrlAdicionarMusica1.Hide();
            this.ctrlPerfil1.Hide();
            this.ctrlMusicas1.Hide();
            this.ctrlUsuarios1.Hide();
            this.ctrlPlaylist1.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnHome.Height;
            SidePanel.Top = btnHome.Top;
            lblCabecalho.Text = Convert.ToString("Home");
            this.ctrlAdicionarMusica1.Hide();
            this.ctrlPerfil1.Hide();
            this.ctrlHome1.Show();
            this.ctrlMusicas1.Hide();
            this.ctrlUsuarios1.Hide();
            this.ctrlPlaylist1.Hide();
        }

        private void btnAdicionarMusica_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnAdicionarMusica.Height;
            SidePanel.Top = btnAdicionarMusica.Top;
            lblCabecalho.Text = Convert.ToString("Cadastro de Músicas");
            this.ctrlHome1.Hide();
            this.ctrlPerfil1.Hide();
            this.ctrlAdicionarMusica1.Show();
            this.ctrlMusicas1.Hide();
            this.ctrlUsuarios1.Hide();
            this.ctrlPlaylist1.Hide();

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnPerfil.Height;
            SidePanel.Top = btnPerfil.Top;
            lblCabecalho.Text = Convert.ToString("Perfil");
            this.ctrlHome1.Hide();
            this.ctrlAdicionarMusica1.Hide();
            this.ctrlPerfil1.Show();
            this.ctrlMusicas1.Hide();
            this.ctrlUsuarios1.Hide();
            this.ctrlPlaylist1.Hide();
        }

        private void btnMúsicas_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnMusicas.Height;
            SidePanel.Top = btnMusicas.Top;
            lblCabecalho.Text = Convert.ToString("Músicas");
            this.ctrlHome1.Hide();
            this.ctrlAdicionarMusica1.Hide();
            this.ctrlPerfil1.Hide();
            this.ctrlMusicas1.Show();
            this.ctrlUsuarios1.Hide();
            this.ctrlPlaylist1.Hide();
        }

        private void btnMusicasSalvas_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnMusicasSalvas.Height;
            SidePanel.Top = btnMusicasSalvas.Top;
            lblCabecalho.Text = Convert.ToString("Suas Músicas Salvas");
            this.ctrlHome1.Hide();
            this.ctrlAdicionarMusica1.Hide();
            this.ctrlPerfil1.Hide();
            this.ctrlMusicas1.Hide();
            this.ctrlUsuarios1.Hide();
            this.ctrlPlaylist1.Show();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnUsuarios.Height;
            SidePanel.Top = btnUsuarios.Top;
            lblCabecalho.Text = Convert.ToString("Todos os usuários cadastrados");
            this.ctrlHome1.Hide();
            this.ctrlAdicionarMusica1.Hide();
            this.ctrlPerfil1.Hide();
            this.ctrlMusicas1.Hide();
            this.ctrlUsuarios1.Show();
            this.ctrlPlaylist1.Hide();
        }
    }
}
