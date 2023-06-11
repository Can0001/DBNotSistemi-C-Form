using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBNotSistemi
{
    public partial class FrmDersler : Form
    {
        public FrmDersler()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl=new SqlBaglantisi();
        void Listele()
        {
            SqlCommand komut=new SqlCommand("Select * from TBLDERSLER",bgl.baglanti());
            SqlDataAdapter da=new SqlDataAdapter(komut);
            DataTable dt=new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void FrmDersler_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("İnsert into TBLDERSELER (DersAd) values (@ad)", bgl.baglanti());
            komut.Parameters.AddWithValue("@ad", textBox1.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            textBox1.Clear();
        }
    }
}
