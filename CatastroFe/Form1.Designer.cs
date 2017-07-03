namespace CatastroFe
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnDownShape = new System.Windows.Forms.Button();
            this.urlDownShape = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLugar = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lnkPasho = new System.Windows.Forms.LinkLabel();
            this.cboMapa = new System.Windows.Forms.ComboBox();
            this.cboLocalidad = new System.Windows.Forms.ComboBox();
            this.btnGetPlano = new System.Windows.Forms.Button();
            this.urlPlan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPlan = new System.Windows.Forms.TextBox();
            this.txtAn = new System.Windows.Forms.TextBox();
            this.lnkHelpPlano = new System.Windows.Forms.LinkLabel();
            this.lnkGitHub = new System.Windows.Forms.LinkLabel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 73);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(360, 168);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lnkPasho);
            this.tabPage1.Controls.Add(this.btnDownShape);
            this.tabPage1.Controls.Add(this.urlDownShape);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cboMapa);
            this.tabPage1.Controls.Add(this.lblLugar);
            this.tabPage1.Controls.Add(this.cboLocalidad);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(352, 142);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mapas y geometrias (SHP)";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnDownShape
            // 
            this.btnDownShape.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownShape.Location = new System.Drawing.Point(9, 90);
            this.btnDownShape.Name = "btnDownShape";
            this.btnDownShape.Size = new System.Drawing.Size(337, 26);
            this.btnDownShape.TabIndex = 3;
            this.btnDownShape.Text = "Descargar ShapeFile";
            this.btnDownShape.UseVisualStyleBackColor = true;
            this.btnDownShape.Click += new System.EventHandler(this.btnDownShape_Click);
            // 
            // urlDownShape
            // 
            this.urlDownShape.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlDownShape.Location = new System.Drawing.Point(9, 64);
            this.urlDownShape.Name = "urlDownShape";
            this.urlDownShape.ReadOnly = true;
            this.urlDownShape.Size = new System.Drawing.Size(337, 21);
            this.urlDownShape.TabIndex = 2;
            this.urlDownShape.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mapa";
            // 
            // lblLugar
            // 
            this.lblLugar.AutoSize = true;
            this.lblLugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLugar.Location = new System.Drawing.Point(6, 9);
            this.lblLugar.Name = "lblLugar";
            this.lblLugar.Size = new System.Drawing.Size(69, 17);
            this.lblLugar.TabIndex = 1;
            this.lblLugar.Text = "Localidad";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lnkHelpPlano);
            this.tabPage2.Controls.Add(this.txtAn);
            this.tabPage2.Controls.Add(this.txtPlan);
            this.tabPage2.Controls.Add(this.btnGetPlano);
            this.tabPage2.Controls.Add(this.urlPlan);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(352, 142);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Planos de mensura (PDF)";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // picLogo
            // 
            this.picLogo.Image = global::CatastroFe.Properties.Resources.catastrophe;
            this.picLogo.Location = new System.Drawing.Point(15, 17);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(355, 50);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // lnkPasho
            // 
            this.lnkPasho.AutoSize = true;
            this.lnkPasho.Location = new System.Drawing.Point(76, 119);
            this.lnkPasho.Name = "lnkPasho";
            this.lnkPasho.Size = new System.Drawing.Size(202, 13);
            this.lnkPasho.TabIndex = 4;
            this.lnkPasho.TabStop = true;
            this.lnkPasho.Text = "Descargue un archivo vacio ¿Qué pasó?";
            this.lnkPasho.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkPasho_LinkClicked);
            // 
            // cboMapa
            // 
            this.cboMapa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMapa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMapa.FormattingEnabled = true;
            this.cboMapa.Items.AddRange(new object[] {
            "??? (Líneas) [fm]",
            "Barreras fitosanitarias (?) (Polígonos) [fito]",
            "Calles (Líneas) [ec]",
            "Calles (Puntos) [c]",
            "Calles alt. (?) (Puntos) [ov]",
            "Centroide de manzana (Puntos) [cm]",
            "Centroide de parcela (Puntos) [cp]",
            "Centroide de parcela alt. (Puntos) [cpn]",
            "Cotas (Puntos) [co]",
            "Manzanas (Polígonos) [m]",
            "Mejoras (?) (Polígonos) [mvtm]",
            "Parcelario gas (?) (Polígonos) [tgas]",
            "Parcelario rural (Polígonos) [pr]",
            "Parcelario rural alt. (Polígonos) [pnr]",
            "Parcelario urbano (Polígonos) [pu]",
            "Parcelario urbano alt. (Polígonos) [pnu]"});
            this.cboMapa.Location = new System.Drawing.Point(81, 35);
            this.cboMapa.Name = "cboMapa";
            this.cboMapa.Size = new System.Drawing.Size(265, 23);
            this.cboMapa.Sorted = true;
            this.cboMapa.TabIndex = 2;
            this.cboMapa.SelectedIndexChanged += new System.EventHandler(this.cboLocalidad_SelectedIndexChanged);
            // 
            // cboLocalidad
            // 
            this.cboLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLocalidad.FormattingEnabled = true;
            this.cboLocalidad.Location = new System.Drawing.Point(81, 6);
            this.cboLocalidad.Name = "cboLocalidad";
            this.cboLocalidad.Size = new System.Drawing.Size(265, 23);
            this.cboLocalidad.Sorted = true;
            this.cboLocalidad.TabIndex = 0;
            this.cboLocalidad.SelectedIndexChanged += new System.EventHandler(this.cboLocalidad_SelectedIndexChanged);
            // 
            // btnGetPlano
            // 
            this.btnGetPlano.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetPlano.Location = new System.Drawing.Point(9, 62);
            this.btnGetPlano.Name = "btnGetPlano";
            this.btnGetPlano.Size = new System.Drawing.Size(337, 26);
            this.btnGetPlano.TabIndex = 8;
            this.btnGetPlano.Text = "Ver plano de mensura";
            this.btnGetPlano.UseVisualStyleBackColor = true;
            this.btnGetPlano.Click += new System.EventHandler(this.btnGetPlano_Click);
            // 
            // urlPlan
            // 
            this.urlPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlPlan.Location = new System.Drawing.Point(9, 94);
            this.urlPlan.Name = "urlPlan";
            this.urlPlan.ReadOnly = true;
            this.urlPlan.Size = new System.Drawing.Size(337, 21);
            this.urlPlan.TabIndex = 6;
            this.urlPlan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Año";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Plano";
            // 
            // txtPlan
            // 
            this.txtPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlan.Location = new System.Drawing.Point(59, 6);
            this.txtPlan.Name = "txtPlan";
            this.txtPlan.Size = new System.Drawing.Size(287, 21);
            this.txtPlan.TabIndex = 10;
            // 
            // txtAn
            // 
            this.txtAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAn.Location = new System.Drawing.Point(59, 35);
            this.txtAn.Name = "txtAn";
            this.txtAn.Size = new System.Drawing.Size(287, 21);
            this.txtAn.TabIndex = 11;
            // 
            // lnkHelpPlano
            // 
            this.lnkHelpPlano.AutoSize = true;
            this.lnkHelpPlano.Location = new System.Drawing.Point(68, 120);
            this.lnkHelpPlano.Name = "lnkHelpPlano";
            this.lnkHelpPlano.Size = new System.Drawing.Size(218, 13);
            this.lnkHelpPlano.TabIndex = 12;
            this.lnkHelpPlano.TabStop = true;
            this.lnkHelpPlano.Text = "No pude descargar mi plano ¿Qué salió mal?";
            this.lnkHelpPlano.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkHelpPlano_LinkClicked);
            // 
            // lnkGitHub
            // 
            this.lnkGitHub.AutoSize = true;
            this.lnkGitHub.Location = new System.Drawing.Point(335, 2);
            this.lnkGitHub.Name = "lnkGitHub";
            this.lnkGitHub.Size = new System.Drawing.Size(38, 13);
            this.lnkGitHub.TabIndex = 2;
            this.lnkGitHub.TabStop = true;
            this.lnkGitHub.Text = "Github";
            this.lnkGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkGitHub_LinkClicked);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 247);
            this.Controls.Add(this.lnkGitHub);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Catastro-Fe";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblLugar;
        private System.Windows.Forms.Button btnDownShape;
        private System.Windows.Forms.TextBox urlDownShape;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lnkPasho;
        private System.Windows.Forms.ComboBox cboMapa;
        private System.Windows.Forms.ComboBox cboLocalidad;
        private System.Windows.Forms.TextBox txtAn;
        private System.Windows.Forms.TextBox txtPlan;
        private System.Windows.Forms.Button btnGetPlano;
        private System.Windows.Forms.TextBox urlPlan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel lnkHelpPlano;
        private System.Windows.Forms.LinkLabel lnkGitHub;
    }
}

