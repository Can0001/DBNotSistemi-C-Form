using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DBNotSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        void Listele()
        {
            SqlCommand komut = new SqlCommand("Select * from TBLOGRENCİLER", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            SqlCommand komut2 = new SqlCommand("Select * from TBLNOTLAR", bgl.baglanti());
            SqlDataAdapter da2 = new SqlDataAdapter(komut2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Listele();
            TxtOrtalama.Enabled = false;
            TxtDurum.Enabled = false;
            BtnNotKaydet.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmKulupler frm = new FrmKulupler();
            frm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FrmDersler frm = new FrmDersler();
            frm.Show();
        }

        private void BtnNotKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBLNOTLAR (Ders,Ogrenci,Sınav1,Sınav2,Sınav3,Ortalama,Durum) values (@ders,@ogrenci,@sınav1,@sınav2,@sınav3,@ortalama,@durum)", bgl.baglanti());
            komut.Parameters.AddWithValue("@ders", TxtDers.Text);
            komut.Parameters.AddWithValue("@ogrenci", TxtOgrenci.Text);
            komut.Parameters.AddWithValue("@sınav1", TxtSınav1.Text);
            komut.Parameters.AddWithValue("@sınav2",TxtSınav2.Text);
            komut.Parameters.AddWithValue("@sınav3", TxtSınav3.Text);
            komut.Parameters.AddWithValue("@ortalama", TxtOrtalama.Text);
            komut.Parameters.AddWithValue("@durum",TxtDurum.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            Listele();
            TxtDers.Clear();
            TxtDurum.Clear();
            TxtOgrenci.Clear();
            TxtSınav1.Clear();
            TxtSınav2.Clear();
            TxtSınav3.Clear();
            TxtOrtalama.Clear();
            TxtDurum.Clear();

        }

        private void BtnHesapla_Click(object sender, EventArgs e)
        {
            double sinav1, sinav2, sinav3, ort;
            sinav1=Convert.ToDouble(TxtSınav1.Text);
            sinav2 = Convert.ToDouble(TxtSınav2.Text);
            sinav3=Convert.ToDouble(TxtSınav3.Text);
            ort=(sinav1+sinav2+sinav3)/3;
            TxtOrtalama.Text=ort.ToString();
            if (ort>=50)
            {
                TxtDurum.Text = "True";
            }
            else
            {
                TxtDurum.Text = "False";
            }
            BtnNotKaydet.Enabled = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtOgrenciAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            TxtOgrenciSoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            MskNumara.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            TxtSifre.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            TxtKulüp.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

        }

        private void BtnOgrenciKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBLOGRENCİLER (OgrenciAd,OgrenciSoyad,Numara,Sifre,Kulup) values (@ad,@soyad,@numara,@sifre,@kulup)", bgl.baglanti());
            komut.Parameters.AddWithValue("@ad", TxtOgrenciAd.Text);
            komut.Parameters.AddWithValue("@soyad",TxtOgrenciSoyad.Text);
            komut.Parameters.AddWithValue("@numara",MskNumara.Text);
            komut.Parameters.AddWithValue("@sifre", TxtSifre.Text);
            komut.Parameters.AddWithValue("@kulup", TxtKulüp.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            Listele();
            TxtOgrenciAd.Clear();
            TxtOgrenciSoyad.Clear();
            MskNumara.Clear();
            TxtSifre.Clear();
            TxtKulüp.Clear();
        }

        private void BtnOgrenciGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBLOGRENCİLER set OgrenciAd=@ad,OgrenciSoyad?@soyad,Numara=@numara,Sifre=@sifre,Kulup=@kulup where OgrenciId=@ıd", bgl.baglanti());
            komut.Parameters.AddWithValue("@ad", TxtOgrenciAd.Text);
            komut.Parameters.AddWithValue("@soyad", TxtOgrenciSoyad.Text);
            komut.Parameters.AddWithValue("@numara", MskNumara.Text);
            komut.Parameters.AddWithValue("@sifre", TxtSifre.Text);
            komut.Parameters.AddWithValue("@kulup", TxtKulüp.Text);
            komut.Parameters.AddWithValue("@ıd", dataGridView1.CurrentRow.Cells[0].Value);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            Listele();
            TxtOgrenciAd.Clear();
            TxtOgrenciSoyad.Clear();
            MskNumara.Clear();
            TxtSifre.Clear();
            TxtKulüp.Clear();
        }

        private void BtnBirlesikTablolar_Click(object sender, EventArgs e)
        {
            FrrmBirlesikTablolar frm=new FrrmBirlesikTablolar();
            frm.Show();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtDers.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            TxtOgrenci.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            TxtSınav1.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            TxtSınav2.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            TxtSınav3.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
            TxtOrtalama.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();
            TxtDurum.Text = dataGridView2.CurrentRow.Cells[7].Value.ToString();
        }
    }
}
