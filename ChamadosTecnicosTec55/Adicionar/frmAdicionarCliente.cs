using Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChamadosTecnicosTec55.Adicionar
{
    public partial class frmAdicionarCliente : Form
    {
        // Chamaaa a conexão 
        string _conexao = ChamadosTecnicosTec55.Properties.Settings.Default.Conexao;

        public frmAdicionarCliente()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbNome.Clear();
            txbObs.Clear();
            txbProfissao.Clear();
            txbSetor.Clear();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Chama o objeto Cliente
            Cliente cliente = new Cliente();
            ClienteDao clientedao = new ClienteDao(_conexao);

            if(string.IsNullOrWhiteSpace(txbNome.Text) || string.IsNullOrWhiteSpace(txbObs.Text) || string.IsNullOrWhiteSpace(txbProfissao.Text) || string.IsNullOrWhiteSpace(txbSetor.Text))
            {
                MessageBox.Show("CADE OS DADOSSS ??");
            }
        }
    }
}
