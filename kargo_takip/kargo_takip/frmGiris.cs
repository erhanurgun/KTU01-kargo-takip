using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace kargo_takip
{
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }

        private void frmGiris_Load(object sender, EventArgs e)
        {
            txtKadi.Text = "erhanurgun";
            txtSifre.Text = "jiyan123";
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            Global global = new Global
            {
                yol = @"Data Source=PCI-ACER\SQLSERVEREXP;Initial Catalog=kargo_takip;Integrated Security=True",
                sorgu = "SELECT * FROM personeller WHERE durum = 1",
                txt_kadi = txtKadi.Text,
                txt_sifre = txtSifre.Text
            };
            global.dbBaglan(1);
        }

        private void linkSifrem_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSifre sifre = new frmSifre();
            sifre.ShowDialog();
        }

        private void linkWebsite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://erhanurgun.com.tr/");
        }
    }
}
