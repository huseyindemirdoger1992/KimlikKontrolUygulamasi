using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework;

namespace KimlikKontrolUygulaması
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long TCKN = long.Parse(textBox3.Text);
            string Ad, Soyad;
            Ad = textBox1.Text;
            Soyad = textBox2.Text;
            int DY = dateTimePicker1.Value.Year;
            KimlikBilgileri.KPSPublicSoapClient KK = new KimlikBilgileri.KPSPublicSoapClient();
           bool Durum = KK.TCKimlikNoDogrula(TCKN,Ad,Soyad,DY);
            if (Durum == true) 
            {
                MessageBox.Show("Girilen Kimlik Bilgileri Doğrulandı.","Geçerli Durum",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            if (Durum != true)
            {
                MessageBox.Show("Girilen Kimlik Bilgileri Yanlış.", "Geçersiz Durum", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
