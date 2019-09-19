namespace UNIP.POOII.BibliotecaPOOII
{
    partial class frmCadastroAutores
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnConsultaAutores = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dtData = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomeAutor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFechar);
            this.groupBox1.Controls.Add(this.btnConsultaAutores);
            this.groupBox1.Controls.Add(this.btnSalvar);
            this.groupBox1.Controls.Add(this.dtData);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNomeAutor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 112);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados";
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(426, 78);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 2;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnConsultaAutores
            // 
            this.btnConsultaAutores.Location = new System.Drawing.Point(211, 19);
            this.btnConsultaAutores.Name = "btnConsultaAutores";
            this.btnConsultaAutores.Size = new System.Drawing.Size(36, 23);
            this.btnConsultaAutores.TabIndex = 6;
            this.btnConsultaAutores.Text = "...";
            this.btnConsultaAutores.UseVisualStyleBackColor = true;
            this.btnConsultaAutores.Click += new System.EventHandler(this.btnConsultaAutores_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSalvar.Location = new System.Drawing.Point(311, 78);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(109, 23);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // dtData
            // 
            this.dtData.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.dtData.CustomFormat = "dd/MM/yyyy";
            this.dtData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtData.Location = new System.Drawing.Point(96, 71);
            this.dtData.Name = "dtData";
            this.dtData.Size = new System.Drawing.Size(109, 20);
            this.dtData.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data:";
            // 
            // txtNomeAutor
            // 
            this.txtNomeAutor.Location = new System.Drawing.Point(96, 45);
            this.txtNomeAutor.Name = "txtNomeAutor";
            this.txtNomeAutor.Size = new System.Drawing.Size(405, 20);
            this.txtNomeAutor.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(96, 19);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(109, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // frmCadastroAutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 134);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCadastroAutores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Autores";
            this.Load += new System.EventHandler(this.frmCadastroAutores_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomeAutor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnConsultaAutores;
    }
}