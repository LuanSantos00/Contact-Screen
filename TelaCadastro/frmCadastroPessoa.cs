using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelaCadastro
{
    public partial class frmCadastroPessoa : Form
    {
        public frmCadastroPessoa()
        {
            InitializeComponent();
        }

        //Evento Click do Botão
        private void btnAdicionarPessoa_Click(object sender, EventArgs e)
        {
            if (!verificarCampos())
            {
                MessageBox.Show("Informe todos os dados!");
            }
            else
            {
                string stNome = txtNome.Text;
                int itIdade = int.Parse(txtIdade.Text);
                string stProfissao = cmbProfissao.SelectedItem.ToString();
                lstPessoas.Items.Add(string.Format("{0} {1} {2}", stNome, itIdade, stProfissao));
                MessageBox.Show("Cadastro realizado com sucesso!");
                limparCampos();

            }

        }

        private void limparCampos()
        {
            txtNome.Text = string.Empty;
            txtIdade.Text = string.Empty;
            cmbProfissao.Text = string.Empty;
        }

        private bool verificarCampos()
        {
            return !string.IsNullOrEmpty(txtNome.Text.ToString()) &&
            !string.IsNullOrEmpty(txtIdade.Text) &&
            !string.IsNullOrEmpty(cmbProfissao.Text);
            
        }
    }
       
    
}
