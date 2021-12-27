using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Net;
using System.Windows.Forms;
using System.Net.Mail;

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

        #region A1: Global Değişkenler
        SqlConnection baglan = new SqlConnection();
        SqlCommand komut = new SqlCommand();
        SqlDataReader veri_oku;
        ComboBox cmb;
        TextBox txt;
        Form frm;
        Control ctrl;
        //ErrorProvider err;
        #endregion

        #region A2: Veritabanına Bağlan:
        public string yol = @"Data Source=PCI-ACER\SQLSERVEREXP;Initial Catalog=kargo_takip;Integrated Security=True";
        public string sorgu, sutun_adi;
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
                else if (tip == 2) btnSifreAl();
                else if (tip == 3) veriGetir();
                else
                    MessageBox.Show("Veritabanına bağlantı sağlandı fakat herhangi bir işlem yapılmadı!", "Uyarı !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                baglan.Close();
            }
            catch (Exception exp)
            {
                //MessageBox.Show("Beklenmedik bir hata oluştu!", "HATA !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(exp.ToString(), "Hata Mesajı !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show(hataSatiriniBul(exp).ToString() + " numaralı satırda hata var!", "Hata Mesajı !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region A3: Verileri İşle:

        #region 01: btnGirisYap()
        public string txt_kadi, txt_sifre, db_kadi, db_sifre;
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

        #region 02: btnSifreAl()
        public string db_email, txt_email;
        public bool gonder;
        public void btnSifreAl()
        {
            veri_oku = komut.ExecuteReader();
            while (veri_oku.Read())
            {
                db_email = veri_oku["email"].ToString();
                send_konu = "Şifre Hatırlatma Servisi";
                send_mesaj = "<b>Kullanıcı Adınız: </b>" + veri_oku["kullanici_adi"] + "<br />" +
                             "<b>Şifreniz .............: </b>" + veri_oku["sifre"];
                if (db_email.ToLower() == txt_email.ToLower())
                {
                    gonder = true;
                    emailGonder();
                    break;
                }
            }
            if (txt_email == "")
                MessageBox.Show("Lütfen bir mail adresi giriniz", "Uyarı !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (txt_email != "" && gonder == false)
                MessageBox.Show("Bu email adresine ait bir kullanıcı bulunamadı!", "Uyarı !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        #endregion

        #region 03: emailGonder()
        public string smtp_email = "btsmtpdemo@gmail.com";
        public string smtp_sifre = "Smtp785*?";
        public string send_baslik = "Kargo Takip Uygulaması";
        public string send_konu, send_mesaj;
        public void emailGonder()
        {
            try
            {
                SmtpClient client = new SmtpClient
                {
                    Credentials = new NetworkCredential(smtp_email, smtp_sifre),
                    Port = 587,
                    Host = "smtp.gmail.com",
                    EnableSsl = true
                };

                MailMessage mail = new MailMessage
                {
                    From = new MailAddress(smtp_email, send_baslik),
                    Subject = send_konu,
                    Body = send_mesaj,
                    IsBodyHtml = true
                };

                mail.To.Add(txt_email);
                client.Send(mail);

                MessageBox.Show("Email gönderme işlemi başarılı bir şekilde tamamlandı!", "BAŞARILI !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form.ActiveForm.Close();
            }
            catch (Exception exp)
            {
                //MessageBox.Show("Beklenmedik bir sorun oluştu!", "HATA !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(exp.ToString());
            }
        }

        #endregion

        #region 04: veriGetir()
        public string db_tc;
        public bool db_durum;
        public int mus_kurum_kisi;
        public string mus_kurum_detay, mus_no, mus_ad, mus_soyad, mus_tel, mus_eposta;

        public void veriGetir()
        {
            veri_oku = komut.ExecuteReader();
            while (veri_oku.Read())
            {
                db_tc = veri_oku["tc"].ToString();
                db_durum = Convert.ToBoolean(veri_oku["durum"]);

                if (tc_cek == db_tc && db_durum)
                {
                    mus_kurum_kisi = Convert.ToInt16(veri_oku["musteri_tip"]);
                    mus_kurum_detay = veri_oku["kurum_detay"].ToString();
                    mus_no = veri_oku["musteri_no"].ToString();
                    mus_ad = veri_oku["ad"].ToString();
                    mus_soyad = veri_oku["soyad"].ToString();
                    mus_tel = veri_oku["telefon"].ToString();
                    mus_eposta = veri_oku["eposta"].ToString();
                    break;
                }
            }
        }
        #endregion

        #endregion

        #region A4: Kontrolleri Sağla:

        #region 01: frmTemizle()
        public void frmTemizle(Control ctrl)
        {
            string baslik = "Onaylama";
            string mesaj = "Temizleme işlemini onaylıyor musunuz?";
            foreach (Control c in ctrl.Controls)
            {
                if (typeof(TextBox) == c.GetType())
                    ((TextBox)(c)).Text = "";
                else if (typeof(MaskedTextBox) == c.GetType())
                    ((MaskedTextBox)(c)).Text = "";
                else if (typeof(RichTextBox) == c.GetType())
                    ((RichTextBox)(c)).Text = "";
                else if (typeof(ComboBox) == c.GetType())
                    ((ComboBox)(c)).SelectedIndex = -1;
                else
                    frmTemizle(c);
            }
        }
        #endregion

        #region 02: tcKontrol();
        public string tc_cek, tc_bul;
        public void tcKontrol(ErrorProvider err, MaskedTextBox txt, bool veri_al)
        {
            if (tc_cek.Length > 8)
            {
                string str_sayi = "";

                for (int i = 0; i < 9; i++)
                    str_sayi += tc_cek[i].ToString();

                int tek = 0, cift = 0;

                for (int i = 0; i < 9; i += 2)
                    tek += str_sayi[i] - '0';

                for (int i = 1; i < 9; i += 2)
                    cift += str_sayi[i] - '0';

                int bas_10 = ((tek * 7) - cift) % 10;
                int ilk_9 = 0;

                for (int i = 0; i < 9; i++)
                    ilk_9 += str_sayi[i] - '0';

                int bas_11 = (ilk_9 + bas_10) % 10;
                tc_bul = str_sayi + bas_10.ToString() + bas_11.ToString();

                if (tc_cek.Length == 11 && (tc_cek != tc_bul))
                    err.SetError(txt, "T.C. kimlik numarası yanlış girildi!");
                else if(tc_cek == tc_bul && veri_al)
                    dbBaglan(3);
                else
                    err.SetError(txt, "");
            }
        }
        #endregion

        #endregion
    }
}
