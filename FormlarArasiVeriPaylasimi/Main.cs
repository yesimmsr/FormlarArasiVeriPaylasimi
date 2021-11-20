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

        List<string> MainBirimler = new List<string>()
        {
            "Adet", "Kg", "Litre", "Paket", "Koli"
        };

        List<string> MainSymbols = new List<string>()
        {
            "₺","$","€","£"
        };

        public ProductForm GetProductForm()
        {
            var form = new ProductForm();
            form.Birimler = MainBirimler; //form.Birimler => productform daki birimler
            form.Symbols = MainSymbols;//form.Symbols => productform daki birimler
            return form;
        }


        //Ürün Listesi bu tuple da tutulacak
        List<(int id, string urunKodu, string urunAdi, string Birim, decimal Fiyat, string Sembol, string Aciklama)> UrunListesi = new List<(int id, string urunKodu, string urunAdi, string Birim, decimal Fiyat, string Sembol, string Aciklama)>();

        private void btnUrun_Click(object sender, EventArgs e)
        {
            //Yeni ürün tanımlaması yapılacak

            //showDialog(); cevap bekler
            //Show(); formu açar cevap beklemez devam eder.

            var productForm =  GetProductForm();
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
                SetUrunlerDataSourceGridView(); //koleksiyonda ürün ekle/sil olduğunda kendini güncelleyecek.
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

                string birim = MainBirimler[Convert.ToInt32(urun.Birim)];
                string symbol = MainBirimler[Convert.ToInt32(urun.Sembol)];

                string stringItem = $"id => {urun.id}, ÜrünKod =>{urun.urunKodu}, ÜrünAdı =>{urun.urunAdi}, Birim=>{birim} ,Fiyat=>{urun.Fiyat.ToString("N2")}{symbol}, Aciklama =>{urun.Aciklama}";

                lstUrunler.Items.Add(stringItem);
            }
        }

        private void lstUrunler_DoubleClick(object sender, EventArgs e)
        {
            if (lstUrunler.SelectedIndex > -1) //hata vermesin kontrolü aynı zamanda seçim olup olmadığına bakar.
            {
                var selectedUrun = UrunListesi[lstUrunler.SelectedIndex]; // seçilen ürünü alır. value type olduğu için referans güncellemesi yapmaz.
                
                //aynı formu hem yeni kayıt(insert) hemde güncelleme(update) işlemi için kullanılır.
                var productForm =  GetProductForm();
                productForm.seciliUrun = selectedUrun; //seçilen ürün forma set edilir.
                productForm.ShowDialog();


                //value type olduğu için ValueType gibi davranıyor o yüzden bilgileri tekrar koleksiyondaki ile değiştirildi.
                UrunListesi[lstUrunler.SelectedIndex] = productForm.seciliUrun;  // yukardaki(if in altındaki tanımlama) value değerinden ürünleri güncelledik.

                SetUrunlerDataSourceGridView(); //lstbox ı güncellesin productform da güncelleme olursa diye

            }

           
        }
    }

}
