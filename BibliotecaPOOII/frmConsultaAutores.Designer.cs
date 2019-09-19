namespace UNIP.POOII.BibliotecaPOOII
{
    partial class frmConsultaAutores
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
            this.dgTodosAutores = new System.Windows.Forms.DataGridView();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcodautor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgTodosAutores)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgTodosAutores
            // 
            this.dgTodosAutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTodosAutores.Location = new System.Drawing.Point(6, 61);
            this.dgTodosAutores.Name = "dgTodosAutores";
            this.dgTodosAutores.Size = new System.Drawing.Size(402, 150);
            this.dgTodosAutores.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(299, 31);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(109, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "Consultar Todos";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFechar);
            this.groupBox1.Controls.Add(this.btnConsultar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtcodautor);
            this.groupBox1.Controls.Add(this.btnOK);
            this.groupBox1.Controls.Add(this.dgTodosAutores);
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 253);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados";
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(333, 224);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 6;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConsultar.Location = new System.Drawing.Point(218, 32);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Código:";
            // 
            // txtcodautor
            // 
            this.txtcodautor.Location = new System.Drawing.Point(55, 34);
            this.txtcodautor.Name = "txtcodautor";
            this.txtcodautor.Size = new System.Drawing.Size(157, 20);
            this.txtcodautor.TabIndex = 2;
            // 
            // frmConsultaAutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 274);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Name = "frmConsultaAutores";
            this.Text = "Consultar Autores";
            this.Load += new System.EventHandler(this.frmConsultaAutores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTodosAutores)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgTodosAutores;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtcodautor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnFechar;
    }
}