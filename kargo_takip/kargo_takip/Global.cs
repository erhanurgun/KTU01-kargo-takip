using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace kargo_takip
{
    class Global
    {
        #region hataSatiriniBul(Exception ex):
        public int hataSatiriniBul(Exception ex)
        {
            var satir_no = 0;
            const string satir_ara = ":line ";
            var veri = ex.StackTrace.LastIndexOf(satir_ara);
            if (veri != -1)
            {
                var satir_nerede = ex.StackTrace.Substring(veri + satir_ara.Length);
                if (int.TryParse(satir_nerede, out satir_no))
                {
                }
            }
            return satir_no;
        }
        #endregion

        #region A1: Değişkenler
        public string yol, sorgu, sutun_adi;
        public string txt_kadi, txt_sifre, db_kadi, db_sifre;
        public bool durum = false, db_durum;

        SqlConnection baglan = new SqlConnection();
        SqlCommand komut = new SqlCommand();
        SqlDataReader veri_oku;
        ComboBox cmb;
        Form frm;
        #endregion

        #region A2: Veritabanına Bağlan: dbBaglan()
        public void dbBaglan(int tip)
        {
            try
            {
                baglan.ConnectionString = yol;
                komut.CommandText = sorgu;
                komut.Connection = baglan;
                komut.CommandType = CommandType.Text;

                if (baglan.State == ConnectionState.Closed) baglan.Open();

                if (tip == 1) btnGirisYap();
                else if (tip == 2) cmbVeriOku();

                baglan.Close();
            }
            catch (Exception exp)
            {
                //MessageBox.Show("Beklenmedik bir hata oluştu!", "HATA !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(hataSatiriniBul(exp).ToString() + " numaralı satırda hata var!", "Hata Mesajı !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        
        #region A3: Verileri Oku:

        #region 01: btnGirisYap()
        public void btnGirisYap()
        {
            veri_oku = komut.ExecuteReader();
            while (veri_oku.Read())
            {
                db_kadi = veri_oku["kullanici_adi"].ToString();
                db_sifre = veri_oku["sifre"].ToString();

                if (txt_kadi == db_kadi && txt_sifre == db_sifre)
                {
                    //Form.ActiveForm.Hide();
                    frm = new frmKargo();
                    frm.ShowDialog();
                    break;
                }
            }
            
            if (txt_kadi != db_kadi || txt_sifre != db_sifre)
                MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış!", "Uyarı !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        #endregion

        #region 02: cmbVeriOku():
        public void cmbVeriOku()
        {
            veri_oku = komut.ExecuteReader();

            if (veri_oku.Read()) durum = true;

            if (durum)
                while (veri_oku.Read())
                    cmb.Items.Add(veri_oku[sutun_adi]);
            else
                MessageBox.Show("Veri bulunamadı!", "UYARI !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        #endregion

        #endregion
    }
}
