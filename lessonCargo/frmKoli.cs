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
    public partial class frmKoli : Form
    {
        public double en, boy, yukseklik, agirlik, adet = 1, desi;
        public double top_agirlik, top_desi, top_es_agirlik;

        #region void: desiAl()
        public void desiAl()
        {
            try
            {
                en = Convert.ToDouble(txtEn.Text);
                boy = Convert.ToDouble(txtBoy.Text);
                yukseklik = Convert.ToDouble(txtYukseklik.Text);
                agirlik = Convert.ToDouble(txtAgirlik.Text);

                desi = (en * boy * yukseklik) / 3000;
                top_agirlik += agirlik;
                top_desi += desi;

                if (desi > agirlik)
                    top_es_agirlik += desi;
                else
                    top_es_agirlik += agirlik;

                lblAdet.Text = adet.ToString("0.##");
                lblTopAgirlik.Text = top_agirlik.ToString("0.##");
                lblTopDesi.Text = top_desi.ToString("0.##");
                lblEsasAgirlik.Text = top_es_agirlik.ToString("0.##");

                adet++;
            }
            catch (Exception exp)
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz!", "Uyarı !!!", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }


        }
        #endregion

        public frmKoli()
        {
            InitializeComponent();
        }

        private void frmPaket_Load(object sender, EventArgs e)
        {

        }

        #region event: Click()
        private void btnPaketEkle_Click(object sender, EventArgs e)
        {
            desiAl();

            txtEn.Clear();
            txtBoy.Clear();
            txtYukseklik.Clear();
            txtAgirlik.Clear();
        }
        private void btnDevam_Click(object sender, EventArgs e)
        {
            this.Close();
            frmZarf zarf = new frmZarf();
            zarf.tasima_bedeli = top_es_agirlik;
            zarf.tip = false;
            zarf.Show();
        }
        #endregion
    }
}
