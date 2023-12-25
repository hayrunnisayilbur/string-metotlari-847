using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace string_metotlari_847
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuyuk_Click(object sender, EventArgs e)
        {
            string mesaj = lblMesaj.Text;
            lblMesaj.Text = mesaj.ToUpper();
        }

        private void btnKucult_Click(object sender, EventArgs e)
        {
            string mesaj = lblMesaj.Text;
            lblMesaj.Text = mesaj.ToLower();
        }

        private void lblKarakter_Click(object sender, EventArgs e)
        {
            // MessageBox.Show ("toplam karakter" + lblMesaj.Text.Leng + "karakter vardır.");
            string mesaj = $"toplam {lblMesaj.Text.Length} karakter vardır.";

            MessageBox.Show(mesaj);


        }

        private void btnMesajVer_Click(object sender, EventArgs e)
        {
            lblMesaj.Text = $"merhaba dünya, ben {txtMesaj.Text}!";
        }

        private void btnBirlestir_Click(object sender, EventArgs e)
        {
            string mesaj1 = "merhaba dünya";
            string mesaj2 = "ben nisa";

            //string yeniMesaj = mesaj1 + mesaj2;

            string yeniMesaj = String.Concat(mesaj1, mesaj2);

            lblMesaj.Text = yeniMesaj;
        }

        private void btnSiraGetir_Click(object sender, EventArgs e)
        {
            //5. sıradaki harfi getir

            string mesaj = lblMesaj.Text;
            //mesaj[4] //char türündedir.

            MessageBox.Show($"6. sıradaki harf : {mesaj[5]}");
        }

        private void btnKacis1_Click(object sender, EventArgs e)
        {
            string mesaj = "merhaba ben \"nisa\". \rNasılsın?";
            lblMesaj.Text = mesaj;

            //  \  "  n r t
        }

        private void btnKarsilastir_Click(object sender, EventArgs e)
        {
            string isim1 = "nisa";
            string isim2 = "nisa";
            string isim3 = "ömer";

            bool durum1 = isim1.Equals(isim2);
            bool durum2 = isim2 == isim2;

            bool durum3 = isim1.Equals(isim3);
            bool durum4 = isim1 == isim3;

            string mesaj = $"durum : {durum1} --> durum2 {durum2} \rdurum3 : {durum3} --> durum4 {durum4}";
            MessageBox.Show(mesaj);

        }

        private void btnBicim_Click(object sender, EventArgs e)
        {
            int a = 10;
            int b = 20;
            int c = 100;

            string mesaj = $"{a} * {b} = {c}";

            MessageBox.Show(mesaj);
        }

        private void btnCompere_Click(object sender, EventArgs e)
        {
            string isim1 = "nisa";
            string isim2 = "kübra";
            string isim3 = "sukeyna";
            string isim4 = "rabia";
            string isim5 = "deniz";

            int sonuc1 = String.Compare(isim1, isim2);   //0
            int sonuc2 = String.Compare(isim1, isim3);   //1
            int sonuc3 = String.Compare(isim1, isim4);   //-1
            int sonuc4 = String.Compare(isim1, isim5);   //1
            int sonuc5 = String.Compare(isim1, isim2, true);

            //Message.Box($"sonuc : {sonuc}");

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string mesaj1 = lblMesaj.Text.Remove(7);
            string mesaj2 = lblMesaj.Text.Remove(0, 4);  //baslangıc, adet

            MessageBox.Show(mesaj1);
            MessageBox.Show(mesaj2);
        }

        private void btnCoptain_Click(object sender, EventArgs e)
        {
            bool durum = lblMesaj.Text.Contains(txtMesaj.Text);
            MessageBox.Show($"{txtMesaj.Text} ...... {durum}");
        }

        private void btnReploce_Click(object sender, EventArgs e)
        {
            string mesaj = lblMesaj.Text.Replace("nisa", txtMesaj.Text);
            lblMesaj.Text = mesaj;
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = lblMesaj.Text.Split(' ').ToList(); //bosluk sembolune gore ayırır.
        }
    }
}
