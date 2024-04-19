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
    public partial class frmGerirTecnicos : Form
    {
        string _conexao = ChamadosTecnicosTec55.Properties.Settings.Default.Conexao;
        public frmGerirTecnicos()
        {
            InitializeComponent();
        }
        //busca on DAO do Tecnico
        private void ListarTecnico()
        {
            //chama o cliente DAO
            TecnicoDAO tecnicoDao = new TecnicoDAO(_conexao);
            // Captura o valor digitado na barra texto TXB
            string busca = txbPesquisar.Text.ToString();

            //chama o metodo BuscaTecnico do objeto
            DataSet ds = new DataSet();
            ds = tecnicoDao.BuscaTecnico(busca);

            //defini o DataSource do DataGridView
            dataGridTecnico.DataSource = ds;

            //defini o membro do dataset
            dataGridTecnico.DataMember = "Tecnicos";
        }
        private void btnIncluir_Click(object sender, EventArgs e)
        {
            var TelaTecnico = new frmTecnicoAdicionar();

            TelaTecnico.Show();
            ListarTecnico();
        }
        private void frmGerirTecnicos_Load_1(object sender, EventArgs e)
        {
            ListarTecnico();
        }
        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            if (txbPesquisar.Text != string.Empty)
            {
                ListarTecnico();
                //txbPesquisar.Text = String.Empty;
                txbPesquisar.Focus();
            }
            else
            {
                MessageBox.Show("Digite algo Para Pesquisar", "Pesquisar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //Botao excluir
            //selecionar data grid capturar ID, enviar para o DAO,excluir
            if (dataGridTecnico.SelectedRows.Count > 0)
            {
                int codigo = Convert.ToInt32(dataGridTecnico.CurrentRow.Cells[0].Value);

                var resultado = MessageBox.Show("Deseja Excluir?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (resultado == DialogResult.Yes)
                {
                    TecnicoDAO tecnicoDao = new TecnicoDAO(_conexao);
                    tecnicoDao.ExcluirTecnico(codigo);
                    ListarTecnico();
                }
            }
            else
            {
                MessageBox.Show("Selecione um Registro !");
            }
        }
        private void btnAlterar_Click_1(object sender, EventArgs e)
        {
            // Verifique se alguma linha esta selecionada no DataGridView
            if (dataGridTecnico.SelectedRows.Count > 0)
            {
                // obtem o codigo do Tecnico da linha selecionada
                int codigo = Convert.ToInt32(dataGridTecnico.CurrentRow.Cells[0].Value);

                var Alterar = new AlterarTec(codigo);
                Alterar.ShowDialog();

                // apos a tela fechar listar os Tecnico cadastrados
                ListarTecnico();
            }
            else
            {
                // Exibe uma mensagem de Aviso se Nenhuma Linha Estiver Selecionada
                MessageBox.Show("Escolhe Uma Linha Burro", "Tribufu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            };
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ListarTecnico();
        }

        private void dataGridTecnico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txbPesquisar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExcluirTD_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(dataGridTecnico.CurrentRow.Cells[0].Value);

            var resultado = MessageBox.Show("Deseja Excluir?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (resultado == DialogResult.Yes)
            {
                TecnicoDAO TecnicoDao = new TecnicoDAO(_conexao);
                TecnicoDao.ExcluirTdTecnico(codigo);
                ListarTecnico();
            }
        }
    }
}
