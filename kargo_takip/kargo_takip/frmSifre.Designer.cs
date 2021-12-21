
namespace kargo_takip
{
    partial class frmSifre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSifre));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSifreAl = new System.Windows.Forms.Button();
            this.txtEposta = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSifreAl);
            this.groupBox1.Controls.Add(this.txtEposta);
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 123);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " E-Posta Adresi ";
            // 
            // btnSifreAl
            // 
            this.btnSifreAl.Location = new System.Drawing.Point(28, 65);
            this.btnSifreAl.Name = "btnSifreAl";
            this.btnSifreAl.Size = new System.Drawing.Size(163, 40);
            this.btnSifreAl.TabIndex = 3;
            this.btnSifreAl.Text = "✉️ ŞİFRE AL";
            this.btnSifreAl.UseVisualStyleBackColor = true;
            // 
            // txtEposta
            // 
            this.txtEposta.Location = new System.Drawing.Point(28, 30);
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Size = new System.Drawing.Size(163, 21);
            this.txtEposta.TabIndex = 1;
            // 
            // frmSifre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 154);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(262, 193);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(262, 193);
            this.Name = "frmSifre";
            this.Text = "Şifre Sıfırlama";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSifreAl;
        private System.Windows.Forms.TextBox txtEposta;
    }
}