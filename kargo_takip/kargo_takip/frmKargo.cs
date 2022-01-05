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
    public partial class frmKargo : Form
    {
        #region Global: Değişkenler
        public int say_saniye = 0;
        #endregion

        public frmKargo()
        {
            InitializeComponent();
        }

        private void frmKargo_Load(object sender, EventArgs e)
        {
            Global global = new Global
            {
                tmr = tmrZamanlama,
                frm = this,
                tCtrl = tabControl1
            };
            global.imgYukleniyor();

            mtxtGTcNo.Text = "13276502826";
            mtxtATcNo.Text = "20302268700";
        }

        #region A1: GroupBox'lar:

        #region 01: Gönderici
        private void mtxtGTcNo_TextChanged(object sender, EventArgs e)
        {
            Global global = new Global();
            global.sorgu = "SELECT * FROM musteriler WHERE durum = 1";
            global.tc_cek = mtxtGTcNo.Text;
            global.tcKontrol(errHataMesaji, mtxtGTcNo, true);

            if (global.tc_cek == global.db_tc)
            {
                cmbGKurumKisi.SelectedIndex = global.mus_kurum_kisi;
                rtxtGKurumDetayi.Text = global.mus_kurum_detay;
                txtGMusteriNo.Text = global.mus_no;
                txtGAdi.Text = global.mus_ad;
                txtGSoyadi.Text = global.mus_soyad;
                mtxtGTelefon.Text = global.mus_tel;
                txtGEposta.Text = global.mus_eposta;
            }
        }
        private void cmbGKurumKisi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbGKurumKisi.SelectedIndex == 0)
                rtxtGKurumDetayi.Enabled = true;
            else
                rtxtGKurumDetayi.Enabled = false;
        }

        private void cmbGUlke_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbGUlke.SelectedIndex != -1)
            {
                cmbGIl.Enabled = true;
                Global global = new Global();
                global.yol = @"Data Source=PCI-ACER\SQLSERVEREXP;Initial Catalog=ortak_adres;Integrated Security=True";
                global.sorgu = "SELECT sehir_adi FROM iller ORDER BY sehir_adi";
                global.sutun_adi = "sehir_adi";
                global.cmb = cmbGIl;
                global.dbBaglan(4);
            }
            else
                cmbGIl.Enabled = false;
        }

        private void cmbGIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbGIlce.SelectedIndex = -1;
            cmbGIlce.Items.Clear();
            cmbGMahalle.SelectedIndex = -1;
            cmbGMahalle.Items.Clear();

            if (cmbGIl.SelectedIndex != -1)
            {
                cmbGIlce.Enabled = true;
                Global global = new Global();
                global.yol = @"Data Source=PCI-ACER\SQLSERVEREXP;Initial Catalog=ortak_adres;Integrated Security=True";
                global.sorgu = "SELECT ilceler.sehir_id, iller.id, sehir_adi, ilce_adi FROM ilceler JOIN iller ON ilceler.sehir_id = iller.id WHERE sehir_adi = '" + cmbGIl.Text + "' ORDER BY ilce_adi";
                global.sutun_adi = "ilce_adi";
                global.cmb = cmbGIlce;
                global.dbBaglan(4);
            }
            else
                cmbGIlce.Enabled = false;
        }

        private void cmbGIlce_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbGMahalle.SelectedIndex = -1;
            cmbGMahalle.Items.Clear();

            if (cmbGIlce.SelectedIndex != -1)
            {
                cmbGMahalle.Enabled = true;
                Global global = new Global();
                global.yol = @"Data Source=PCI-ACER\SQLSERVEREXP;Initial Catalog=ortak_adres;Integrated Security=True";
                global.sorgu = "SELECT mahalleler.ilce_id, ilceler.id, ilce_adi, mahalle_adi FROM mahalleler JOIN ilceler ON mahalleler.ilce_id = ilceler.id WHERE ilce_adi = '" + cmbGIlce.Text + "' ORDER BY mahalle_adi";
                global.sutun_adi = "mahalle_adi";
                global.cmb = cmbGMahalle;
                global.dbBaglan(4);
            }
            else
                cmbGMahalle.Enabled = false;
        }

        private void cmbGMahalle_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtGPostaKodu.Enabled = true;
            rtxtGAdres.Enabled = true;
        }
        #endregion

        #region 02: Alıcı
        private void mtxtATcNo_TextChanged(object sender, EventArgs e)
        {
            Global global = new Global();
            global.sorgu = "SELECT * FROM musteriler WHERE durum = 1";
            global.tc_cek = mtxtATcNo.Text;
            global.tcKontrol(errHataMesaji, mtxtATcNo, true);

            if (global.tc_cek == global.db_tc)
            {
                cmbAKurumKisi.SelectedIndex = global.mus_kurum_kisi;
                rtxtAKurumDetayi.Text = global.mus_kurum_detay;
                txtAMusteriNo.Text = global.mus_no;
                txtAAdi.Text = global.mus_ad;
                txtASoyadi.Text = global.mus_soyad;
                mtxtATelefon.Text = global.mus_tel;
                txtAEposta.Text = global.mus_eposta;
            }
        }

        private void cmbAKurumKisi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAKurumKisi.SelectedIndex == 0)
                rtxtAKurumDetayi.Enabled = true;
            else
                rtxtAKurumDetayi.Enabled = false;
        }

        private void cmbAUlke_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAUlke.SelectedIndex != -1)
            {
                cmbAIl.Enabled = true;
                Global global = new Global();
                global.yol = @"Data Source=PCI-ACER\SQLSERVEREXP;Initial Catalog=ortak_adres;Integrated Security=True";
                global.sorgu = "SELECT sehir_adi FROM iller ORDER BY sehir_adi";
                global.sutun_adi = "sehir_adi";
                global.cmb = cmbAIl;
                global.dbBaglan(4);
            }
            else
                cmbAIl.Enabled = false;
        }

        private void cmbAIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbAIlce.SelectedIndex = -1;
            cmbAIlce.Items.Clear();
            cmbAMahalle.SelectedIndex = -1;
            cmbAMahalle.Items.Clear();

            if (cmbAIl.SelectedIndex != -1)
            {
                cmbAIlce.Enabled = true;
                Global global = new Global();
                global.yol = @"Data Source=PCI-ACER\SQLSERVEREXP;Initial Catalog=ortak_adres;Integrated Security=True";
                global.sorgu = "SELECT ilceler.sehir_id, iller.id, sehir_adi, ilce_adi FROM ilceler JOIN iller ON ilceler.sehir_id = iller.id WHERE sehir_adi = '" + cmbAIl.Text + "' ORDER BY ilce_adi";
                global.sutun_adi = "ilce_adi";
                global.cmb = cmbAIlce;
                global.dbBaglan(4);
            }
            else
                cmbAIlce.Enabled = false;
        }

        private void cmbAIlce_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbAMahalle.SelectedIndex = -1;
            cmbAMahalle.Items.Clear();

            if (cmbAIlce.SelectedIndex != -1)
            {
                cmbAMahalle.Enabled = true;
                Global global = new Global();
                global.yol = @"Data Source=PCI-ACER\SQLSERVEREXP;Initial Catalog=ortak_adres;Integrated Security=True";
                global.sorgu = "SELECT mahalleler.ilce_id, ilceler.id, ilce_adi, mahalle_adi FROM mahalleler JOIN ilceler ON mahalleler.ilce_id = ilceler.id WHERE ilce_adi = '" + cmbAIlce.Text + "' ORDER BY mahalle_adi";
                global.sutun_adi = "mahalle_adi";
                global.cmb = cmbAMahalle;
                global.dbBaglan(4);
            }
            else
                cmbAMahalle.Enabled = false;
        }

        private void cmbAMahalle_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtAPostaKodu.Enabled = true;
            rtxtAAdres.Enabled = true;
        }
        #endregion

        #endregion

        #region A2: Button'lar:
        private void btnKargoKaydet_Click(object sender, EventArgs e)
        {
            Global global = new Global();
            global.sorgu = "SELECT * FROM musteriler WHERE durum = 1";
            global.err = errHataMesaji;
            //global.bosMu(gboxGonderici);
            //global.bosMu(gboxGondericiAdres);
            //global.bosMu(gboxAlici);
            //global.bosMu(gboxAliciAdres);
            //global.bosMu(gboxOzet);

            if (global.hata_var_mi == false)
            {
                MessageBox.Show("Tebrikler Hatanız Yok!!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                global.txt = txtGMusteriNo;
                global.dbBaglan(5);
            }
        }

        private void btnKargoGuncelle_Click(object sender, EventArgs e)
        {

        }

        private void btnKargoSil_Click(object sender, EventArgs e)
        {

        }

        private void btnKargoTemizle_Click(object sender, EventArgs e)
        {
            Global global = new Global();
            global.frmTemizle(this);
        }
        #endregion

        private void cmbKargoTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            frmZarf zarf = new frmZarf();
            frmKoli koli = new frmKoli();

            if (cmbKargoTipi.SelectedIndex == 0)
            {
                zarf.ShowDialog();
                lblKargoTasima.Text = zarf.tasima_bedeli.ToString("0.##");
                lblKargoEkHiz.Text = zarf.ek_hizmet.ToString("0.##");
                lblKargoToplam.Text = zarf.toplam.ToString("0.##");
                lblKargoKdv.Text = zarf.kdv.ToString("0.##");
                lblKargoGenelTop.Text = zarf.genel_toplam.ToString("0.##");
            }
            else if (cmbKargoTipi.SelectedIndex == 1)
            {
                koli.ShowDialog();
                lblKargoTasima.Text = koli.tasima_bedeli.ToString("0.##");
                lblKargoEkHiz.Text = koli.ek_hizmet.ToString("0.##");
                lblKargoToplam.Text = koli.toplam.ToString("0.##");
                lblKargoKdv.Text = koli.kdv.ToString("0.##");
                lblKargoGenelTop.Text = koli.genel_toplam.ToString("0.##");
            }
        }

        private void tmrZamanlama_Tick(object sender, EventArgs e)
        {
            say_saniye++;
            if (say_saniye % 2 == 0)
            {
                tabControl1.Visible = true;
                tmrZamanlama.Stop();
            }
        }
    }
}
