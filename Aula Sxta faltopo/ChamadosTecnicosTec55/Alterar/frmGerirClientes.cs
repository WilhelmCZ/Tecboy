using ChamadosTecnicosTec55.Adicionar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChamadosTecnicosTec55.Alterar
{
    public partial class frmGerirClientes : Form
    {
        public frmGerirClientes()
        {
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            var TelaCliente = new frmAdicionarCliente();
            TelaCliente.MdiParent = this;
            TelaCliente.Show();
        }
    }
}
