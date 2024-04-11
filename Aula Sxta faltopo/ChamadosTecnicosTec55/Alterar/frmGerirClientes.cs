using ChamadosTecnicosTec55.Adicionar;
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
    public partial class frmGerirClientes : Form
    {
        string _conexao = ChamadosTecnicosTec55.Properties.Settings.Default.Conexao;
        public frmGerirClientes()
        {

            InitializeComponent();
        }
        //busca on DAO o cliente
        private void ListarCliente()
        {
            //chama o cliente DAO
            ClienteDao clienteDao = new ClienteDao(_conexao);
            // Captura o valor digitado na barra texto TXB
            string busca = txbPesquisar.Text.ToString();

            //chama o metodo BuscarCliente do objeto
            DataSet ds = new DataSet();
            ds = clienteDao.BuscaCliente(busca);

            //defini o DataSource do DataGridView
            dataGridCliente.DataSource = ds;

            //defini o membro do dataset
            dataGridCliente.DataMember = "Clientes";
        }


        private void btnIncluir_Click(object sender, EventArgs e)
        {
            var TelaCliente = new frmAdicionarCliente();
            
            TelaCliente.Show();
        }

        private void frmGerirClientes_Load(object sender, EventArgs e)
        {
            ListarCliente();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ListarCliente();
            txbPesquisar.Focus();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            dataGridCliente.Rows.RemoveAt(dataGridCliente.CurrentRow.Cells[0].RowIndex);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            // Verifique se alguma linha esta selecionada no DataGridView
            if(dataGridCliente.SelectedRows.Count > 0)
            {
                // obtem o codigo do cliente da linha selecionada
                int codigo = Convert.ToInt32(dataGridCliente.CurrentRow.Cells[0].Value);

                var Alterar = new frmAlternar(codigo);
                Alterar.ShowDialog();

                // apos a tela fechar listar os clientes cadastrados
                ListarCliente();
            }
            else
            {
                // Exibe uma mensagem de Aviso se Nenhuma Linha Estiver Selecionada
                MessageBox.Show("Escolhe Uma Linha Burro", "Tribufu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            };
        }
    }
}
