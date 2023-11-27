using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sınıf_olusturma_847
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            oyuncu oyuncu1 = new oyuncu();
            oyuncu1.Id = "12545245735454";
            oyuncu1.Ad = "hayrunnisa";
            oyuncu1.Soyad = "yılbur";
            oyuncu1.Posta = "hayrunnisayilbur@gmail.com";
            oyuncu1.Puan = 100;
            oyuncu1.KayitTarih = DateTime.Now;
            oyuncu1.Aktif = false;

            MessageBox.Show("Ad:" + oyuncu1.Ad + "\nPuan:"
                            + oyuncu1.Puan + "\nAktif :"
                            + oyuncu1.Aktif);
        }
    }
}
