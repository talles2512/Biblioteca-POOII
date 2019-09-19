using System.Windows.Forms;

namespace UNIP.POOII.BibliotecaPOOII
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
            this.ribbon1 = new System.Windows.Forms.Ribbon();
            this.ribbonOrbMenuItem1 = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonOrbMenuItem2 = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonOrbMenuItem3 = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonTab1 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.rbCadastrarAutores = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel2 = new System.Windows.Forms.RibbonPanel();
            this.rbCadastrarLivros = new System.Windows.Forms.RibbonButton();
            this.ribbonButton1 = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel3 = new System.Windows.Forms.RibbonPanel();
            this.rbCadastrarMulta = new System.Windows.Forms.RibbonButton();
            this.ribbonTab2 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel4 = new System.Windows.Forms.RibbonPanel();
            this.rbConsultarAutores = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel5 = new System.Windows.Forms.RibbonPanel();
            this.rbConsultarLivros = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel6 = new System.Windows.Forms.RibbonPanel();
            this.rbConsultarMultas = new System.Windows.Forms.RibbonButton();
            this.SuspendLayout();
            // 
            // ribbon1
            // 
            this.ribbon1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.Minimized = false;
            this.ribbon1.Name = "ribbon1";
            // 
            // 
            // 
            this.ribbon1.OrbDropDown.BorderRoundness = 8;
            this.ribbon1.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.ribbonOrbMenuItem1);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.ribbonOrbMenuItem2);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.ribbonOrbMenuItem3);
            this.ribbon1.OrbDropDown.Name = "";
            this.ribbon1.OrbDropDown.Size = new System.Drawing.Size(527, 204);
            this.ribbon1.OrbDropDown.TabIndex = 0;
            this.ribbon1.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.ribbon1.Size = new System.Drawing.Size(661, 156);
            this.ribbon1.TabIndex = 3;
            this.ribbon1.Tabs.Add(this.ribbonTab1);
            this.ribbon1.Tabs.Add(this.ribbonTab2);
            this.ribbon1.Text = "ribbon1";
            // 
            // ribbonOrbMenuItem1
            // 
            this.ribbonOrbMenuItem1.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem1.Image")));
            this.ribbonOrbMenuItem1.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem1.LargeImage")));
            this.ribbonOrbMenuItem1.Name = "ribbonOrbMenuItem1";
            this.ribbonOrbMenuItem1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem1.SmallImage")));
            this.ribbonOrbMenuItem1.Text = "Menu";
            // 
            // ribbonOrbMenuItem2
            // 
            this.ribbonOrbMenuItem2.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem2.Image")));
            this.ribbonOrbMenuItem2.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem2.LargeImage")));
            this.ribbonOrbMenuItem2.Name = "ribbonOrbMenuItem2";
            this.ribbonOrbMenuItem2.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem2.SmallImage")));
            this.ribbonOrbMenuItem2.Text = "Logout";
            // 
            // ribbonOrbMenuItem3
            // 
            this.ribbonOrbMenuItem3.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbMenuItem3.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem3.Image")));
            this.ribbonOrbMenuItem3.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem3.LargeImage")));
            this.ribbonOrbMenuItem3.Name = "ribbonOrbMenuItem3";
            this.ribbonOrbMenuItem3.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem3.SmallImage")));
            this.ribbonOrbMenuItem3.Text = "Sair";
            this.ribbonOrbMenuItem3.Click += new System.EventHandler(this.RibbonOrbMenuItem3_Click);
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Name = "ribbonTab1";
            this.ribbonTab1.Panels.Add(this.ribbonPanel1);
            this.ribbonTab1.Panels.Add(this.ribbonPanel2);
            this.ribbonTab1.Panels.Add(this.ribbonPanel3);
            this.ribbonTab1.Text = "Cadastrar";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.Items.Add(this.rbCadastrarAutores);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Text = "Autores";
            // 
            // rbCadastrarAutores
            // 
            this.rbCadastrarAutores.Image = ((System.Drawing.Image)(resources.GetObject("rbCadastrarAutores.Image")));
            this.rbCadastrarAutores.LargeImage = ((System.Drawing.Image)(resources.GetObject("rbCadastrarAutores.LargeImage")));
            this.rbCadastrarAutores.Name = "rbCadastrarAutores";
            this.rbCadastrarAutores.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbCadastrarAutores.SmallImage")));
            this.rbCadastrarAutores.Text = "";
            this.rbCadastrarAutores.Click += new System.EventHandler(this.RbCadastrarAutores_Click);
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.Items.Add(this.rbCadastrarLivros);
            this.ribbonPanel2.Name = "ribbonPanel2";
            this.ribbonPanel2.Text = "Livros";
            // 
            // rbCadastrarLivros
            // 
            this.rbCadastrarLivros.DropDownItems.Add(this.ribbonButton1);
            this.rbCadastrarLivros.Image = ((System.Drawing.Image)(resources.GetObject("rbCadastrarLivros.Image")));
            this.rbCadastrarLivros.LargeImage = ((System.Drawing.Image)(resources.GetObject("rbCadastrarLivros.LargeImage")));
            this.rbCadastrarLivros.Name = "rbCadastrarLivros";
            this.rbCadastrarLivros.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbCadastrarLivros.SmallImage")));
            this.rbCadastrarLivros.Text = "";
            this.rbCadastrarLivros.Click += new System.EventHandler(this.RbCadastrarLivros_Click);
            // 
            // ribbonButton1
            // 
            this.ribbonButton1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.Image")));
            this.ribbonButton1.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.LargeImage")));
            this.ribbonButton1.Name = "ribbonButton1";
            this.ribbonButton1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.SmallImage")));
            this.ribbonButton1.Text = "ribbonButton1";
            // 
            // ribbonPanel3
            // 
            this.ribbonPanel3.Items.Add(this.rbCadastrarMulta);
            this.ribbonPanel3.Name = "ribbonPanel3";
            this.ribbonPanel3.Text = "Multas";
            // 
            // rbCadastrarMulta
            // 
            this.rbCadastrarMulta.Image = ((System.Drawing.Image)(resources.GetObject("rbCadastrarMulta.Image")));
            this.rbCadastrarMulta.LargeImage = ((System.Drawing.Image)(resources.GetObject("rbCadastrarMulta.LargeImage")));
            this.rbCadastrarMulta.Name = "rbCadastrarMulta";
            this.rbCadastrarMulta.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbCadastrarMulta.SmallImage")));
            this.rbCadastrarMulta.Text = "";
            this.rbCadastrarMulta.Click += new System.EventHandler(this.RbCadastrarMulta_Click);
            // 
            // ribbonTab2
            // 
            this.ribbonTab2.Name = "ribbonTab2";
            this.ribbonTab2.Panels.Add(this.ribbonPanel4);
            this.ribbonTab2.Panels.Add(this.ribbonPanel5);
            this.ribbonTab2.Panels.Add(this.ribbonPanel6);
            this.ribbonTab2.Text = "Consultar";
            // 
            // ribbonPanel4
            // 
            this.ribbonPanel4.Items.Add(this.rbConsultarAutores);
            this.ribbonPanel4.Name = "ribbonPanel4";
            this.ribbonPanel4.Text = "Autores";
            // 
            // rbConsultarAutores
            // 
            this.rbConsultarAutores.Image = ((System.Drawing.Image)(resources.GetObject("rbConsultarAutores.Image")));
            this.rbConsultarAutores.LargeImage = ((System.Drawing.Image)(resources.GetObject("rbConsultarAutores.LargeImage")));
            this.rbConsultarAutores.Name = "rbConsultarAutores";
            this.rbConsultarAutores.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbConsultarAutores.SmallImage")));
            this.rbConsultarAutores.Text = "";
            this.rbConsultarAutores.Click += new System.EventHandler(this.RbConsultarAutores_Click);
            // 
            // ribbonPanel5
            // 
            this.ribbonPanel5.Items.Add(this.rbConsultarLivros);
            this.ribbonPanel5.Name = "ribbonPanel5";
            this.ribbonPanel5.Text = "Livros";
            // 
            // rbConsultarLivros
            // 
            this.rbConsultarLivros.Image = ((System.Drawing.Image)(resources.GetObject("rbConsultarLivros.Image")));
            this.rbConsultarLivros.LargeImage = ((System.Drawing.Image)(resources.GetObject("rbConsultarLivros.LargeImage")));
            this.rbConsultarLivros.Name = "rbConsultarLivros";
            this.rbConsultarLivros.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbConsultarLivros.SmallImage")));
            this.rbConsultarLivros.Text = "";
            this.rbConsultarLivros.Click += new System.EventHandler(this.RbConsultarLivros_Click);
            // 
            // ribbonPanel6
            // 
            this.ribbonPanel6.Items.Add(this.rbConsultarMultas);
            this.ribbonPanel6.Name = "ribbonPanel6";
            this.ribbonPanel6.Text = "Multas";
            // 
            // rbConsultarMultas
            // 
            this.rbConsultarMultas.Image = ((System.Drawing.Image)(resources.GetObject("rbConsultarMultas.Image")));
            this.rbConsultarMultas.LargeImage = ((System.Drawing.Image)(resources.GetObject("rbConsultarMultas.LargeImage")));
            this.rbConsultarMultas.Name = "rbConsultarMultas";
            this.rbConsultarMultas.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbConsultarMultas.SmallImage")));
            this.rbConsultarMultas.Text = "";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(661, 463);
            this.Controls.Add(this.ribbon1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Biblioteca Turma POO II";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Ribbon ribbon1;
        private System.Windows.Forms.RibbonTab ribbonTab1;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.RibbonPanel ribbonPanel2;
        private System.Windows.Forms.RibbonPanel ribbonPanel3;
        private System.Windows.Forms.RibbonTab ribbonTab2;
        private System.Windows.Forms.RibbonPanel ribbonPanel4;
        private System.Windows.Forms.RibbonPanel ribbonPanel5;
        private System.Windows.Forms.RibbonPanel ribbonPanel6;
        private RibbonButton rbCadastrarAutores;
        private RibbonButton rbCadastrarLivros;
        private RibbonButton ribbonButton1;
        private RibbonButton rbCadastrarMulta;
        private RibbonButton rbConsultarAutores;
        private RibbonButton rbConsultarLivros;
        private RibbonButton rbConsultarMultas;
        private RibbonOrbMenuItem ribbonOrbMenuItem1;
        private RibbonOrbMenuItem ribbonOrbMenuItem2;
        private RibbonOrbMenuItem ribbonOrbMenuItem3;
    }
}