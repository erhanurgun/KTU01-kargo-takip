
namespace kargo_takip
{
    partial class frmGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiris));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.linkSifrem = new System.Windows.Forms.LinkLabel();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtKadi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkWebsite = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.chbBeniHatirla = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chbBeniHatirla);
            this.groupBox1.Controls.Add(this.btnGiris);
            this.groupBox1.Controls.Add(this.linkSifrem);
            this.groupBox1.Controls.Add(this.txtSifre);
            this.groupBox1.Controls.Add(this.txtKadi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 193);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(97, 81);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(156, 48);
            this.btnGiris.TabIndex = 3;
            this.btnGiris.Text = " 🔒 GİRİŞ YAP";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // linkSifrem
            // 
            this.linkSifrem.AutoSize = true;
            this.linkSifrem.Location = new System.Drawing.Point(94, 162);
            this.linkSifrem.Name = "linkSifrem";
            this.linkSifrem.Size = new System.Drawing.Size(116, 16);
            this.linkSifrem.TabIndex = 5;
            this.linkSifrem.TabStop = true;
            this.linkSifrem.Text = "Şifreni mi unuttun ?";
            this.linkSifrem.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSifrem_LinkClicked);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(97, 48);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(156, 21);
            this.txtSifre.TabIndex = 2;
            // 
            // txtKadi
            // 
            this.txtKadi.Location = new System.Drawing.Point(97, 17);
            this.txtKadi.Name = "txtKadi";
            this.txtKadi.Size = new System.Drawing.Size(156, 21);
            this.txtKadi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Şifre: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı: ";
            // 
            // linkWebsite
            // 
            this.linkWebsite.AutoSize = true;
            this.linkWebsite.Location = new System.Drawing.Point(117, 205);
            this.linkWebsite.Name = "linkWebsite";
            this.linkWebsite.Size = new System.Drawing.Size(144, 16);
            this.linkWebsite.TabIndex = 6;
            this.linkWebsite.TabStop = true;
            this.linkWebsite.Text = "www.erhanurgun.com.tr";
            this.linkWebsite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkWebsite_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "powered by";
            // 
            // chbBeniHatirla
            // 
            this.chbBeniHatirla.AutoSize = true;
            this.chbBeniHatirla.Location = new System.Drawing.Point(97, 139);
            this.chbBeniHatirla.Name = "chbBeniHatirla";
            this.chbBeniHatirla.Size = new System.Drawing.Size(96, 20);
            this.chbBeniHatirla.TabIndex = 4;
            this.chbBeniHatirla.Text = "Beni Hatırla";
            this.chbBeniHatirla.UseVisualStyleBackColor = true;
            // 
            // frmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 234);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.linkWebsite);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(324, 273);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(324, 273);
            this.Name = "frmGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KT - Giriş Yap";
            this.Load += new System.EventHandler(this.frmGiris_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.LinkLabel linkSifrem;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtKadi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkWebsite;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chbBeniHatirla;
    }
}

