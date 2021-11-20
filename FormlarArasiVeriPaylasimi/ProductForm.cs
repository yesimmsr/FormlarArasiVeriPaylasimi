using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormlarArasiVeriPaylasimi
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        List<string> Birimler = new List<string>()
        {
            "Adet", "Kg", "Litre", "Paket", "Koli"
        };

        List<string> Symbols = new List<string>()
        {
            "₺","$","€","£"
        };

        //Solution geneline açmak
        //Seçili ürün
        public (int id, string urunKodu, string urunAdi, string Birim, decimal Fiyat, string Sembol, string Aciklama) seciliUrun;

        public bool isSuccess = false;

        private void ProductForm_Load(object sender, EventArgs e)
        {
            FormFill();
        }

        public void FormFill()
        {
            FillBirim();
            FillSymbol();
        }

        public void FillBirim()
        {
            cmbBirim.Items.Clear();
            foreach (var birim in Birimler)
            {
                cmbBirim.Items.Add(birim);
            }
            cmbBirim.SelectedIndex = 0; // defaultta seçili gelsin
        }

        public void FillSymbol()
        {
            cmbSembol.Items.Clear();
            foreach (var symbol in Symbols)
            {
                cmbSembol.Items.Add(symbol);
            }
            cmbSembol.SelectedIndex = 0; // defaultta seçili gelsin
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            //Yeni butona tıklandığında Formu ilk açılıştaki haline dönüştür resetler
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //formun üzerindeli kontrollerden değeri alıp secilUrunu doldurmak

            string urunKodu = txtUrunKodu.Text;
            string urunAdi = txtUrunAdi.Text;
            string birim = cmbBirim.SelectedIndex.ToString();
            decimal fiyat = nuFiyat.Value;
            string symbol = cmbSembol.SelectedIndex.ToString();
            string aciklama = txtAciklama.Text;

            //yukarıdaki tuple urun listesindeki sıra ile aynı olmalıdır.
            seciliUrun = (0, urunKodu, urunAdi, birim, fiyat, symbol, aciklama);
            isSuccess = true; //buton tarafından işlem yapılmış olacak
            this.Close();
        }

       
    }
}
