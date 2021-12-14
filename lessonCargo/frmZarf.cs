using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lessonCargo
{
    public partial class frmZarf : Form
    {
        public double alim_adres = 4.26, alim_sube = 0, teslim_adres = 4.26, teslim_sube = 1.79, teslim_tel = 3.45, kisa_mesaj = 0.83;
        public double tasima_bedeli = 14.76, ek_hizmet, toplam, kdv, genel_toplam;
        public int adet;
        public bool tip = true;

        #region void:

        #region 01: secimYap()
        public void secimYap(RadioButton rbtn, CheckBox chb, double dbl)
        {
            if (rbtn != null)
            {
                if (rbtn.Checked)
                    ek_hizmet += dbl;
                else
                    ek_hizmet -= dbl;
            }

            if (chb != null)
            {
                if (chb.Checked)
                    ek_hizmet += dbl;
                else
                    ek_hizmet -= dbl;
            }

            veriAl();
        }
        #endregion

        #region 02: veriAl()
        public void veriAl()
        {
            adet = Convert.ToInt16(cmbAdetSayisi.Text);

            if (tip == true)
                tasima_bedeli = 14.76 * adet;
            
            else
                cmbAdetSayisi.Enabled = false;

            toplam = tasima_bedeli + ek_hizmet;
            kdv = toplam * 0.235;
            genel_toplam = toplam + kdv;

            lblTasima.Text = tasima_bedeli.ToString("0.##");
            lblEkHiz.Text = ek_hizmet.ToString("0.##");
            lblToplam.Text = toplam.ToString("0.##");
            lblKdv.Text = kdv.ToString("0.##");
            lblGenelTop.Text = genel_toplam.ToString("0.##");
        }
        #endregion

        #endregion

        public frmZarf()
        {
            InitializeComponent();
        }

        private void frmZarf_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
                cmbAdetSayisi.Items.Add(i);

            cmbAdetSayisi.SelectedIndex = 0;
            veriAl();
        }

        #region event: Changed()

        #region 01: RadioButton
        private void rbtnAlimAdres_CheckedChanged(object sender, EventArgs e)
        {
            secimYap(rbtnAlimAdres, null, alim_adres);
        }
        private void rbtnAlimSube_CheckedChanged(object sender, EventArgs e)
        {
            secimYap(rbtnAlimSube, null, alim_sube);
        }
        private void rbtnTeslimAdres_CheckedChanged(object sender, EventArgs e)
        {
            secimYap(rbtnTeslimAdres, null, teslim_adres);
        }
        private void rbtnTeslimSube_CheckedChanged(object sender, EventArgs e)
        {
            secimYap(rbtnTeslimSube, null, teslim_sube);
        }
        private void rbtnTeslimTel_CheckedChanged(object sender, EventArgs e)
        {
            secimYap(rbtnTeslimTel, null, teslim_tel);
        }
        #endregion

        #region 02: CheckBox
        private void chbMesajBilgi_CheckedChanged(object sender, EventArgs e)
        {
            secimYap(null, chbMesajBilgi, kisa_mesaj);
        }
        #endregion

        #endregion

        private void btnDevamZarf_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbAdetSayisi_SelectedIndexChanged(object sender, EventArgs e)
        {
            veriAl();
        }
    }
}
