using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace kargo_takip
{
    public partial class frmSifre : Form
    {
        public frmSifre()
        {
            InitializeComponent();
        }

        private void frmSifre_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSifreAl_Click(object sender, EventArgs e)
        {
            Global global = new Global
            {
                yol = @"Data Source=PCI-ACER\SQLSERVEREXP;Initial Catalog=kargo_takip;Integrated Security=True",
                sorgu = "SELECT * FROM personeller WHERE durum = 1",
                txt_email = txtEposta.Text
            };
            global.dbBaglan(2);
        }
    }
}
