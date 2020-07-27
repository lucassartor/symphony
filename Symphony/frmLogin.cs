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

namespace Symphony
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string sql = "select id_usuario from public.usuarios where login = @1 and senha = @2";
            List<object> param = new List<object>();
            param.Add(txtLogin.Text);
            param.Add(txtSenha.Text);
            NpgsqlDataReader dr = ConexaoBanco.Selecionar(sql, param);
            if (dr.Read())
            {
                Int64 id = Convert.ToInt64(dr["id_usuario"]);
                dr.Close();
                Form app = new frmApp(id);
                app.Show();

                /*  txtNome_Animal.Text = dr["nome"].ToString();
                  txtRaça_Animal.Text = dr["raca"].ToString();
                  mskDataNasc_Animal.Text = dr["data_nascimento"].ToString();
                  numValor_Animal.Value = Convert.ToDecimal(dr["valor"]);
                  cmbProprietario.SelectedValue = Convert.ToInt64(dr["id_proprietario"]);*/
            }
            else
            {
                MessageBox.Show("Usuario ou senha incorretos", "Symphony TM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dr.Close();
            }

        }

        private void lnkCadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form form = new frmCadastroUsuario();
            form.ShowDialog();
            
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
