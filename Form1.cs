using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_de_Funcionários
{
    public partial class frmCadastro : Form
    {
        List<Funcionario> funcionarios;

        public frmCadastro()
        {
            InitializeComponent();
            funcionarios = new List<Funcionario>();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario(
                funcionarios.Count + 1, 
                txtNome.Text,
                txtCPF.Text,
                new Endereco(
                    txtRua.Text,
                    txtNumero.Text,
                    txtComplemento.Text,
                    txtCEP.Text
                    )
                );

            funcionarios.Add(funcionario);
            cbxFuncionarios.Items.Add(funcionario.Nome);

            txtNome.Text = "";
            txtCPF.Text = "";
            txtRua.Text = "";
            txtNumero.Text = "";
            txtCEP.Text = "";

            MessageBox.Show("Funcionário Cadastrado!");
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            frmMaisInfo frmMaisInformacoes = new frmMaisInfo(funcionarios[cbxFuncionarios.SelectedIndex]);
            frmMaisInformacoes.ShowDialog();
        }
    }
}
