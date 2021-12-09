
namespace lessonCargo
{
    partial class Form1
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtxtAdres = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbMahalle = new System.Windows.Forms.ComboBox();
            this.cmbIlce = new System.Windows.Forms.ComboBox();
            this.cmbIl = new System.Windows.Forms.ComboBox();
            this.cmbUlke = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(304, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(316, 322);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " Alıcı ";
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(363, 340);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(257, 201);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = " Çıktı ";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(12, 340);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(345, 201);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = " Kargo Bilgileri ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtxtAdres);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbMahalle);
            this.groupBox1.Controls.Add(this.cmbIlce);
            this.groupBox1.Controls.Add(this.cmbIl);
            this.groupBox1.Controls.Add(this.cmbUlke);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 322);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Gönderici ";
            // 
            // rtxtAdres
            // 
            this.rtxtAdres.Enabled = false;
            this.rtxtAdres.Location = new System.Drawing.Point(83, 154);
            this.rtxtAdres.Name = "rtxtAdres";
            this.rtxtAdres.Size = new System.Drawing.Size(185, 92);
            this.rtxtAdres.TabIndex = 4;
            this.rtxtAdres.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Açık Adres: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mahalle: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "İlçe:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(62, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "İl:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Ülke:";
            // 
            // cmbMahalle
            // 
            this.cmbMahalle.Enabled = false;
            this.cmbMahalle.FormattingEnabled = true;
            this.cmbMahalle.Location = new System.Drawing.Point(83, 126);
            this.cmbMahalle.Name = "cmbMahalle";
            this.cmbMahalle.Size = new System.Drawing.Size(185, 21);
            this.cmbMahalle.TabIndex = 0;
            this.cmbMahalle.SelectedIndexChanged += new System.EventHandler(this.cmbMahalle_SelectedIndexChanged);
            // 
            // cmbIlce
            // 
            this.cmbIlce.Enabled = false;
            this.cmbIlce.FormattingEnabled = true;
            this.cmbIlce.Location = new System.Drawing.Point(83, 98);
            this.cmbIlce.Name = "cmbIlce";
            this.cmbIlce.Size = new System.Drawing.Size(185, 21);
            this.cmbIlce.TabIndex = 0;
            this.cmbIlce.SelectedIndexChanged += new System.EventHandler(this.cmbIlce_SelectedIndexChanged);
            // 
            // cmbIl
            // 
            this.cmbIl.Enabled = false;
            this.cmbIl.FormattingEnabled = true;
            this.cmbIl.Location = new System.Drawing.Point(83, 70);
            this.cmbIl.Name = "cmbIl";
            this.cmbIl.Size = new System.Drawing.Size(185, 21);
            this.cmbIl.TabIndex = 0;
            this.cmbIl.SelectedIndexChanged += new System.EventHandler(this.cmbIl_SelectedIndexChanged);
            // 
            // cmbUlke
            // 
            this.cmbUlke.FormattingEnabled = true;
            this.cmbUlke.Items.AddRange(new object[] {
            "Türkiye"});
            this.cmbUlke.Location = new System.Drawing.Point(83, 42);
            this.cmbUlke.Name = "cmbUlke";
            this.cmbUlke.Size = new System.Drawing.Size(185, 21);
            this.cmbUlke.TabIndex = 0;
            this.cmbUlke.SelectedIndexChanged += new System.EventHandler(this.cmbUlke_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 558);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kargo Takip Uygulaması";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtxtAdres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbIlce;
        private System.Windows.Forms.ComboBox cmbIl;
        private System.Windows.Forms.ComboBox cmbUlke;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMahalle;
    }
}

