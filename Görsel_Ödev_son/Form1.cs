using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Görsel_Ödev_son
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void arabaekle(object sender, EventArgs e)
        {
            Frmkisi kisi = new Frmkisi() { Text = "Araba Ekle", StartPosition = FormStartPosition.CenterParent };

            if (kisi.ShowDialog() != DialogResult.OK)
                return;

            ListViewItem eleman = new ListViewItem(new string[]
            {
                kisi.ID.ToString(),
                kisi.ilantarih.ToString(),
                kisi.telefon.ToString(),
                kisi.sahip,
                kisi.model,
                kisi.seri,
                kisi.marka,
                kisi.yil.ToString(),
                kisi.yakit,
                kisi.vites,
                kisi.aracdurum,
                kisi.fiyat,
                kisi.km,
                kisi.kasa,
                kisi.gucu,
                kisi.hacim,
                kisi.cekis,
                kisi.renk,
                kisi.garanti,
                kisi.kimden,
                kisi.aciklama,
                kisi.sehir,

               
            });
            listView1.Items.Add(eleman);
            
        }

        private void arabaduzenle(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;

            ListViewItem eleman = listView1.SelectedItems[0];

            Frmkisi kisi = new Frmkisi() { Text = "Araba Duzenle", StartPosition= FormStartPosition.CenterParent,
                ID = decimal.Parse(eleman.SubItems[0].Text),
                ilantarih = DateTime.Parse(eleman.SubItems[1].Text),
                telefon = eleman.SubItems[2].Text,
                sahip = eleman.SubItems[3].Text,
                model = eleman.SubItems[4].Text,
                seri = eleman.SubItems[5].Text,
                marka = eleman.SubItems[6].Text,
                yil = eleman.SubItems[7].Text,
                yakit = eleman.SubItems[8].Text,
                vites = eleman.SubItems[9].Text,
                aracdurum = eleman.SubItems[10].Text,
                fiyat = eleman.SubItems[11].Text,
                km = eleman.SubItems[12].Text,
                kasa = eleman.SubItems[13].Text,
                gucu = eleman.SubItems[14].Text,
                hacim = eleman.SubItems[15].Text,
                cekis = eleman.SubItems[16].Text,
                renk = eleman.SubItems[17].Text,
                garanti = eleman.SubItems[18].Text,
                kimden = eleman.SubItems[19].Text,
                aciklama = eleman.SubItems[20].Text,
                sehir = eleman.SubItems[21].Text,

            };
            if(kisi.ShowDialog()!= DialogResult.OK)
                return;

            eleman = new ListViewItem(new string[]
            {
                kisi.ID.ToString(),
                kisi.ilantarih.ToString(),
                kisi.telefon.ToString(),
                kisi.sahip,
                kisi.model,
                kisi.seri,
                kisi.marka,
                kisi.yil.ToString(),
                kisi.yakit,
                kisi.vites,
                kisi.aracdurum,
                kisi.fiyat,
                kisi.km,
                kisi.kasa,
                kisi.gucu,
                kisi.hacim,
                kisi.cekis,
                kisi.renk,
                kisi.garanti,
                kisi.kimden,
                kisi.aciklama,
                kisi.sehir,


            });
        }

        private void arabasil(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;

            var cevap = MessageBox.Show("Seçili Alanı Silmek İstediğinizden Emin misiniz?", "Silinsin mi?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (cevap == DialogResult.No)
                return;

           ListViewItem eleman = listView1.SelectedItems[0];
            listView1.Items.Remove(eleman);
        }
    }

}
