using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DBNotSistemi
{
    public partial class FrrmBirlesikTablolar : Form
    {
        public FrrmBirlesikTablolar()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        void Listele()
        {
            SqlCommand komut = new SqlCommand("Select OgrenciAd,OgrenciSoyad,Numara,Sifre,KulupAd,DersAd,Sınav1,Sınav2,Sınav3,Ortalama,Durum from TBLNOTLAR join TBLDERSLER on TBLDERSLER.DersId=TBLNOTLAR.Ders join TBLOGRENCİLER on TBLOGRENCİLER.OgrenciId=TBLNOTLAR.Ogrenci join TBLKULUPLER \r\non TBLKULUPLER.KulupId=TBLOGRENCİLER.Kulup", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }
        private void FrrmBirlesikTablolar_Load(object sender, EventArgs e)
        {
            Listele();
            dataGridView1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select DersAd,OgrenciAd,OgrenciSoyad,Sınav1,Sınav2,Sınav3,Ortalama,Durum from TBLNOTLAR join TBLDERSLER on TBLNOTLAR.Ders=TBLDERSLER.DersId join TBLOGRENCİLER on TBLNOTLAR.Ogrenci=TBLOGRENCİLER.OgrenciId", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select OgrenciAd,OgrenciSoyad,Numara,KulupAd from TBLOGRENCİLER join TBLKULUPLER on TBLKULUPLER.KulupId=TBLOGRENCİLER.KULUP", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SqlCommand komut=new SqlCommand("Select OgrenciAd,OgrenciSoyad,Ortalama from TBLNOTLAR join TBLOGRENCİLER on TBLOGRENCİLER.OgrenciId=TBLNOTLAR.Ogrenci where Ortalama=(Select Max(Ortalama) from TBLNOTLAR)", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt =new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select OgrenciAd,OgrenciSoyad,Ortalama from TBLNOTLAR join TBLOGRENCİLER on TBLOGRENCİLER.OgrenciId=TBLNOTLAR.Ogrenci where Ortalama=(Select Min(Ortalama) from TBLNOTLAR)", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Visible = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select OgrenciAd,OgrenciSoyad,Ortalama from TBLNOTLAR join TBLOGRENCİLER on TBLOGRENCİLER.OgrenciId=TBLNOTLAR.Ogrenci where Ortalama>=(Select AVG(Ortalama) from TBLNOTLAR)", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt=new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select OgrenciAd,OgrenciSoyad,Ortalama from TBLNOTLAR join TBLOGRENCİLER on TBLOGRENCİLER.OgrenciId=TBLNOTLAR.Ogrenci where Ortalama=(Select Ortalama from TBLNOTLAR where Ortalama<50)", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt) ;
            dataGridView2 .DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select OgrenciAd,OgrenciSoyad,DersAd,Sınav1,Sınav2,Sınav3,Ortalama from TBLNOTLAR join TBLOGRENCİLER \r\non TBLOGRENCİLER.OgrenciId=TBLNOTLAR.Ogrenci join TBLDERSLER on TBLDERSLER.DersId=TBLNOTLAR.Ders where DersAd='Matematik'", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt) ;
            dataGridView2.DataSource= dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select OgrenciAd,OgrenciSoyad,DersAd,Sınav1,Sınav2,Sınav3,Ortalama from TBLNOTLAR join TBLOGRENCİLER \r\non TBLOGRENCİLER.OgrenciId=TBLNOTLAR.Ogrenci join TBLDERSLER on TBLDERSLER.DersId=TBLNOTLAR.Ders where DersAd='Türkçe'", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select OgrenciAd,OgrenciSoyad,DersAd,Sınav1,Sınav2,Sınav3,Ortalama from TBLNOTLAR join TBLOGRENCİLER \r\non TBLOGRENCİLER.OgrenciId=TBLNOTLAR.Ogrenci join TBLDERSLER on TBLDERSLER.DersId=TBLNOTLAR.Ders where DersAd='Algoritma'", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select OgrenciAd,OgrenciSoyad,DersAd,Sınav1,Sınav2,Sınav3,Ortalama from TBLNOTLAR join TBLOGRENCİLER \r\non TBLOGRENCİLER.OgrenciId=TBLNOTLAR.Ogrenci join TBLDERSLER on TBLDERSLER.DersId=TBLNOTLAR.Ders where DersAd='Biyoloji'", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select OgrenciAd,OgrenciSoyad,DersAd,Sınav1,Sınav2,Sınav3,Ortalama from TBLNOTLAR join TBLOGRENCİLER \r\non TBLOGRENCİLER.OgrenciId=TBLNOTLAR.Ogrenci join TBLDERSLER on TBLDERSLER.DersId=TBLNOTLAR.Ders where DersAd='Atatürk İlke İnkılap'", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }
    }
}
