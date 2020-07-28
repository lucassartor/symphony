using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Symphony
{
    public partial class ctrlPlaylist : UserControl
    {
        private List<Int64> votos = new List<Int64>();
        private Int64 id_usuario;
        private Int64 id_musica;
        string sql_pesquisa;
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
        public ctrlPlaylist()
        {
            InitializeComponent();
        }

        private void dgvMusicas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id_musica = Convert.ToInt64(dgvMusicas.Rows[dgvMusicas.CurrentRow.Index].Cells[0].Value);
            Form mus = new frmMusica(id_musica, id_usuario);
            this.Hide();
            mus.ShowDialog();
            this.Show();
        }

        private void ctrlMusicas_VisibleChanged(object sender, EventArgs e)
        {
            cmbGenero.Text = "Selecione um";
            txtPesquisa.Text = "";
            lblPlaylist.Hide();
            dgvMusicas.Show();
            string sql = "select * from public.votos where id_usuario = @1 and voto = true";
            List<object> param = new List<object>();
            param.Add(id_usuario);
            NpgsqlDataReader dr = ConexaoBanco.Selecionar(sql, param);

            while (dr.Read())
            {
                votos.Add(Convert.ToInt64(dr["id_musica"]));
            }
            dr.Close();
            if (votos.Count <= 0)
            {
                dgvMusicas.Hide();
                lblPlaylist.Show();

            }
            else
            {
                sql = "select id_musica as ID, nome as Nome, nome_artista as Artista, album as Albúm, genero as Gênero, ano_lançamento as Ano, qntd_likes as Likes, qntd_dislikes as Dislikes from public.musicas where (id_musica = " + votos[0].ToString();
                for (int i = 1; i < votos.Count; i++)
                {
                    sql += " or id_musica = " + votos[i].ToString();
                }

                sql = sql + ")";
                sql_pesquisa = sql;

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

            votos.Clear();

        }

        private void cmbGenero_SelectedIndexChanged(object sender, EventArgs e)
        {
            string genero = cmbGenero.SelectedItem.ToString();
            string sql_backup = sql_pesquisa; 
            sql_pesquisa = sql_pesquisa + "and genero like '%" + genero + "%'";  
            dgvMusicas.DataSource = ConexaoBanco.SelecionarDataSet(sql_pesquisa).Tables[0];
            sql_pesquisa = sql_backup;
        }


        private void txtPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (!String.IsNullOrWhiteSpace(txtPesquisa.Text))
                {
                    string pesquisa = txtPesquisa.Text;
                    string sql = "select id_musica as ID, nome as Nome, nome_artista as Artista, album as Albúm, genero as Gênero, data_lançamento as Ano from public.musicas where nome like '%" + pesquisa + "%' or album like '%" + pesquisa + "%' or nome_artista like '%" + pesquisa + "%' ";
                    dgvMusicas.DataSource = ConexaoBanco.SelecionarDataSet(sql).Tables[0];
                }
            }
        }

      
    }


}

