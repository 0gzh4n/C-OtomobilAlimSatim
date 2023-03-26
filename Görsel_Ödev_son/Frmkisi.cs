using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Görsel_Ödev_son
{
    public partial class Frmkisi : Form
    {
        public Frmkisi()
        {
            InitializeComponent();
        }
        public decimal ID {
            get { return nmID.Value; } 
            set { nmID.Value = value; }
        }
        public string sahip
        {
            get { return txtilan.Text; }
            set { txtilan.Text = value; }
        }

        public DateTime ilantarih
        {
            get { return dttarih.Value; }
            set { dttarih.Value = value; }
        }

        public string telefon
        {
            get { return mtxttelefon.Text; }
            set { mtxttelefon.Text = value; }
        }

        public string marka
        {
            get { return txtmarka.Text; }
            set { txtmarka.Text = value; }
        }

        public string seri
        {
            get { return txtseri.Text; }
            set { txtseri.Text = value; }
        }

        public string model
        {
            get { return txtmodel.Text; }
            set { txtmodel.Text = value; }
        }

        public string yil
        {
            get { return mtxtyil.Text; }
            set { mtxtyil.Text = value; }
        }

        public string yakit
        {
            get { return txtyakit.Text; }
            set { txtyakit.Text = value; }
        }

        public string vites
        {
            get { return txtyakit.Text; }
            set { txtyakit.Text = value; }
        }

        public string aracdurum
        {
            get { return txtaracdurum.Text; }
            set { txtaracdurum.Text = value; }
        }

        public string fiyat
        {
            get { return mtxtfiyat.Text; }
            set { mtxtfiyat.Text = value; }
        }

        public string km
        {
            get { return mtxtkm.Text; }
            set { mtxtkm.Text = value; }
        }

        public string kasa
        {
            get { return txtkasa.Text; }
            set { txtkasa.Text = value; }
        }

        public string gucu
        {
            get { return mtxtguc.Text; }
            set { mtxtguc.Text = value; }
        }

        public string hacim
        {
            get { return mtxthacim.Text; }
            set { mtxthacim.Text = value; }
        }

        public string cekis
        {
            get { return txtcekis.Text; }
            set { txtcekis.Text = value; }
        }

        public string renk
        {
            get { return txtrenk.Text; }
            set { txtrenk.Text = value; }
        }

        public string garanti
        {
            get { return txtgaranti.Text; }
            set { txtgaranti.Text = value; }
        }

        public string kimden
        {
            get { return txtkimden.Text; }
            set { txtkimden.Text = value; }
        }

        public string aciklama
        {
            get { return txtaciklama.Text; }
            set { txtaciklama.Text = value; }
        }

        public string sehir
        {
            get { return txtsehir.Text; }
            set { txtsehir.Text = value; }
        }

        private void btnTamam_Clik(object sender, EventArgs e)
        {
            if (txtaracdurum.Text.Trim() == "")
            {
        MessageBox.Show("Ilan sahibi bos birakilamaz", "Veri Kontrolu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtaracdurum.Focus();
            return;
     
            }
        }

        private void ilankontrol(object sender, EventArgs e)
        {
            var t = sender as TextBox;
            if (t.Text.Trim() == "")
                errorProvider1.SetError(mtxttelefon, "Lutfen Dogru giriniz");
            else
                errorProvider1.SetError(t, "");
        }

        private void btntamam_Click(object sender, EventArgs e)
        {
            if (txtilan.Text.Trim() == "")
            {
                DialogResult dialogResult = MessageBox.Show("ilan sahibi bos olamaz");
                txtilan.Focus();
                return;
            }
            this.DialogResult= DialogResult.OK;
        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void TelefonKontrol(object sender, EventArgs e)
        {
            if (!mtxttelefon.MaskCompleted)
                errorProvider1.SetError(mtxttelefon, "Gecerli telefon giriniz.");
            else
                errorProvider1.SetError(mtxttelefon, "");
        }
    }
}
