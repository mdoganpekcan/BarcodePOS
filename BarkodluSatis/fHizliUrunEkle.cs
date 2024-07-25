using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarkodluSatis
{
    public partial class fHizliUrunEkle : Form
    {
        public fHizliUrunEkle()
        {
            InitializeComponent();
        }

        BarkodluSatisDbEntities db = new BarkodluSatisDbEntities();
        private void TxtUrunAra_TextChanged(object sender, EventArgs e)
        {
            if (TxtUrunAra.Text != "")
            {
                string urunAd = TxtUrunAra.Text;
                var urunler = db.Urun.Where(x => x.UrunAdi.Contains(urunAd)).ToList();
                GridUrunler.DataSource = urunler;
            }
        }

        private void GridUrunler_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridUrunler.Rows.Count > 0)
            {
                string barkod = GridUrunler.CurrentRow.Cells["UrunBarkod"].Value.ToString();
                string urunad = GridUrunler.CurrentRow.Cells["UrunAdi"].Value.ToString();
                double fiyat = Convert.ToDouble(GridUrunler.CurrentRow.Cells["UrunSatisFiyat"].Value.ToString());
                int id = Convert.ToInt32(lblButonId.Text);

                var guncellenecekBtn = db.HizliUrun.Find(id);
                guncellenecekBtn.Barkod = barkod;
                guncellenecekBtn.UrunAdi = urunad;
                guncellenecekBtn.UrunFiyat = fiyat;
                db.SaveChanges();
                MessageBox.Show("Buton Tanımlanmıştır");
                fSatis fSatis=(fSatis)Application.OpenForms["fSatis"];
                if (fSatis != null)
                {
                    Button Btn = fSatis.Controls.Find("BtnHizli" + id, true).FirstOrDefault() as Button;
                    Btn.Text = urunad + "\n" + fiyat.ToString("C2");
                }
            }
        }

        private void chBoxTumGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxTumGoster.Checked)
            {
                GridUrunler.DataSource = db.Urun.Where(x => x.UrunBirim == "Adet").ToList();
            }
            else
            {
                GridUrunler.DataSource = null;
            }
        }
    }
}
