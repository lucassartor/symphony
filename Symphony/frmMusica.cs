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
    public partial class frmMusica : Form
    {
        Int64 id_musica, id_usuario;
        bool like = false, dislike = false, javotou = false;
        Int64 qntdLikes, qntdDislikes;
        public frmMusica(Int64 id_mus, Int64 id_usu)
        {
            InitializeComponent();
            id_musica = id_mus;
            id_usuario = id_usu;
        }

        private void frmMusica_FormClosing(object sender, FormClosingEventArgs e)
        {
            string sql;
            List<object> param;
            if (like)
            {
                qntdLikes++;
                InserirVotos(like);
            }
            else if (dislike)
            {
                qntdDislikes++;
                InserirVotos(!dislike);
            }
            else
            {
                sql = "UPDATE public.votos SET voto = null WHERE id_usuario = @1 and id_musica = @2";
                param = new List<object>();
                param.Add(id_usuario);
                param.Add(id_musica);
                ConexaoBanco.Executar(sql, param);
            }

            sql = "UPDATE public.musicas SET qntd_likes = @1, qntd_dislikes = @2 where id_musica = @3 ";
            param = new List<object>();
            param.Add(qntdLikes);
            param.Add(qntdDislikes);
            param.Add(id_musica);
            ConexaoBanco.Executar(sql, param);

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void picLike_Click(object sender, EventArgs e)
        {
            if (like)
                picLike.ImageLocation = "C:\\Users\\Usuario\\Desktop\\SymphonyLucas17;11\\likebranco.png";
            else
                picLike.ImageLocation = "C:\\Users\\Usuario\\Desktop\\SymphonyLucas17;11\\likeverde.png";

            picDislike.ImageLocation = "C:\\Users\\Usuario\\Desktop\\SymphonyLucas17;11\\dislikebranco.png";
            like = !like;
            dislike = false;

        }

        private void picDislike_Click(object sender, EventArgs e)
        {
            if (dislike)
                picDislike.ImageLocation = "C:\\Users\\Usuario\\Desktop\\SymphonyLucas17;11\\dislikebranco.png";
            else
                picDislike.ImageLocation = "C:\\Users\\Usuario\\Desktop\\SymphonyLucas17;11\\dislikevermelho.png";
            picLike.ImageLocation = "C:\\Users\\Usuario\\Desktop\\SymphonyLucas17;11\\likebranco.png";

            dislike = !dislike;
            like = false;
        }

        private void frmMusica_Load(object sender, EventArgs e)
        {
            string sql = "select * from public.musicas where id_musica = @1";
            List<object> param = new List<object>();
            param.Add(id_musica);
            NpgsqlDataReader dr = ConexaoBanco.Selecionar(sql, param);
            dr.Read();
            lblAlbum.Text = dr["album"].ToString();
            lblData.Text = dr["ano_lançamento"].ToString();
            lblDislike.Text = dr["qntd_dislikes"].ToString();
            lblLike.Text = dr["qntd_likes"].ToString();
            lblGenero.Text = dr["genero"].ToString();
            lblNome.Text = dr["nome"].ToString();
            lblArtista.Text = dr["nome_artista"].ToString();
            qntdLikes = Convert.ToInt64(dr["qntd_likes"]);
            qntdDislikes = Convert.ToInt64(dr["qntd_dislikes"]);
            lblLike.Text = qntdLikes.ToString();
            lblDislike.Text = qntdDislikes.ToString();


            byte[] bytes = Convert.FromBase64String(dr["imagem"].ToString());
            Image image;
            MemoryStream ms = new MemoryStream(bytes);
            image = Image.FromStream(ms);
            picMusica.Image = image;
            string link = dr["link"].ToString();
            if (link.IndexOf("watch?") >= 0)
            {
                link = link.Replace("watch?", "");
                link = link.Replace("=", "/");
                //link = link + "&autoplay=1";
            }

            sfoVideo.Movie = link;


            dr.Close();

            sql = "select * from public.votos where id_usuario = @1 and id_musica = @2";
            param = new List<object>();
            param.Add(id_usuario);
            param.Add(id_musica);
            dr = ConexaoBanco.Selecionar(sql, param);
            if (dr.Read())
            {
                try
                {
                    javotou = true;
                    bool voto = Convert.ToBoolean(dr["voto"]);
                    like = voto;
                    dislike = !voto;

                    if (like)
                    {
                        picLike.ImageLocation = "C:\\Users\\Usuario\\Desktop\\SymphonyLucas17;11\\likeverde.png";
                        qntdLikes--;
                    }
                    else if (dislike)
                    {
                        picDislike.ImageLocation = "C:\\Users\\Usuario\\Desktop\\SymphonyLucas17;11\\dislikevermelho.png";
                        qntdDislikes--;
                    }
                }
                catch (Exception)
                {

                    picLike.ImageLocation = "C:\\Users\\Usuario\\Desktop\\SymphonyLucas17;11\\likebranco.png";
                    picDislike.ImageLocation = "C:\\Users\\Usuario\\Desktop\\SymphonyLucas17;11\\dislikebranco.png";
                }
            }
            dr.Close();
        }
        private void InserirVotos(bool disoulike)
        {
            string sql;
            List<object> param;
            if (javotou)
                sql = "UPDATE public.votos SET voto = @3 WHERE id_usuario = @1 and id_musica = @2";
            else
                sql = "INSERT INTO public.votos VALUES(DEFAULT,@1,@2,@3)";
            try
            {
                param = new List<object>();
                param.Add(id_usuario);
                param.Add(id_musica);
                param.Add(disoulike);
                ConexaoBanco.Executar(sql, param);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir votos" + ex.Message.ToString(), "Symphony TM", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }





        }
    }
}
