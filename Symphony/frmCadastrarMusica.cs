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
    public partial class frmCadastrarMusica : Form
    {
        string image2b64;
        public frmCadastrarMusica()
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
                
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSobrenome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void cmbGenero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
