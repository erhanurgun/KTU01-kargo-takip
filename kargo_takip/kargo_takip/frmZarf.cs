using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kargo_takip
{
    public partial class frmZarf : Form
    {
        #region void: secimYap(), veriAl()
        public double alim_adres = 4.26, alim_sube = 0, teslim_adres = 4.26, teslim_sube = 1.79, teslim_tel = 3.45, kisa_mesaj = 0.83;
        public double tasima_bedeli = 14.76, ek_hizmet, toplam, kdv, genel_toplam;
        public int adet;

        #region 01: secimYap()
        public void secimYap(RadioButton rbtnZarf, CheckBox chbZarf, double dbl)
        {
            if (rbtnZarf != null)
            {
                if (rbtnZarf.Checked)
                    ek_hizmet += dbl;
                else
                    ek_hizmet -= dbl;
            }
            if (chbZarf != null)
            {
                if (chbZarf.Checked)
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
            adet = Convert.ToInt16(cmbZarfAdetSayisi.Text);
            tasima_bedeli *= adet;
            toplam = tasima_bedeli + ek_hizmet;
            kdv = toplam * 0.235;
            genel_toplam = toplam + kdv;

            lblZarfTasima.Text = tasima_bedeli.ToString("0.##");
            lblZarfEkHiz.Text = ek_hizmet.ToString("0.##");
            lblZarfToplam.Text = toplam.ToString("0.##");
            lblZarfKdv.Text = kdv.ToString("0.##");
            lblZarfGenelTop.Text = genel_toplam.ToString("0.##");
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
                cmbZarfAdetSayisi.Items.Add(i);

            cmbZarfAdetSayisi.SelectedIndex = 0;
            rbtnZarfAlimAdres.Checked = true;
            rbtnZarfTeslimAdres.Checked = true;

            veriAl();
        }

        #region event: Changed()

        #region 01: RadioButton
        private void rbtnZarfAlimAdres_CheckedChanged(object sender, EventArgs e)
        {
            secimYap(rbtnZarfAlimAdres, null, alim_adres);
        }
        private void rbtnZarfAlimSube_CheckedChanged(object sender, EventArgs e)
        {
            secimYap(rbtnZarfAlimSube, null, alim_sube);
        }
        private void rbtnZarfTeslimAdres_CheckedChanged(object sender, EventArgs e)
        {
            secimYap(rbtnZarfTeslimAdres, null, teslim_adres);
        }
        private void rbtnZarfTeslimSube_CheckedChanged(object sender, EventArgs e)
        {
            secimYap(rbtnZarfTeslimSube, null, teslim_sube);
        }
        private void rbtnZarfTeslimTel_CheckedChanged(object sender, EventArgs e)
        {
            secimYap(rbtnZarfTeslimTel, null, teslim_tel);
        }
        #endregion

        #region 02: CheckBox
        private void chbZarfMesajBilgi_CheckedChanged(object sender, EventArgs e)
        {
            secimYap(null, chbZarfMesajBilgi, kisa_mesaj);
        }
        #endregion

        #region 03: ComboBox
        private void cmbZarfAdetSayisi_SelectedIndexChanged(object sender, EventArgs e)
        {
            veriAl();
        }
        #endregion

        #endregion

        private void btnDevamZarf_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
