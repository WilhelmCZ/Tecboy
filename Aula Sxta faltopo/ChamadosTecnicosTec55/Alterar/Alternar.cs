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
    public partial class frmAlternarCli : Form
    {
        string _conexao = ChamadosTecnicosTec55.Properties.Settings.Default.Conexao;
        public frmAlternarCli(int codigo)
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
                txbAltCodigo.Text = cliente.CodigoCliente.ToString();
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

        private void btnAltOk_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            ClienteDao clienteDao = new ClienteDao(_conexao);

            try
            {
                cliente.Nome = txbAltNome.Text;
                cliente.Profissao = txbAltProfissao.Text;
                cliente.Setor = txbAltSetor.Text;
                cliente.Obs = txbAltObs.Text;

                int codigo = Convert.ToInt32(txbAltCodigo.Text);

                cliente.CodigoCliente = codigo;

                clienteDao.AlterarCliente(cliente);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
