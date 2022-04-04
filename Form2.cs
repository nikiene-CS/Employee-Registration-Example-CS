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
    public partial class frmMaisInfo : Form
    {
        public Funcionario Funcionario { get; private set; }

        public frmMaisInfo(Funcionario funcionario)
        {
            InitializeComponent();
            lblNome.Text = funcionario.Nome;
        }

        private void frmMaisInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
