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
        ErrorProvider hata;
        #endregion

        #region A2: Veritabanına Bağlan: dbBaglan()
        public string yol, sorgu, sutun_adi;
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
                else if (tip == 3) emailGonder();

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

        #region 02: Email Gönder: emailGonder()
        public string smtp_email = "gmail_email_adresiniz";
        public string smtp_sifre = "gmail_email_sifreniz";
        public string smtp_baslik = "Kargo Takip Uygulaması";
        public string send_konu = "Şifre Hatırlatma İşlemi";
        public string send_mesaj, db_email, txt_email;
        public bool gonder = false;
        public void emailGonder()
        {
            veri_oku = komut.ExecuteReader();
            while (veri_oku.Read())
            {
                db_email = veri_oku["email"].ToString();
                send_mesaj = "<h1>Şifre Hatırlatma Servisi</h1>" +
                             "<b>Kullanıcı Adınız: </b>" + veri_oku["kullanici_adi"] + "<br />" +
                             "<b>Şifreniz .............: </b>" + veri_oku["sifre"];
                if (db_email.ToLower() == txt_email.ToLower())

                {
                    gonder = true;
                    try
                    {
                        SmtpClient client = new SmtpClient
                        {
                            Credentials = new NetworkCredential(smtp_email, smtp_sifre),
                            Port = 587,
                            Host = "smtp.gmail.com",
                            EnableSsl = true,
                        };

                        MailMessage mail = new MailMessage
                        {
                            From = new MailAddress(smtp_email, smtp_baslik),
                            Subject = send_konu,
                            Body = send_mesaj,
                            IsBodyHtml = true,
                        };

                        mail.To.Add(txt_email);
                        client.Send(mail);

                        MessageBox.Show("Email gönderme işlemi başarılı bir şekilde tamamlandı!", "BAŞARILI !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Form.ActiveForm.Close();
                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show("Beklenmedik bir sorun oluştu!", "HATA !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //MessageBox.Show(exp.ToString());
                    }
                    break;
                }
            }
            if (txt_email == "")
                MessageBox.Show("Lütfen bir mail adresi giriniz", "Uyarı !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (txt_email != "" && gonder == false)
                MessageBox.Show("Bu email adresine ait bir kullanıcı bulunamadı!", "Uyarı !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        #endregion

        

        #endregion
    }
}
