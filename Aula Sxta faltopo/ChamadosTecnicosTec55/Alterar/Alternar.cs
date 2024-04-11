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

namespace ChamadosTecnicosTec55.Alterar
{
    public partial class frmAlternar : Form
    {
        string _conexao = ChamadosTecnicosTec55.Properties.Settings.Default.Conexao;
        public frmAlternar(int codigo)
        {
            InitializeComponent();
            //verifica se o codigo e maior que zero
            if(codigo > 0)
            {
                //cria uma instancia do objeto cliente
                Cliente cliente = new Cliente();
                ClienteDao clientedao = new ClienteDao(_conexao);

                cliente = clientedao.ObtemCliente(codigo);

                //se o cliente nao foi encontrado
                if(cliente == null )
                {
                    MessageBox.Show("Cliente Nao Encontrado", "Traquiossauros", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    this.Close();
                }
                txbAltCodigo.Text = cliente.ToString();
                txbAltNome.Text = cliente.Nome;
                txbAltProfissao.Text = cliente.Profissao;
                txbAltSetor.Text = cliente.Setor;
                txbAltObs.Text = cliente.Obs;

            }
        }

        private void Alternar_Load(object sender, EventArgs e)
        {

        }

        private void txbAltCodigo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
