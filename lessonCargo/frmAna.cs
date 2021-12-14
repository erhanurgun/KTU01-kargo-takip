using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace lessonCargo
{
    public partial class frmAna : Form
    {
        #region A1: GLOBAL

        #region class: dbBaglan
        class dbBaglan
        {
            public string yol, sorgu, sutun_adi, index_id;

            #region void: calistir()
            public void calistir(ComboBox cmb, Form frm)
            {
                try
                {
                    SqlConnection baglan = new SqlConnection();
                    SqlCommand komut = new SqlCommand();
                    SqlDataReader veri_oku;
                    baglan.ConnectionString = yol;

                    if (baglan.State == ConnectionState.Closed)
                        baglan.Open();

                    komut.CommandText = sorgu;
                    komut.Connection = baglan;
                    komut.CommandType = CommandType.Text;

                    veri_oku = komut.ExecuteReader();

                    int i = 0;
                    while (veri_oku.Read())
                    {
                        cmb.Items.Add(veri_oku[sutun_adi]);
                        ////cmb.ValueMember = veri_oku[index_id].ToString();
                        i++;
                    }


                    baglan.Close();
                }
                catch (Exception exp)
                {
                    //MessageBox.Show("Beklenmedik bir hata oluştu!", "Hata - 1 !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    MessageBox.Show(exp.ToString());
                    frm.Close();
                }
            }
            #endregion
        }

        #endregion

        

        #endregion

        public frmAna()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        #region A2: ComboBox
        private void cmbUlke_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUlke.SelectedIndex != -1)
            {
                cmbIl.Enabled = true;

                dbBaglan db = new dbBaglan();
                db.yol = @"Data Source=PCI-ACER\SQLSERVEREXP;Initial Catalog=toplu_adres;Integrated Security=True";
                db.sorgu = "SELECT * FROM iller ORDER BY sehir_adi ASC";
                db.index_id = "id";
                db.sutun_adi = "sehir_adi";
                db.calistir(cmbIl, this);

                //String s;
                //s = cmbIl.SelectedValue.toString();

                //cmbIl.valuemember = "id";
                //cmbIl.displaymember = "name";
                //cmbIl.datasource = dt;

                cmbIl.SelectedValue = db.index_id;
            }
            else
                cmbIl.Enabled = false;
        }

        private void cmbIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbIlce.SelectedIndex = -1;
            cmbIlce.Items.Clear();
            cmbMahalle.SelectedIndex = -1;
            cmbMahalle.Items.Clear();

            if (cmbIl.SelectedIndex != -1)
            {
                cmbIlce.Enabled = true;

                dbBaglan db = new dbBaglan();
                db.yol = @"Data Source=PCI-ACER\SQLSERVEREXP;Initial Catalog=toplu_adres;Integrated Security=True";
                db.sorgu = "SELECT * FROM ilceler WHERE sehir_id = " + cmbIl.SelectedValue + " ORDER BY ilce_adi ASC";
                db.index_id = "id";
                db.sutun_adi = "ilce_adi";
                db.calistir(cmbIlce, this);

                cmbIlce.SelectedValue = db.index_id;

            }
            else
                cmbIlce.Enabled = false;

        }

        private void cmbIlce_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbMahalle.SelectedIndex = -1;
            cmbMahalle.Items.Clear();

            if (cmbIlce.SelectedIndex != -1)
            {
                cmbMahalle.Enabled = true;

                dbBaglan db = new dbBaglan();
                db.yol = @"Data Source=PCI-ACER\SQLSERVEREXP;Initial Catalog=toplu_adres;Integrated Security=True";
                db.sorgu = "SELECT * FROM mahalleler WHERE ilce_id = " + cmbIlce.SelectedValue + " ORDER BY mahalle_adi ASC";
                db.sutun_adi = "mahalle_adi";
                db.calistir(cmbMahalle, this);
            }
            else
                cmbMahalle.Enabled = false;
        }

        private void cmbMahalle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMahalle.SelectedIndex != -1)
                rtxtAdres.Enabled = true;
            else
                rtxtAdres.Enabled = false;
        }
        #endregion

        private void cmbKargoTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            frmZarf zarf = new frmZarf();
            frmKoli koli = new frmKoli();

            if (cmbKargoTipi.SelectedIndex == 0)
            {
                zarf.ShowDialog();
                lblTasima.Text = zarf.tasima_bedeli.ToString("0.##");
                lblEkHiz.Text = zarf.ek_hizmet.ToString("0.##");
                lblToplam.Text = zarf.toplam.ToString("0.##");
                lblKdv.Text = zarf.kdv.ToString("0.##");
                lblGenelTop.Text = zarf.genel_toplam.ToString("0.##");
            }
            else if (cmbKargoTipi.SelectedIndex == 1)
                koli.ShowDialog();
        }
    }
}
