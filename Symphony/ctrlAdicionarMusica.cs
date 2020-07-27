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
    public partial class ctrlAdicionarMusica : UserControl
    {
        string image2b64;
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
        public ctrlAdicionarMusica()
        {
            InitializeComponent();
        }

        private void picMusica_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

            if (file.ShowDialog() == DialogResult.OK)
            {
                picMusica.ImageLocation = file.FileName;
            }

            byte[] ArImage = System.IO.File.ReadAllBytes(file.FileName);
            image2b64 = Convert.ToBase64String(ArImage);

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "INSERT INTO public.musicas " +
                        "(id_musica, nome, album, genero, ano_lançamento, imagem, id_usuario, link, nome_artista, qntd_likes, qntd_dislikes)" +
                        " VALUES(DEFAULT,@1,@2,@3,@4,@5,@6,@7,@8,0,0)";
                List<object> param = new List<object>();
                param.Add(txtNome.Text);
                param.Add(txtAlbum.Text);
                param.Add(Convert.ToString(cmbGenero.SelectedItem));
                param.Add(Convert.ToDecimal(mskData.Text));
                param.Add(image2b64);
                param.Add(id_usuario);
                param.Add(txtLink.Text);
                param.Add(txtArtista.Text);
                ConexaoBanco.Executar(sql, param);
                MessageBox.Show("Musica: " + txtNome.Text + " Cadastrada", "Symphony TM", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar musica" + ex.Message.ToString(), "Symphony TM", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            cmbGenero.SelectedIndex = -1;
            mskData.Text = "";
            txtAlbum.Text = "";
            txtLink.Text = "";

        }
    }
}

