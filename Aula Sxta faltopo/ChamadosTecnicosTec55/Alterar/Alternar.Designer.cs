namespace ChamadosTecnicosTec55.Alterar
{
    partial class frmAlternarCli
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbAltNome = new System.Windows.Forms.TextBox();
            this.txbAltProfissao = new System.Windows.Forms.TextBox();
            this.txbAltSetor = new System.Windows.Forms.TextBox();
            this.txbAltObs = new System.Windows.Forms.TextBox();
            this.btnAltOk = new System.Windows.Forms.Button();
            this.txbAltCodigo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alterar Dados Dos Clientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Profissao :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Setor :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Obs :";
            // 
            // txbAltNome
            // 
            this.txbAltNome.Location = new System.Drawing.Point(69, 88);
            this.txbAltNome.Name = "txbAltNome";
            this.txbAltNome.Size = new System.Drawing.Size(230, 20);
            this.txbAltNome.TabIndex = 5;
            // 
            // txbAltProfissao
            // 
            this.txbAltProfissao.Location = new System.Drawing.Point(69, 117);
            this.txbAltProfissao.Name = "txbAltProfissao";
            this.txbAltProfissao.Size = new System.Drawing.Size(230, 20);
            this.txbAltProfissao.TabIndex = 6;
            // 
            // txbAltSetor
            // 
            this.txbAltSetor.Location = new System.Drawing.Point(69, 145);
            this.txbAltSetor.Name = "txbAltSetor";
            this.txbAltSetor.Size = new System.Drawing.Size(230, 20);
            this.txbAltSetor.TabIndex = 7;
            // 
            // txbAltObs
            // 
            this.txbAltObs.Location = new System.Drawing.Point(25, 197);
            this.txbAltObs.Multiline = true;
            this.txbAltObs.Name = "txbAltObs";
            this.txbAltObs.Size = new System.Drawing.Size(274, 66);
            this.txbAltObs.TabIndex = 9;
            // 
            // btnAltOk
            // 
            this.btnAltOk.Location = new System.Drawing.Point(114, 292);
            this.btnAltOk.Name = "btnAltOk";
            this.btnAltOk.Size = new System.Drawing.Size(89, 49);
            this.btnAltOk.TabIndex = 11;
            this.btnAltOk.Text = "OK";
            this.btnAltOk.UseVisualStyleBackColor = true;
            this.btnAltOk.Click += new System.EventHandler(this.btnAltOk_Click);
            // 
            // txbAltCodigo
            // 
            this.txbAltCodigo.Location = new System.Drawing.Point(114, 41);
            this.txbAltCodigo.Name = "txbAltCodigo";
            this.txbAltCodigo.ReadOnly = true;
            this.txbAltCodigo.Size = new System.Drawing.Size(89, 20);
            this.txbAltCodigo.TabIndex = 10;
            this.txbAltCodigo.TextChanged += new System.EventHandler(this.txbAltCodigo_TextChanged);
            // 
            // frmAlternarCli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 353);
            this.Controls.Add(this.btnAltOk);
            this.Controls.Add(this.txbAltCodigo);
            this.Controls.Add(this.txbAltObs);
            this.Controls.Add(this.txbAltSetor);
            this.Controls.Add(this.txbAltProfissao);
            this.Controls.Add(this.txbAltNome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAlternarCli";
            this.Text = "AlternarCliente";
            this.Load += new System.EventHandler(this.Alternar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbAltNome;
        private System.Windows.Forms.TextBox txbAltProfissao;
        private System.Windows.Forms.TextBox txbAltSetor;
        private System.Windows.Forms.TextBox txbAltObs;
        private System.Windows.Forms.Button btnAltOk;
        private System.Windows.Forms.TextBox txbAltCodigo;
    }
}