using Hamburgerci.BL.Abstract;
using Hamburgerci.BL.Concrete;
using Hamburgerci.DAL.EF.Abstract;
using Hamburgerci.DAL.EF.Concrete;
using Hamburgerci.Entities.Concrete;

namespace Hamburgerci.WinUI
{
    public partial class Form1 : Form
    {
        readonly  IKullaniciManager kullaniciManager;
        public Form1()
        {
            InitializeComponent();
            kullaniciManager = new KullaniciManager();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //int sonuc = kullaniciDAL.Add(new Kullanici()
            //{
            //    Adi = txtKullanici.Text,
            //    Soyadi = "yilmaz",
            //    KullaniciAdi=txtKullanici.Text,
            //    Sifre= txtSifre.Text
            //});

            //if (sonuc > 0)
            //    MessageBox.Show("Kayit Basarili");
            //else
            //    MessageBox.Show("Hata olustu");

            int sonuc = kullaniciManager.Add(new Kullanici()
            {
                Adi = txtKullanici.Text,
                Soyadi = "yilmaz",
                KullaniciAdi = txtKullanici.Text,
                Sifre = txtSifre.Text
            });

            if (sonuc > 0)
                MessageBox.Show("Kayit Basarili");
            else
                MessageBox.Show("Hata olustu");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var kullanici = kullaniciManager
            //   .FindByUserName(txtKullanici.Text, txtSifre.Text);

            var kullanici = kullaniciManager.Find(p=>p.KullaniciAdi==txtKullanici.Text&& p.Sifre==txtSifre.Text);

            if (kullanici != null)
                MessageBox.Show(kullanici.Adi + " " + kullanici.Soyadi);

            
        
        }   
    }
}