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
    public partial class frmKoli : Form
    {
        #region void: secimYap(), veriAl()
        public double alim_adres = 4.26, alim_sube = 0, teslim_adres = 4.26, teslim_sube = 1.79,
                      teslim_tel = 3.45, kisa_mesaj = 0.83, agir_kargo = 280, agirlik_limiti = 500;
        public double tasima_bedeli = 14.76, ek_hizmet, toplam, kdv, genel_toplam;
        public double koli_carpani = 3.3020042470256275998487360735375;
        public double tasima_carpani = 1.2269230769230769230769230769231;
        public double agir_kargo_carpani = 20.747857142857142857142857142857;
        public int adet = 1;

        public double en, boy, yukseklik, agirlik, desi;
        public double top_agirlik, top_desi, top_es_agirlik;

        #region 01: secimYap()
        public void secimYap(RadioButton rbtnKoli, CheckBox chbKoli, double dbl)
        {
            if (rbtnKoli != null)
            {
                if (rbtnKoli.Checked)
                    ek_hizmet += dbl;
                else
                    ek_hizmet -= dbl;
            }
            if (chbKoli != null)
            {
                if (chbKoli.Checked)
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
            double eks_fiyat = 4.26 * adet * tasima_carpani;
            string str_normal = "( " + eks_fiyat.ToString("0.##") + "₺ )";
            string str_agir = "( " + (eks_fiyat * agir_kargo).ToString("0.##") + "₺ )";

            if (top_es_agirlik > agirlik_limiti)
            {
                chbKoliAgir.Checked = true;
                lblAlimAdres.Text = str_agir;
                lblTeslimAdres.Text = str_agir;
            }
            else
            {
                lblAlimAdres.Text = str_normal;
                lblTeslimAdres.Text = str_normal;
            }



            tasima_bedeli = top_es_agirlik * koli_carpani;
            toplam = tasima_bedeli + ek_hizmet;
            kdv = toplam * 0.235;
            genel_toplam = toplam + kdv;

            lblKoliTasima.Text = tasima_bedeli.ToString("0.##");
            lblKoliEkHiz.Text = ek_hizmet.ToString("0.##");
            lblKoliToplam.Text = toplam.ToString("0.##");
            lblKoliKdv.Text = kdv.ToString("0.##");
            lblKoliGenelTop.Text = genel_toplam.ToString("0.##");
        }
        #endregion

        #region 03: desiBul()
        public void desiBul()
        {
            en = Convert.ToDouble(txtEn.Text);
            boy = Convert.ToDouble(txtBoy.Text);
            yukseklik = Convert.ToDouble(txtYukseklik.Text);
            agirlik = Convert.ToDouble(txtAgirlik.Text);

            desi = (en * boy * yukseklik) / 3000;
            top_agirlik += agirlik;
            top_desi += desi;

            if (top_desi > top_agirlik)
                top_es_agirlik = top_desi;
            else
                top_es_agirlik = top_agirlik;

            lblAdet.Text = adet.ToString("0.##");
            lblTopAgirlik.Text = top_agirlik.ToString("0.##");
            lblTopDesi.Text = top_desi.ToString("0.##");
            lblEsasAgirlik.Text = top_es_agirlik.ToString("0.##");

            adet++;
        }
        #endregion

        #endregion

        public frmKoli()
        {
            InitializeComponent();
        }

        private void frmKoli_Load(object sender, EventArgs e)
        {
            rbtnKoliAlimAdres.Checked = true;
            rbtnKoliTeslimAdres.Checked = true;
        }

        #region event: Changed()

        #region 01: RadioButton
        private void rbtnKoliAlimAdres_CheckedChanged(object sender, EventArgs e)
        {
            secimYap(rbtnKoliAlimAdres, null, alim_adres);
        }
        private void rbtnKoliAlimSube_CheckedChanged(object sender, EventArgs e)
        {
            secimYap(rbtnKoliAlimSube, null, alim_sube);
        }
        private void rbtnKoliTeslimAdres_CheckedChanged(object sender, EventArgs e)
        {
            secimYap(rbtnKoliTeslimAdres, null, teslim_adres);
        }
        private void rbtnKoliTeslimSube_CheckedChanged(object sender, EventArgs e)
        {
            secimYap(rbtnKoliTeslimSube, null, teslim_sube);
        }
        private void rbtnKoliTeslimTel_CheckedChanged(object sender, EventArgs e)
        {
            secimYap(rbtnKoliTeslimTel, null, teslim_tel);
        }
        #endregion

        #region 02: CheckBox
        private void chbKoliMesajBilgi_CheckedChanged(object sender, EventArgs e)
        {
            secimYap(null, chbKoliMesajBilgi, kisa_mesaj);
        }

        private void chbKoliAgir_CheckedChanged(object sender, EventArgs e)
        {
            if (chbKoliAgir.Checked)
            {
                ek_hizmet += agir_kargo * agir_kargo_carpani;
            }
            else
            {
                ek_hizmet -= agir_kargo * agir_kargo_carpani;
            }

            veriAl();
        }
        #endregion

        #endregion

        private void btnPaketEkle_Click(object sender, EventArgs e)
        {
            Global global = new Global();
            global.err = hataMesaji;
            global.bosMu(gboxDesiHesapla);

            if (global.hata_var_mi == false)
            {
                desiBul();
                veriAl();

                txtEn.Clear();
                txtBoy.Clear();
                txtYukseklik.Clear();
                txtAgirlik.Clear();
            }
        }

        private void btnDevamKoli_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
