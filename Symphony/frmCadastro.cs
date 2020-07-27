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
    public partial class frmCadastro : Form
    {

        public frmCadastro()
        {
            InitializeComponent();
        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {
            

        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if(cmbGenero.SelectedIndex!=-1)
            { 
                try
                {
                    string sql = "SELECT login FROM public.usuarios WHERE login=@1";
                    List<object> param = new List<object>();
                    param.Add(txtLogin.Text);
                    NpgsqlDataReader dr = ConexaoBanco.Selecionar(sql, param);
                    if (dr.Read())
                    {
                        MessageBox.Show("Login já existente", "Symphony", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtLogin.Focus();
                        dr.Close();
                    }
                    else
                    {
                        dr.Close();
                        sql = "INSERT INTO public.usuarios " +
                            "(id_usuario, login, nome, sexo, senha, idade, id_genero)" +
                            " VALUES(DEFAULT,@1,@2,@3,@4,@5,@6)";
                        string sexo;
                        if (radFeminino.Checked == true)
                            sexo = "Feminino";
                        else
                            sexo = "Masculino";
                        List<object> param2 = new List<object>();
                        param2.Add(txtLogin.Text);
                        param2.Add(txtNome.Text);
                        param2.Add(sexo);
                        param2.Add(txtSenha.Text);
                        param2.Add(numIdade.Value);
                        param2.Add(Convert.ToInt64(cmbGenero.SelectedIndex + 1));
                        ConexaoBanco.Executar(sql, param2);
                        this.Close();

                    }
                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro" + ex.Message, "Symphony",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    

                }
                    
            }
            else
            { 
                MessageBox.Show("Selecione um genero musical", "Symphony",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                cmbGenero.Focus();
            }



        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtLogin.Text = "";
            txtNome.Text = "";
            txtSenha.Text = "";
            txtSobrenome.Text = "";
            cmbGenero.SelectedIndex = -1;
            cmbGenero.Text = "Selecione um";
            numIdade.Value = 0;
            radFeminino.Checked = true;
        }
    }
}
