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
        #region B1: GLOBAL

        #region class: Desi
        class Desi
        {
            public double en, boy, yukseklik;

            #region void: hesapla()
            public double hesapla()
            {
                return (en * boy * yukseklik) / 3000;
            }
            #endregion
        }
        #endregion

        #region enum: Tip
        enum Tip
        {
            zarf = 0,
            koli = 1
        }
        #endregion

        #endregion
        public frmKoli()
        {
            InitializeComponent();
        }

        private void frmPaket_Load(object sender, EventArgs e)
        {
            Desi desi = new Desi
            {
                en = 10,
                boy = 20,
                yukseklik = 40
            };
            desi.hesapla();
        }
    }
}
