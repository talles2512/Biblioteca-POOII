namespace UNIP.POOII.BibliotecaPOOII
{
    partial class frmCadastroLivros
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCodigoLivro = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.rdoEmprestimo = new System.Windows.Forms.RadioButton();
            this.rdoConsultar = new System.Windows.Forms.RadioButton();
            this.dtdataentrada = new System.Windows.Forms.DateTimePicker();
            this.txtvalor = new System.Windows.Forms.MaskedTextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dpQuantidade = new System.Windows.Forms.NumericUpDown();
            this.btnConsultaLivros = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dpQuantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código Livro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Título:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ISBN:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data Entrada:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Quantidade:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(75, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Valor:";
            // 
            // txtCodigoLivro
            // 
            this.txtCodigoLivro.Location = new System.Drawing.Point(116, 23);
            this.txtCodigoLivro.Name = "txtCodigoLivro";
            this.txtCodigoLivro.Size = new System.Drawing.Size(244, 20);
            this.txtCodigoLivro.TabIndex = 7;
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(116, 75);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(286, 20);
            this.txtISBN.TabIndex = 8;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(116, 49);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(286, 20);
            this.txtTitulo.TabIndex = 9;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(334, 201);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // rdoEmprestimo
            // 
            this.rdoEmprestimo.AutoSize = true;
            this.rdoEmprestimo.Location = new System.Drawing.Point(118, 123);
            this.rdoEmprestimo.Name = "rdoEmprestimo";
            this.rdoEmprestimo.Size = new System.Drawing.Size(72, 17);
            this.rdoEmprestimo.TabIndex = 17;
            this.rdoEmprestimo.TabStop = true;
            this.rdoEmprestimo.Text = "Emprestar";
            this.rdoEmprestimo.UseVisualStyleBackColor = true;
            // 
            // rdoConsultar
            // 
            this.rdoConsultar.AutoSize = true;
            this.rdoConsultar.Location = new System.Drawing.Point(196, 123);
            this.rdoConsultar.Name = "rdoConsultar";
            this.rdoConsultar.Size = new System.Drawing.Size(69, 17);
            this.rdoConsultar.TabIndex = 18;
            this.rdoConsultar.TabStop = true;
            this.rdoConsultar.Text = "Consultar";
            this.rdoConsultar.UseVisualStyleBackColor = true;
            // 
            // dtdataentrada
            // 
            this.dtdataentrada.CustomFormat = "dd/MM/yyyy";
            this.dtdataentrada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtdataentrada.Location = new System.Drawing.Point(115, 205);
            this.dtdataentrada.Name = "dtdataentrada";
            this.dtdataentrada.Size = new System.Drawing.Size(100, 20);
            this.dtdataentrada.TabIndex = 19;
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(115, 179);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(100, 20);
            this.txtvalor.TabIndex = 20;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSalvar.Location = new System.Drawing.Point(221, 201);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(109, 23);
            this.btnSalvar.TabIndex = 21;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConsultaLivros);
            this.groupBox1.Controls.Add(this.dpQuantidade);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnSalvar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtdataentrada);
            this.groupBox1.Controls.Add(this.txtvalor);
            this.groupBox1.Controls.Add(this.txtCodigoLivro);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.rdoConsultar);
            this.groupBox1.Controls.Add(this.txtTitulo);
            this.groupBox1.Controls.Add(this.rdoEmprestimo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtISBN);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 237);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // dpQuantidade
            // 
            this.dpQuantidade.Location = new System.Drawing.Point(115, 153);
            this.dpQuantidade.Name = "dpQuantidade";
            this.dpQuantidade.Size = new System.Drawing.Size(100, 20);
            this.dpQuantidade.TabIndex = 22;
            // 
            // btnConsultaLivros
            // 
            this.btnConsultaLivros.Location = new System.Drawing.Point(366, 20);
            this.btnConsultaLivros.Name = "btnConsultaLivros";
            this.btnConsultaLivros.Size = new System.Drawing.Size(36, 23);
            this.btnConsultaLivros.TabIndex = 23;
            this.btnConsultaLivros.Text = "...";
            this.btnConsultaLivros.UseVisualStyleBackColor = true;
            this.btnConsultaLivros.Click += new System.EventHandler(this.BtnConsultaLivros_Click);
            // 
            // frmCadastroLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 264);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCadastroLivros";
            this.Text = "Cadastro de Livros";
            this.Load += new System.EventHandler(this.FrmCadastroLivros_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dpQuantidade)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCodigoLivro;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.RadioButton rdoEmprestimo;
        private System.Windows.Forms.RadioButton rdoConsultar;
        private System.Windows.Forms.DateTimePicker dtdataentrada;
        private System.Windows.Forms.MaskedTextBox txtvalor;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown dpQuantidade;
        private System.Windows.Forms.Button btnConsultaLivros;
    }
}