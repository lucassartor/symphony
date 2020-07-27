using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Symphony
{
    public partial class ctrlMusicas : UserControl
    {
        Int64 id_musica;
        private Int64 id_usuario;
        public Int64 Id_Usuario
        {
            get
            {
                return id_usuario;
            }
            set
            {
                id_usuario = value;
            }
        }
        public ctrlMusicas()
        {
            InitializeComponent();
        }

        private void ctrMusicas_Load(object sender, EventArgs e)
        {
            cmbGenero.Text = "Selecione um";
            txtPesquisa.Text = "";
            //string sql = "select(nome, genero, album, ano_lançamento, qntd_likes, qntd_dislikes, id_usuario, imagem) from public.musicas order by id_musica ";
            string sql = "select id_musica as ID, nome as Nome, nome_artista as Artista, album as Albúm, genero as Gênero, ano_lançamento as Ano, qntd_likes as Likes, qntd_dislikes as Dislikes from public.musicas order by id_musica ";
            dgvMusicas.DataSource = ConexaoBanco.SelecionarDataSet(sql).Tables[0];

            dgvMusicas.DefaultCellStyle.Font = new Font("Century Gothic", 10);
            dgvMusicas.BorderStyle = BorderStyle.None;
            dgvMusicas.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dgvMusicas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvMusicas.DefaultCellStyle.SelectionBackColor = Color.FromArgb(178, 8, 55);
            dgvMusicas.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvMusicas.BackgroundColor = Color.FromArgb(240, 240, 240);

            dgvMusicas.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 12);
            dgvMusicas.EnableHeadersVisualStyles = false;
            dgvMusicas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvMusicas.AutoResizeColumnHeadersHeight(); 
            dgvMusicas.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 39, 40);
            dgvMusicas.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        private void dgvMusicas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id_musica = Convert.ToInt64(dgvMusicas.Rows[dgvMusicas.CurrentRow.Index].Cells[0].Value);
            Form mus = new frmMusica(id_musica, id_usuario);
            this.Hide();
            mus.ShowDialog();
            this.Show();




        }


        private void cmbGenero_SelectedIndexChanged(object sender, EventArgs e)
        {
            string genero = cmbGenero.SelectedItem.ToString();
            string sql = "select id_musica as ID, nome as Nome, nome_artista as Artista, album as Albúm, genero as Gênero, ano_lançamento as Ano, qntd_likes as Likes, qntd_dislikes as Dislikes from public.musicas where genero like '%" + genero + "%' " ;
            dgvMusicas.DataSource = ConexaoBanco.SelecionarDataSet(sql).Tables[0];
        }


        private void txtPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                if(!String.IsNullOrWhiteSpace(txtPesquisa.Text))
                {
                    string pesquisa = txtPesquisa.Text;
                    string sql = "select id_musica as ID, nome as Nome, nome_artista as Artista, album as Albúm, genero as Gênero, ano_lançamento as Ano, qntd_likes as Likes, qntd_dislikes as Dislikes from public.musicas where nome like '%" + pesquisa + "%' or album like '%" + pesquisa + "%' or nome_artista like '%" + pesquisa + "%' ";
                    dgvMusicas.DataSource = ConexaoBanco.SelecionarDataSet(sql).Tables[0];
                }
            }
        }

        private void ctrlMusicas_Load(object sender, EventArgs e)
        {
            this.Hide();
            this.Show();
        }
    }
}
