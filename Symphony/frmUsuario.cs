using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.IO;

namespace Symphony
{
    public partial class frmUsuario : Form
    {
        Int64 id_usuario;

        public frmUsuario(Int64 id_usu)
        {
            InitializeComponent();
            id_usuario = id_usu;
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM public.usuarios where id_usuario = @1";
            List<object> param = new List<object>();
            param.Add(id_usuario);
            NpgsqlDataReader dr = ConexaoBanco.Selecionar(sql, param);

            if (dr.Read())
            {
                lblNomeUser.Text = dr["nome"].ToString();
                lblNomeUser2.Text = dr["nome"].ToString();
                lblLogin.Text = dr["login"].ToString();




                lblGosto.Text = "Curte Música " + dr["genero"].ToString();
                lblIdade.Text = dr["idade"].ToString() + " Anos";

                byte[] bytes = Convert.FromBase64String(dr["imagem"].ToString());
                Image image;
                MemoryStream ms = new MemoryStream(bytes);
                image = Image.FromStream(ms);
                picPerfil.Image = image;
            }

            dr.Close();

            sql = "select nome,genero from public.musicas where id_usuario = " + id_usuario + "order by nome ";
            dgvPlaylist.DataSource = ConexaoBanco.SelecionarDataSet(sql).Tables[0];

            dgvPlaylist.DefaultCellStyle.Font = new Font("Century Gothic", 10);
            dgvPlaylist.BorderStyle = BorderStyle.None;
            dgvPlaylist.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dgvPlaylist.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPlaylist.DefaultCellStyle.SelectionBackColor = Color.FromArgb(178, 8, 55);
            dgvPlaylist.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvPlaylist.BackgroundColor = Color.FromArgb(240, 240, 240);

            dgvPlaylist.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 12);
            dgvPlaylist.EnableHeadersVisualStyles = false;
            dgvPlaylist.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvPlaylist.AutoResizeColumnHeadersHeight();
            dgvPlaylist.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 39, 40);
            dgvPlaylist.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            btnPlaylist.Hide();
        }
    }
 }
