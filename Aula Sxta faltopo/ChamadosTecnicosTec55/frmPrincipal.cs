using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChamadosTecnicosTec55
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void fecharSoluçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var msgBox = MessageBox.Show("Quer mesmo Fechar?", "Sistema de Chamados", MessageBoxButtons.YesNo);
                
            if (msgBox == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void documentaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = @"https://vito-ismael.github.io/projeto-android/",
                UseShellExecute = true,

            });
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("calc");
        }
    }
}
