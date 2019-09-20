namespace UNIP.POOII.BibliotecaPOOII
{
    partial class frmAlterarDeletarAutores
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
            this.btnfechar = new System.Windows.Forms.Button();
            this.btndeleta = new System.Windows.Forms.Button();
            this.btnaltera = new System.Windows.Forms.Button();
            this.dtData = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomeAutor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.txtcodautor = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnfechar);
            this.groupBox1.Controls.Add(this.btndeleta);
            this.groupBox1.Controls.Add(this.btnaltera);
            this.groupBox1.Controls.Add(this.dtData);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNomeAutor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnConsultar);
            this.groupBox1.Controls.Add(this.lbl);
            this.groupBox1.Controls.Add(this.txtcodautor);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(491, 136);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados";
            // 
            // btnfechar
            // 
            this.btnfechar.Location = new System.Drawing.Point(410, 103);
            this.btnfechar.Name = "btnfechar";
            this.btnfechar.Size = new System.Drawing.Size(75, 23);
            this.btnfechar.TabIndex = 14;
            this.btnfechar.Text = "Fechar";
            this.btnfechar.UseVisualStyleBackColor = true;
            this.btnfechar.Click += new System.EventHandler(this.Btnfechar_Click);
            // 
            // btndeleta
            // 
            this.btndeleta.Enabled = false;
            this.btndeleta.Location = new System.Drawing.Point(329, 103);
            this.btndeleta.Name = "btndeleta";
            this.btndeleta.Size = new System.Drawing.Size(75, 23);
            this.btndeleta.TabIndex = 13;
            this.btndeleta.Text = "Deletar";
            this.btndeleta.UseVisualStyleBackColor = true;
            this.btndeleta.Click += new System.EventHandler(this.Btndeleta_Click);
            // 
            // btnaltera
            // 
            this.btnaltera.Enabled = false;
            this.btnaltera.Location = new System.Drawing.Point(248, 103);
            this.btnaltera.Name = "btnaltera";
            this.btnaltera.Size = new System.Drawing.Size(75, 23);
            this.btnaltera.TabIndex = 12;
            this.btnaltera.Text = "Alterar";
            this.btnaltera.UseVisualStyleBackColor = true;
            this.btnaltera.Click += new System.EventHandler(this.Btnaltera_Click);
            // 
            // dtData
            // 
            this.dtData.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.dtData.CustomFormat = "dd/MM/yyyy";
            this.dtData.Enabled = false;
            this.dtData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtData.Location = new System.Drawing.Point(74, 72);
            this.dtData.Name = "dtData";
            this.dtData.Size = new System.Drawing.Size(109, 20);
            this.dtData.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Data:";
            // 
            // txtNomeAutor
            // 
            this.txtNomeAutor.Enabled = false;
            this.txtNomeAutor.Location = new System.Drawing.Point(74, 46);
            this.txtNomeAutor.Name = "txtNomeAutor";
            this.txtNomeAutor.Size = new System.Drawing.Size(405, 20);
            this.txtNomeAutor.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nome:";
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConsultar.Location = new System.Drawing.Point(237, 17);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 7;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(25, 22);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(43, 13);
            this.lbl.TabIndex = 6;
            this.lbl.Text = "Código:";
            // 
            // txtcodautor
            // 
            this.txtcodautor.Location = new System.Drawing.Point(74, 19);
            this.txtcodautor.Name = "txtcodautor";
            this.txtcodautor.Size = new System.Drawing.Size(157, 20);
            this.txtcodautor.TabIndex = 5;
            // 
            // frmAlterarDeletarAutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 153);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAlterarDeletarAutores";
            this.Text = "Alterar/Deletar Autores";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtcodautor;
        private System.Windows.Forms.Button btnfechar;
        private System.Windows.Forms.Button btndeleta;
        private System.Windows.Forms.Button btnaltera;
        private System.Windows.Forms.DateTimePicker dtData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomeAutor;
        private System.Windows.Forms.Label label2;
    }
}