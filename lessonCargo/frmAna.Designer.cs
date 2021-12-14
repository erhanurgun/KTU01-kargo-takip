
namespace lessonCargo
{
    partial class frmAna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAna));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbKargoTipi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblGenelTop = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lblKdv = new System.Windows.Forms.Label();
            this.lblToplam = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblEkHiz = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblTasima = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
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
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbKargoTipi);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.lblKdv);
            this.groupBox2.Controls.Add(this.lblToplam);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.lblEkHiz);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.lblTasima);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(379, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(332, 270);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " Özet ";
            // 
            // cmbKargoTipi
            // 
            this.cmbKargoTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKargoTipi.FormattingEnabled = true;
            this.cmbKargoTipi.Items.AddRange(new object[] {
            "Dosya / Evrak ( 0 - 500gr )",
            "Paket / Koli"});
            this.cmbKargoTipi.Location = new System.Drawing.Point(96, 35);
            this.cmbKargoTipi.Name = "cmbKargoTipi";
            this.cmbKargoTipi.Size = new System.Drawing.Size(204, 23);
            this.cmbKargoTipi.TabIndex = 0;
            this.cmbKargoTipi.SelectedIndexChanged += new System.EventHandler(this.cmbKargoTipi_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kargo Tipi:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblGenelTop);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Location = new System.Drawing.Point(67, 198);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(233, 48);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // lblGenelTop
            // 
            this.lblGenelTop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGenelTop.Location = new System.Drawing.Point(165, 19);
            this.lblGenelTop.Name = "lblGenelTop";
            this.lblGenelTop.Size = new System.Drawing.Size(47, 17);
            this.lblGenelTop.TabIndex = 0;
            this.lblGenelTop.Text = "000.00";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(153, 20);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(14, 15);
            this.label19.TabIndex = 1;
            this.label19.Text = "₺";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(25, 21);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(116, 15);
            this.label20.TabIndex = 0;
            this.label20.Text = "GENEL TOPLAM:";
            // 
            // lblKdv
            // 
            this.lblKdv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblKdv.Location = new System.Drawing.Point(232, 166);
            this.lblKdv.Name = "lblKdv";
            this.lblKdv.Size = new System.Drawing.Size(47, 17);
            this.lblKdv.TabIndex = 0;
            this.lblKdv.Text = "000.00";
            // 
            // lblToplam
            // 
            this.lblToplam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblToplam.Location = new System.Drawing.Point(232, 135);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(47, 17);
            this.lblToplam.TabIndex = 0;
            this.lblToplam.Text = "000.00";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(170, 168);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 15);
            this.label17.TabIndex = 0;
            this.label17.Text = "KDV:";
            // 
            // lblEkHiz
            // 
            this.lblEkHiz.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEkHiz.Location = new System.Drawing.Point(232, 101);
            this.lblEkHiz.Name = "lblEkHiz";
            this.lblEkHiz.Size = new System.Drawing.Size(47, 17);
            this.lblEkHiz.TabIndex = 0;
            this.lblEkHiz.Text = "000.00";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(149, 135);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 15);
            this.label14.TabIndex = 0;
            this.label14.Text = "Toplam:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(220, 167);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(14, 15);
            this.label16.TabIndex = 1;
            this.label16.Text = "₺";
            // 
            // lblTasima
            // 
            this.lblTasima.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTasima.Location = new System.Drawing.Point(232, 69);
            this.lblTasima.Name = "lblTasima";
            this.lblTasima.Size = new System.Drawing.Size(47, 17);
            this.lblTasima.TabIndex = 0;
            this.lblTasima.Text = "000.00";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(220, 136);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(14, 15);
            this.label13.TabIndex = 1;
            this.label13.Text = "₺";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(115, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "Ek Hizmetler:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(220, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "₺";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Standart Taşıma Bedeli:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(220, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "₺";
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
            this.groupBox1.Location = new System.Drawing.Point(14, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 270);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Genel ";
            // 
            // rtxtAdres
            // 
            this.rtxtAdres.Enabled = false;
            this.rtxtAdres.Location = new System.Drawing.Point(99, 164);
            this.rtxtAdres.Name = "rtxtAdres";
            this.rtxtAdres.Size = new System.Drawing.Size(215, 82);
            this.rtxtAdres.TabIndex = 4;
            this.rtxtAdres.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Açık Adres: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mahalle: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(61, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "İlçe:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(75, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "İl:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Ülke:";
            // 
            // cmbMahalle
            // 
            this.cmbMahalle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMahalle.Enabled = false;
            this.cmbMahalle.FormattingEnabled = true;
            this.cmbMahalle.Location = new System.Drawing.Point(99, 132);
            this.cmbMahalle.Name = "cmbMahalle";
            this.cmbMahalle.Size = new System.Drawing.Size(215, 23);
            this.cmbMahalle.TabIndex = 0;
            this.cmbMahalle.SelectedIndexChanged += new System.EventHandler(this.cmbMahalle_SelectedIndexChanged);
            // 
            // cmbIlce
            // 
            this.cmbIlce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIlce.Enabled = false;
            this.cmbIlce.FormattingEnabled = true;
            this.cmbIlce.Location = new System.Drawing.Point(99, 99);
            this.cmbIlce.Name = "cmbIlce";
            this.cmbIlce.Size = new System.Drawing.Size(215, 23);
            this.cmbIlce.TabIndex = 0;
            this.cmbIlce.SelectedIndexChanged += new System.EventHandler(this.cmbIlce_SelectedIndexChanged);
            // 
            // cmbIl
            // 
            this.cmbIl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIl.Enabled = false;
            this.cmbIl.FormattingEnabled = true;
            this.cmbIl.Location = new System.Drawing.Point(99, 67);
            this.cmbIl.Name = "cmbIl";
            this.cmbIl.Size = new System.Drawing.Size(215, 23);
            this.cmbIl.TabIndex = 0;
            this.cmbIl.SelectedIndexChanged += new System.EventHandler(this.cmbIl_SelectedIndexChanged);
            // 
            // cmbUlke
            // 
            this.cmbUlke.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUlke.FormattingEnabled = true;
            this.cmbUlke.Items.AddRange(new object[] {
            "Türkiye"});
            this.cmbUlke.Location = new System.Drawing.Point(99, 35);
            this.cmbUlke.Name = "cmbUlke";
            this.cmbUlke.Size = new System.Drawing.Size(215, 23);
            this.cmbUlke.TabIndex = 0;
            this.cmbUlke.SelectedIndexChanged += new System.EventHandler(this.cmbUlke_SelectedIndexChanged);
            // 
            // frmAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 301);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kargo Takip Uygulaması";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
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
        private System.Windows.Forms.ComboBox cmbKargoTipi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTasima;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblGenelTop;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblKdv;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblEkHiz;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}

