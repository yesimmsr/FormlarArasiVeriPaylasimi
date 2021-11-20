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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        //Ürün Listesi bu tuple da tutulacak
        List<(int id, string urunKodu, string urunAdi, string Birim, decimal Fiyat, string Sembol, string Aciklama)> UrunListesi = new List<(int id, string urunKodu, string urunAdi, string Birim, decimal Fiyat, string Sembol, string Aciklama)>();

        private void btnUrun_Click(object sender, EventArgs e)
        {
            //Yeni ürün tanımlaması yapılacak

            //showDialog(); cevap bekler
            //Show(); formu açar cevap beklemez devam eder.

            var productForm = new ProductForm();
            productForm.ShowDialog();
            var seciliUrun = productForm.seciliUrun; //üst formdan alt forma değer gönderir


            if (productForm.isSuccess == true) //formda işlem olduğunda işlemi gerçekleştirir.
            {

                //Yeni bir ürün kaydı ise koleksiyona ekle
                if (seciliUrun.id == 0)
                {
                    //yeni ürün kaydetmek için
                    seciliUrun.id = GetUrunSiradakiId();
                    UrunListesi.Add(seciliUrun);
                }
                SetUrunlerDataSourceGridView(); //koleksiyonda ürün ekle/sil olduğunda kendini düncelleyecek.
            }
        }

        public int GetUrunSiradakiId()
        {
            return UrunListesi.Count;
        }

        public void SetUrunlerDataSourceGridView()
        {
            lstUrunler.Items.Clear();
            foreach (var urun in UrunListesi)
            {
                string stringItem = $"id => {urun.id}, ÜrünKod =>{urun.urunKodu}, ÜrünAdı =>{urun.urunAdi}, Birim=>{urun.Fiyat.ToString("N2")}{urun.Sembol}, Aciklama =>{urun.Aciklama}";

                lstUrunler.Items.Add(stringItem);
            }
        }

    }

}
