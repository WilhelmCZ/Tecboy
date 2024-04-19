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

            ListarCliente();
        }

        private void frmGerirClientes_Load(object sender, EventArgs e)
        {
            ListarCliente();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(txbPesquisar.Text != string.Empty)
            {
                ListarCliente();
                //txbPesquisar.Text = String.Empty;
                txbPesquisar.Focus();
            }
            else
            {
                MessageBox.Show("Digite algo Para Pesquisar","Pesquisar",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
           //Botao excluir
           //selecionar data grid capturar ID, enviar para o DAO,excluir
           if(dataGridCliente.SelectedRows.Count > 0)
            {
                int codigo = Convert.ToInt32(dataGridCliente.CurrentRow.Cells[0].Value);

                var resultado = MessageBox.Show("Deseja Excluir?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if(resultado == DialogResult.Yes)
                {
                    ClienteDao clienteDao = new ClienteDao(_conexao);
                    clienteDao.ExcluirCliente(codigo);
                    ListarCliente();
                }
            }
           else
            {
                MessageBox.Show("Selecione um Registro !");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            // Verifique se alguma linha esta selecionada no DataGridView
            if(dataGridCliente.SelectedRows.Count > 0)
            {
                // obtem o codigo do cliente da linha selecionada
                int codigo = Convert.ToInt32(dataGridCliente.CurrentRow.Cells[0].Value);

                var Alterar = new frmAlternarCli(codigo);
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ListarCliente();
        }

        private void btnExcluirTD_Click(object sender, EventArgs e)
        {
           
                int codigo = Convert.ToInt32(dataGridCliente.CurrentRow.Cells[0].Value);

                var resultado = MessageBox.Show("Deseja Excluir?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (resultado == DialogResult.Yes)
                {
                    ClienteDao clienteDao = new ClienteDao(_conexao);
                    clienteDao.ExcluirTdCliente(codigo);
                    ListarCliente();
                }
                       
        }
    }
}
