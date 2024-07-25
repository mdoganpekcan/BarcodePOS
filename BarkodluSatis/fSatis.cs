using BarkodluSatis.Classes;
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
    public partial class fSatis : Form
    {
        public fSatis()
        {
            InitializeComponent();
        }

        BarkodluSatisDbEntities db = new BarkodluSatisDbEntities();

        private void fSatis_Load(object sender, EventArgs e)
        {
            HizliButonDoldur();
            BtnHizliOde5.Text = 5.ToString("C2");
            BtnHizliOde10.Text = 10.ToString("C2");
            BtnHizliOde20.Text = 20.ToString("C2");
            BtnHizliOde50.Text = 50.ToString("C2");
            BtnHizliOde100.Text = 100.ToString("C2");
            BtnHizliOde200.Text = 200.ToString("C2");
        }

        private void HizliButonDoldur()
        {
            var hizliurun = db.HizliUrun.ToList();
            foreach (var item in hizliurun)
            {
                Button BtnHizli = this.Controls.Find("BtnHizli" + item.Id, true).FirstOrDefault() as Button;
                if (BtnHizli != null)
                {
                    double fiyat = Islemler.DoubleYap(item.UrunFiyat.ToString());
                    BtnHizli.Text = item.UrunAdi + "\n" + fiyat.ToString("C2");
                }
            }

        }

        private void BtnHizli_Click(object sender, EventArgs e)
        {
            Button Btn = (Button)sender;
            int BtnId = Convert.ToInt32(Btn.Name.ToString().Substring(8, Btn.Name.Length - 8));

            if (Btn.Text.ToString().StartsWith("-"))
            {
                fHizliUrunEkle fHizliBtnEkle = new fHizliUrunEkle();
                fHizliBtnEkle.lblButonId.Text = BtnId.ToString();
                fHizliBtnEkle.ShowDialog();
            }
            else
            {
                
                var UrunBarkod = db.HizliUrun.Where(a => a.Id == BtnId).Select(a => a.Barkod).FirstOrDefault();
                var Urun = db.Urun.Where(a => a.UrunBarkod == UrunBarkod).FirstOrDefault();
                ListeyeUrunGetir(Urun, UrunBarkod, Convert.ToDouble(TxtMiktar.Text));
            }
        }

        private void BtnHizliSil_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Button Btn = (Button)sender;
                if (!Btn.Text.StartsWith("-"))
                {
                    int btnid = Convert.ToInt32(Btn.Name.ToString().Substring(8, Btn.Name.Length - 8));
                    ContextMenuStrip menustrip = new ContextMenuStrip();
                    ToolStripMenuItem menuSil = new ToolStripMenuItem("Sil - Buton No:" + btnid.ToString());
                    menuSil.Click += Sil_Click;
                    menustrip.Items.Add(menuSil);
                    this.ContextMenuStrip = menustrip;
                }
            }
        }

        private void Sil_Click(object sender, EventArgs e)
        {
            int btnid = Convert.ToInt32(sender.ToString().Substring(15, sender.ToString().Length - 15));
            var silinecekBtn = db.HizliUrun.Find(btnid);
            silinecekBtn.Barkod = "-";
            silinecekBtn.UrunAdi = "-";
            silinecekBtn.UrunFiyat = 0;
            db.SaveChanges();
            Button Btn = this.Controls.Find("BtnHizli" + btnid, true).FirstOrDefault() as Button;
            double fiyat= 0;
            Btn.Text = "-\n" + fiyat.ToString("C2");
        }
        private void TxtBarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string barkod = TxtBarkod.Text.Trim();

                if (barkod.Length <= 2)
                {
                    TxtMiktar.Text = barkod;
                    TxtBarkod.Clear();
                    TxtBarkod.Focus();
                }
                else
                {
                    if (db.Urun.Any(a=> a.UrunBarkod == barkod))
                    {
                        var urun = db.Urun.Where(a => a.UrunBarkod == barkod).FirstOrDefault();
                        ListeyeUrunGetir(urun, barkod, Convert.ToDouble(TxtMiktar.Text));
                    }
                    else
                    {
                        int OnEk = Convert.ToInt32(barkod.Substring(0, 2));
                        if (db.Terazi.Any(a=> a.TeraziOnEk==OnEk))
                        {
                            string TeraziBarkod = barkod.Substring(2, 5);
                            if (db.Urun.Any(a=> a.UrunBarkod==TeraziBarkod))
                            {
                                var urunterazi = db.Urun.Where(a => a.UrunBarkod == TeraziBarkod).FirstOrDefault();
                                double TeraziMiktar = Convert.ToDouble(barkod.Substring(7, 5)) / 1000;
                                ListeyeUrunGetir(urunterazi, TeraziBarkod, TeraziMiktar);
                            }
                            else
                            {
                                Console.Beep(1000, 1000);
                                MessageBox.Show("Terazi Ürün ekleme sayfası");
                            }
                        }
                        else
                        {
                            Console.Beep(1000, 1000);
                            MessageBox.Show("Ürün ekleme sayfası");
                        }
                    }
                }
                GridSatisListesi.ClearSelection();
                GenelToplam();
                TxtBarkod.Focus();
            }
        }

        private void ListeyeUrunGetir(Urun urun, string barkod, double miktar)
        {
            int satirSayisi = GridSatisListesi.Rows.Count;
            //double miktar = Convert.ToDouble(TxtMiktar.Text);
            bool eklenmisMi = false;

            if (satirSayisi > 0)
            {
                for (int i = 0; i < satirSayisi; i++)
                {
                    if (GridSatisListesi.Rows[i].Cells["Barkod"].Value.ToString() == barkod)
                    {
                        GridSatisListesi.Rows[i].Cells["Miktar"].Value = miktar + Convert.ToDouble(GridSatisListesi.Rows[i].Cells["Miktar"].Value);
                        GridSatisListesi.Rows[i].Cells["Toplam"].Value = Math.Round(Convert.ToDouble(GridSatisListesi.Rows[i].Cells["Miktar"].Value) * Convert.ToDouble(GridSatisListesi.Rows[i].Cells["Fiyat"].Value), 2);
                        eklenmisMi = true;
                    }
                }
            }
            if (!eklenmisMi)
            {
                GridSatisListesi.Rows.Add();
                GridSatisListesi.Rows[satirSayisi].Cells["Barkod"].Value = barkod;
                GridSatisListesi.Rows[satirSayisi].Cells["UrunAdi"].Value = urun.UrunAdi;
                GridSatisListesi.Rows[satirSayisi].Cells["Birim"].Value = urun.UrunBirim;
                GridSatisListesi.Rows[satirSayisi].Cells["Fiyat"].Value = urun.UrunSatisFiyat;
                GridSatisListesi.Rows[satirSayisi].Cells["Miktar"].Value = miktar;
                GridSatisListesi.Rows[satirSayisi].Cells["KDVTutar"].Value = urun.UrunKDVTutari;
                GridSatisListesi.Rows[satirSayisi].Cells["Toplam"].Value = Math.Round(miktar * (double)urun.UrunSatisFiyat, 2);
            }
            GenelToplam();
        }

        private void GenelToplam()
        {
            if (GridSatisListesi.Rows.Count >= 0)
            {
                double toplam = 0;

                for (int i = 0; i < GridSatisListesi.Rows.Count; i++)
                {
                    toplam += Convert.ToDouble(GridSatisListesi.Rows[i].Cells["Toplam"].Value);
                }
                TxtBGenelToplam.Text = toplam.ToString("C2");
                TxtBarkod.Clear();
                TxtBarkod.Focus();
            }
        }

        private void GridSatisListesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                GridSatisListesi.Rows.Remove(GridSatisListesi.CurrentRow);
                GridSatisListesi.ClearSelection();
                GenelToplam();
                TxtBarkod.Focus();
            }
        }

        private void BtnNum_Click(object sender, EventArgs e)
        {
            Button Btn = (Button)sender;

            if (Btn.Text == ",")
            {
                int virgul = TxtBNum.Text.Count(x => x == ',');

                if (virgul < 1)
                {
                    TxtBNum.Text += Btn.Text;
                }
            }
            else if (Btn.Text == "Sil")
            {
                if (TxtBNum.Text.Length > 0)
                {
                    TxtBNum.Text = TxtBNum.Text.Substring(0, TxtBNum.Text.Length - 1);
                }
            }
            else
            {
                TxtBNum.Text += Btn.Text;
            }
        }

        private void BtnAdet_Click(object sender, EventArgs e)
        {
            if (TxtBNum.Text != "")
            {
                TxtMiktar.Text = TxtBNum.Text;
                TxtBNum.Clear();
                TxtBarkod.Clear();
                TxtBarkod.Focus();
            }
        }

        private void BtnOdenen_Click(object sender, EventArgs e)
        {
            if (TxtBNum.Text != "")
            {
                double sonuc = Islemler.DoubleYap(TxtBNum.Text) - Islemler.DoubleYap(TxtBGenelToplam.Text);
                LblParaUstu.Text = sonuc.ToString("C2");
                TxtBNum.Clear();
                TxtBarkod.Focus();
            }
        }

        private void BtnBarkod_Click(object sender, EventArgs e)
        {
            if (TxtBNum.Text != "")
            {
                if (db.Urun.Any(x => x.UrunBarkod == TxtBNum.Text))
                {
                    var urun = db.Urun.Where(x => x.UrunBarkod == TxtBNum.Text).FirstOrDefault();
                    ListeyeUrunGetir(urun, TxtBNum.Text, Convert.ToDouble(TxtMiktar.Text));
                }
                else
                {
                    Console.Beep(900, 1000);
                    MessageBox.Show("Ürün Bulunamadı");
                }
                TxtBNum.Clear();
                TxtBarkod.Focus();
            }
        }

        private void BtnHizliOde_Click(object sender, EventArgs e)
        {
            Button Btn = (Button)sender;
            double sonuc = Islemler.DoubleYap(Btn.Text) - Islemler.DoubleYap(TxtBGenelToplam.Text);
            LblParaUstu.Text = sonuc.ToString("C2");
        }
    }
}
