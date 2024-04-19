namespace ChamadosTecnicosTec55.Alterar
{
    partial class frmGerirTecnicos
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txbPesquisar = new System.Windows.Forms.TextBox();
            this.dataGridTecnico = new System.Windows.Forms.DataGridView();
            this.btnExcluirTD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTecnico)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(682, 55);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(24, 23);
            this.btnRefresh.TabIndex = 17;
            this.btnRefresh.Text = "R";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "Gerir Tecnico";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(514, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Pesquisar :";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(682, 88);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(101, 47);
            this.btnExcluir.TabIndex = 14;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(682, 154);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(101, 47);
            this.btnAlterar.TabIndex = 13;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click_1);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(682, 223);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(101, 47);
            this.btnIncluir.TabIndex = 12;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(682, 28);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(53, 21);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // txbPesquisar
            // 
            this.txbPesquisar.Location = new System.Drawing.Point(576, 29);
            this.txbPesquisar.Name = "txbPesquisar";
            this.txbPesquisar.Size = new System.Drawing.Size(100, 20);
            this.txbPesquisar.TabIndex = 10;
            this.txbPesquisar.TextChanged += new System.EventHandler(this.txbPesquisar_TextChanged);
            // 
            // dataGridTecnico
            // 
            this.dataGridTecnico.AllowUserToAddRows = false;
            this.dataGridTecnico.AllowUserToDeleteRows = false;
            this.dataGridTecnico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTecnico.Location = new System.Drawing.Point(22, 59);
            this.dataGridTecnico.Name = "dataGridTecnico";
            this.dataGridTecnico.ReadOnly = true;
            this.dataGridTecnico.Size = new System.Drawing.Size(637, 364);
            this.dataGridTecnico.TabIndex = 9;
            this.dataGridTecnico.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridTecnico_CellContentClick);
            // 
            // btnExcluirTD
            // 
            this.btnExcluirTD.Location = new System.Drawing.Point(682, 290);
            this.btnExcluirTD.Name = "btnExcluirTD";
            this.btnExcluirTD.Size = new System.Drawing.Size(101, 46);
            this.btnExcluirTD.TabIndex = 18;
            this.btnExcluirTD.Text = "Excluir Tudo";
            this.btnExcluirTD.UseVisualStyleBackColor = true;
            this.btnExcluirTD.Click += new System.EventHandler(this.btnExcluirTD_Click);
            // 
            // frmGerirTecnicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExcluirTD);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txbPesquisar);
            this.Controls.Add(this.dataGridTecnico);
            this.Name = "frmGerirTecnicos";
            this.Text = "GerirTecnicos";
            this.Load += new System.EventHandler(this.frmGerirTecnicos_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTecnico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txbPesquisar;
        private System.Windows.Forms.DataGridView dataGridTecnico;
        private System.Windows.Forms.Button btnExcluirTD;
    }
}