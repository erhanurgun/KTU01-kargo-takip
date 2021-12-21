
namespace kargo_takip
{
    partial class frmMusteri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMusteri));
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.dataMusMusteriListesi = new System.Windows.Forms.DataGridView();
            this.btnMusBilgiUygula = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.mtxtMusTcNo = new System.Windows.Forms.MaskedTextBox();
            this.btnMusFiltrele = new System.Windows.Forms.Button();
            this.txtMusSoyad = new System.Windows.Forms.TextBox();
            this.label59 = new System.Windows.Forms.Label();
            this.txtMusMusteriNo = new System.Windows.Forms.TextBox();
            this.label61 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.txtMusAd = new System.Windows.Forms.TextBox();
            this.label58 = new System.Windows.Forms.Label();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMusMusteriListesi)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.dataMusMusteriListesi);
            this.groupBox11.Controls.Add(this.btnMusBilgiUygula);
            this.groupBox11.Location = new System.Drawing.Point(280, 7);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(502, 219);
            this.groupBox11.TabIndex = 4;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = " Müşteri Listesi ";
            // 
            // dataMusMusteriListesi
            // 
            this.dataMusMusteriListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMusMusteriListesi.Location = new System.Drawing.Point(20, 30);
            this.dataMusMusteriListesi.Name = "dataMusMusteriListesi";
            this.dataMusMusteriListesi.Size = new System.Drawing.Size(464, 115);
            this.dataMusMusteriListesi.TabIndex = 0;
            // 
            // btnMusBilgiUygula
            // 
            this.btnMusBilgiUygula.Location = new System.Drawing.Point(20, 162);
            this.btnMusBilgiUygula.Name = "btnMusBilgiUygula";
            this.btnMusBilgiUygula.Size = new System.Drawing.Size(464, 39);
            this.btnMusBilgiUygula.TabIndex = 7;
            this.btnMusBilgiUygula.Text = "📲 BİLGİLERİ UYGULA";
            this.btnMusBilgiUygula.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.mtxtMusTcNo);
            this.groupBox7.Controls.Add(this.btnMusFiltrele);
            this.groupBox7.Controls.Add(this.txtMusSoyad);
            this.groupBox7.Controls.Add(this.label59);
            this.groupBox7.Controls.Add(this.txtMusMusteriNo);
            this.groupBox7.Controls.Add(this.label61);
            this.groupBox7.Controls.Add(this.label60);
            this.groupBox7.Controls.Add(this.txtMusAd);
            this.groupBox7.Controls.Add(this.label58);
            this.groupBox7.Location = new System.Drawing.Point(14, 7);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(259, 219);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = " Filtreleme Seçenekleri ";
            // 
            // mtxtMusTcNo
            // 
            this.mtxtMusTcNo.Location = new System.Drawing.Point(97, 27);
            this.mtxtMusTcNo.Mask = "00000000000";
            this.mtxtMusTcNo.Name = "mtxtMusTcNo";
            this.mtxtMusTcNo.Size = new System.Drawing.Size(128, 21);
            this.mtxtMusTcNo.TabIndex = 11;
            this.mtxtMusTcNo.ValidatingType = typeof(int);
            // 
            // btnMusFiltrele
            // 
            this.btnMusFiltrele.Location = new System.Drawing.Point(97, 162);
            this.btnMusFiltrele.Name = "btnMusFiltrele";
            this.btnMusFiltrele.Size = new System.Drawing.Size(128, 39);
            this.btnMusFiltrele.TabIndex = 7;
            this.btnMusFiltrele.Text = "🎐 FİLTRELE";
            this.btnMusFiltrele.UseVisualStyleBackColor = true;
            // 
            // txtMusSoyad
            // 
            this.txtMusSoyad.Location = new System.Drawing.Point(97, 121);
            this.txtMusSoyad.Name = "txtMusSoyad";
            this.txtMusSoyad.Size = new System.Drawing.Size(128, 21);
            this.txtMusSoyad.TabIndex = 4;
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(43, 125);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(51, 16);
            this.label59.TabIndex = 3;
            this.label59.Text = "Soyad:";
            // 
            // txtMusMusteriNo
            // 
            this.txtMusMusteriNo.Location = new System.Drawing.Point(97, 58);
            this.txtMusMusteriNo.Name = "txtMusMusteriNo";
            this.txtMusMusteriNo.Size = new System.Drawing.Size(128, 21);
            this.txtMusMusteriNo.TabIndex = 4;
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(21, 61);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(75, 16);
            this.label61.TabIndex = 3;
            this.label61.Text = "Müşteri No:";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(35, 30);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(56, 16);
            this.label60.TabIndex = 3;
            this.label60.Text = "T.C. No:";
            // 
            // txtMusAd
            // 
            this.txtMusAd.Location = new System.Drawing.Point(97, 90);
            this.txtMusAd.Name = "txtMusAd";
            this.txtMusAd.Size = new System.Drawing.Size(128, 21);
            this.txtMusAd.TabIndex = 4;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(62, 93);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(31, 16);
            this.label58.TabIndex = 3;
            this.label58.Text = "Ad: ";
            // 
            // frmMusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 242);
            this.Controls.Add(this.groupBox11);
            this.Controls.Add(this.groupBox7);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(812, 281);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(812, 281);
            this.Name = "frmMusteri";
            this.Text = "Mevcut Müşteri Seçme";
            this.groupBox11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataMusMusteriListesi)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.DataGridView dataMusMusteriListesi;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.MaskedTextBox mtxtMusTcNo;
        private System.Windows.Forms.Button btnMusFiltrele;
        private System.Windows.Forms.TextBox txtMusSoyad;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.TextBox txtMusMusteriNo;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.TextBox txtMusAd;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Button btnMusBilgiUygula;
    }
}