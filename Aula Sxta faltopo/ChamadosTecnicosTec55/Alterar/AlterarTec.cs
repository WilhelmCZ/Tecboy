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
    public partial class AlterarTec : Form
    {
        string _conexao = ChamadosTecnicosTec55.Properties.Settings.Default.Conexao;
        public AlterarTec(int codigo)
        {
            InitializeComponent();
            //verifica se o codigo e maior que zero
            if (codigo > 0)
            {
                //cria uma instancia do objeto cliente
                Tecnico tecnico = new Tecnico();
                TecnicoDAO tecnicoDao = new TecnicoDAO(_conexao);

                tecnico = tecnicoDao.ObtemTecnico(codigo);

                //se o cliente nao foi encontrado
                if (tecnico == null)
                {
                    MessageBox.Show("Cliente Nao Encontrado", "Traquiossauros", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    this.Close();
                }
                txbAltCodigo.Text = tecnico.CodigoTecnico.ToString();
                txbAltNome.Text = tecnico.Nome;
                txbAltEspecialidade.Text = tecnico.Especialidade;
                txbAltSenha.Text = tecnico.Senha;
                txbAltEmail.Text = tecnico.Email;
                txbAltObs.Text = tecnico.Obs;

            }
        }

        private void AlterarTec_Load(object sender, EventArgs e)
        {

        }
        private void btnAltOk_Click_1(object sender, EventArgs e)
        {
            Tecnico tecnico = new Tecnico();
            TecnicoDAO tecnicoDao = new TecnicoDAO(_conexao);

            try
            {
                tecnico.Nome = txbAltNome.Text;
                tecnico.Especialidade = txbAltEspecialidade.Text;
                tecnico.Senha = txbAltSenha.Text;
                tecnico.Obs = txbAltObs.Text;
                tecnico.Email = txbAltEmail.Text;

                int codigo = Convert.ToInt32(txbAltCodigo.Text);

                tecnico.CodigoTecnico = codigo;

                tecnicoDao.AlterarTecnico(tecnico);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
