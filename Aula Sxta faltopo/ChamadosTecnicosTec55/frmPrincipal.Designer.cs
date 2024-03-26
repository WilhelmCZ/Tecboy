namespace ChamadosTecnicosTec55
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.técnicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestorDeChamadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestorDeVendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharSoluçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.gestorDeChamadosToolStripMenuItem,
            this.gestorDeVendasToolStripMenuItem,
            this.calculadoraToolStripMenuItem,
            this.documentaçãoToolStripMenuItem,
            this.sobreToolStripMenuItem,
            this.fecharSoluçãoToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.técnicoToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // técnicoToolStripMenuItem
            // 
            this.técnicoToolStripMenuItem.Name = "técnicoToolStripMenuItem";
            this.técnicoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.técnicoToolStripMenuItem.Text = "Técnico";
            // 
            // gestorDeChamadosToolStripMenuItem
            // 
            this.gestorDeChamadosToolStripMenuItem.Name = "gestorDeChamadosToolStripMenuItem";
            this.gestorDeChamadosToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            this.gestorDeChamadosToolStripMenuItem.Text = "Gestor de Chamados";
            // 
            // gestorDeVendasToolStripMenuItem
            // 
            this.gestorDeVendasToolStripMenuItem.Name = "gestorDeVendasToolStripMenuItem";
            this.gestorDeVendasToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.gestorDeVendasToolStripMenuItem.Text = "Gestor de Vendas";
            // 
            // calculadoraToolStripMenuItem
            // 
            this.calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            this.calculadoraToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.calculadoraToolStripMenuItem.Text = "Calculadora";
            this.calculadoraToolStripMenuItem.Click += new System.EventHandler(this.calculadoraToolStripMenuItem_Click);
            // 
            // documentaçãoToolStripMenuItem
            // 
            this.documentaçãoToolStripMenuItem.Name = "documentaçãoToolStripMenuItem";
            this.documentaçãoToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.documentaçãoToolStripMenuItem.Text = "Documentação";
            this.documentaçãoToolStripMenuItem.Click += new System.EventHandler(this.documentaçãoToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // fecharSoluçãoToolStripMenuItem
            // 
            this.fecharSoluçãoToolStripMenuItem.Name = "fecharSoluçãoToolStripMenuItem";
            this.fecharSoluçãoToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.fecharSoluçãoToolStripMenuItem.Text = "Fechar Solução";
            this.fecharSoluçãoToolStripMenuItem.Click += new System.EventHandler(this.fecharSoluçãoToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Chamados";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem técnicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestorDeChamadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestorDeVendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculadoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharSoluçãoToolStripMenuItem;
    }
}