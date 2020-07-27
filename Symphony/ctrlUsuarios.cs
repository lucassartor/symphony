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
    public partial class ctrlUsuarios : UserControl
    {
        Int64 id_usuario;
        public ctrlUsuarios()
        {
            InitializeComponent();
        }

        private void ctrlUsuarios_Load(object sender, EventArgs e)
        {
            cmbGenero.Text = "Selecione um";
            txtPesquisa.Text = "";

            //string sql = "select(nome, genero, album, data_lançamento, qntd_likes, qntd_dislikes, id_usuario, imagem) from public.musicas order by nome ";
            string sql = "select id_usuario as ID, nome as Nome, idade as Idade, genero as Gênero from public.usuarios order by nome ";
            dgvUsuarios.DataSource = ConexaoBanco.SelecionarDataSet(sql).Tables[0];

            dgvUsuarios.DefaultCellStyle.Font = new Font("Century Gothic", 10);
            dgvUsuarios.BorderStyle = BorderStyle.None;
            dgvUsuarios.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dgvUsuarios.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvUsuarios.DefaultCellStyle.SelectionBackColor = Color.FromArgb(178, 8, 55);
            dgvUsuarios.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvUsuarios.BackgroundColor = Color.FromArgb(240, 240, 240);

            dgvUsuarios.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 12);
            dgvUsuarios.EnableHeadersVisualStyles = false;
            dgvUsuarios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvUsuarios.AutoResizeColumnHeadersHeight();
            dgvUsuarios.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 39, 40);
            dgvUsuarios.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        private void dgvUsuarios_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id_usuario = Convert.ToInt64(dgvUsuarios.Rows[dgvUsuarios.CurrentRow.Index].Cells[0].Value);
            Form mus = new frmUsuario(id_usuario);
            mus.Show();

        }

        private void cmbGenero_SelectedIndexChanged(object sender, EventArgs e)
        {
            string genero = cmbGenero.SelectedItem.ToString();
            string sql = "select id_usuario as ID, nome as Nome, idade as Idade, genero as Gênero from public.usuarios where genero like '%" + genero + "%' ";
            dgvUsuarios.DataSource = ConexaoBanco.SelecionarDataSet(sql).Tables[0];
        }


        private void txtPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (!String.IsNullOrWhiteSpace(txtPesquisa.Text))
                {
                    string pesquisa = txtPesquisa.Text;
                    string sql = "select id_usuario as ID, nome as Nome, idade as Idade, genero as Gênero from public.usuarios where nome like '%" + pesquisa + "%' ";
                    dgvUsuarios.DataSource = ConexaoBanco.SelecionarDataSet(sql).Tables[0];
                }
            }
        }

    }
}
