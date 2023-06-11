namespace DBNotSistemi
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnOgrenciKaydet = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.MskNumara = new System.Windows.Forms.MaskedTextBox();
            this.TxtKulüp = new System.Windows.Forms.TextBox();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.TxtOgrenciSoyad = new System.Windows.Forms.TextBox();
            this.TxtOgrenciAd = new System.Windows.Forms.TextBox();
            this.BtnOgrenciSil = new System.Windows.Forms.Button();
            this.BtnOgrenciGuncelle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.TxtDurum = new System.Windows.Forms.TextBox();
            this.TxtOrtalama = new System.Windows.Forms.TextBox();
            this.TxtSınav3 = new System.Windows.Forms.TextBox();
            this.TxtSınav2 = new System.Windows.Forms.TextBox();
            this.TxtSınav1 = new System.Windows.Forms.TextBox();
            this.TxtOgrenci = new System.Windows.Forms.TextBox();
            this.TxtDers = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.BtnHesapla = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.BtnNotKaydet = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnBirlesikTablolar = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(577, 292);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(19, 28);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(577, 255);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(602, 340);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenciler";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(12, 358);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(602, 303);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Notlar";
            // 
            // BtnOgrenciKaydet
            // 
            this.BtnOgrenciKaydet.Location = new System.Drawing.Point(6, 28);
            this.BtnOgrenciKaydet.Name = "BtnOgrenciKaydet";
            this.BtnOgrenciKaydet.Size = new System.Drawing.Size(141, 64);
            this.BtnOgrenciKaydet.TabIndex = 4;
            this.BtnOgrenciKaydet.Text = "Kaydet";
            this.BtnOgrenciKaydet.UseVisualStyleBackColor = true;
            this.BtnOgrenciKaydet.Click += new System.EventHandler(this.BtnOgrenciKaydet_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.MskNumara);
            this.groupBox3.Controls.Add(this.TxtKulüp);
            this.groupBox3.Controls.Add(this.TxtSifre);
            this.groupBox3.Controls.Add(this.TxtOgrenciSoyad);
            this.groupBox3.Controls.Add(this.TxtOgrenciAd);
            this.groupBox3.Controls.Add(this.BtnOgrenciSil);
            this.groupBox3.Controls.Add(this.BtnOgrenciGuncelle);
            this.groupBox3.Controls.Add(this.BtnOgrenciKaydet);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(620, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(606, 340);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Öğrenci Kontrol";
            // 
            // MskNumara
            // 
            this.MskNumara.Location = new System.Drawing.Point(447, 117);
            this.MskNumara.Mask = "0000";
            this.MskNumara.Name = "MskNumara";
            this.MskNumara.Size = new System.Drawing.Size(153, 29);
            this.MskNumara.TabIndex = 18;
            // 
            // TxtKulüp
            // 
            this.TxtKulüp.Location = new System.Drawing.Point(447, 221);
            this.TxtKulüp.Name = "TxtKulüp";
            this.TxtKulüp.Size = new System.Drawing.Size(153, 29);
            this.TxtKulüp.TabIndex = 17;
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(447, 170);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(153, 29);
            this.TxtSifre.TabIndex = 16;
            // 
            // TxtOgrenciSoyad
            // 
            this.TxtOgrenciSoyad.Location = new System.Drawing.Point(447, 72);
            this.TxtOgrenciSoyad.Name = "TxtOgrenciSoyad";
            this.TxtOgrenciSoyad.Size = new System.Drawing.Size(153, 29);
            this.TxtOgrenciSoyad.TabIndex = 14;
            // 
            // TxtOgrenciAd
            // 
            this.TxtOgrenciAd.Location = new System.Drawing.Point(447, 25);
            this.TxtOgrenciAd.Name = "TxtOgrenciAd";
            this.TxtOgrenciAd.Size = new System.Drawing.Size(153, 29);
            this.TxtOgrenciAd.TabIndex = 13;
            // 
            // BtnOgrenciSil
            // 
            this.BtnOgrenciSil.Location = new System.Drawing.Point(76, 98);
            this.BtnOgrenciSil.Name = "BtnOgrenciSil";
            this.BtnOgrenciSil.Size = new System.Drawing.Size(141, 64);
            this.BtnOgrenciSil.TabIndex = 6;
            this.BtnOgrenciSil.Text = "Sil";
            this.BtnOgrenciSil.UseVisualStyleBackColor = true;
            // 
            // BtnOgrenciGuncelle
            // 
            this.BtnOgrenciGuncelle.Location = new System.Drawing.Point(153, 28);
            this.BtnOgrenciGuncelle.Name = "BtnOgrenciGuncelle";
            this.BtnOgrenciGuncelle.Size = new System.Drawing.Size(141, 64);
            this.BtnOgrenciGuncelle.TabIndex = 5;
            this.BtnOgrenciGuncelle.Text = "Güncelle";
            this.BtnOgrenciGuncelle.UseVisualStyleBackColor = true;
            this.BtnOgrenciGuncelle.Click += new System.EventHandler(this.BtnOgrenciGuncelle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(329, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Öğrenci Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Öğrenci Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(359, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Numara:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(389, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Şifre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(377, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "Kulüp:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.TxtDurum);
            this.groupBox4.Controls.Add(this.TxtOrtalama);
            this.groupBox4.Controls.Add(this.TxtSınav3);
            this.groupBox4.Controls.Add(this.TxtSınav2);
            this.groupBox4.Controls.Add(this.TxtSınav1);
            this.groupBox4.Controls.Add(this.TxtOgrenci);
            this.groupBox4.Controls.Add(this.TxtDers);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.BtnHesapla);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.BtnNotKaydet);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(620, 358);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(606, 303);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Not Kontrol";
            // 
            // TxtDurum
            // 
            this.TxtDurum.Location = new System.Drawing.Point(447, 218);
            this.TxtDurum.Name = "TxtDurum";
            this.TxtDurum.Size = new System.Drawing.Size(153, 29);
            this.TxtDurum.TabIndex = 27;
            // 
            // TxtOrtalama
            // 
            this.TxtOrtalama.Location = new System.Drawing.Point(447, 155);
            this.TxtOrtalama.Name = "TxtOrtalama";
            this.TxtOrtalama.Size = new System.Drawing.Size(153, 29);
            this.TxtOrtalama.TabIndex = 26;
            // 
            // TxtSınav3
            // 
            this.TxtSınav3.Location = new System.Drawing.Point(83, 189);
            this.TxtSınav3.Name = "TxtSınav3";
            this.TxtSınav3.Size = new System.Drawing.Size(153, 29);
            this.TxtSınav3.TabIndex = 25;
            // 
            // TxtSınav2
            // 
            this.TxtSınav2.Location = new System.Drawing.Point(83, 144);
            this.TxtSınav2.Name = "TxtSınav2";
            this.TxtSınav2.Size = new System.Drawing.Size(153, 29);
            this.TxtSınav2.TabIndex = 24;
            // 
            // TxtSınav1
            // 
            this.TxtSınav1.Location = new System.Drawing.Point(83, 98);
            this.TxtSınav1.Name = "TxtSınav1";
            this.TxtSınav1.Size = new System.Drawing.Size(153, 29);
            this.TxtSınav1.TabIndex = 23;
            // 
            // TxtOgrenci
            // 
            this.TxtOgrenci.Location = new System.Drawing.Point(447, 68);
            this.TxtOgrenci.Name = "TxtOgrenci";
            this.TxtOgrenci.Size = new System.Drawing.Size(153, 29);
            this.TxtOgrenci.TabIndex = 22;
            // 
            // TxtDers
            // 
            this.TxtDers.Location = new System.Drawing.Point(447, 23);
            this.TxtDers.Name = "TxtDers";
            this.TxtDers.Size = new System.Drawing.Size(153, 29);
            this.TxtDers.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(369, 223);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 24);
            this.label12.TabIndex = 21;
            this.label12.Text = "Durum:";
            // 
            // BtnHesapla
            // 
            this.BtnHesapla.Location = new System.Drawing.Point(153, 28);
            this.BtnHesapla.Name = "BtnHesapla";
            this.BtnHesapla.Size = new System.Drawing.Size(141, 64);
            this.BtnHesapla.TabIndex = 5;
            this.BtnHesapla.Text = "Hesapla";
            this.BtnHesapla.UseVisualStyleBackColor = true;
            this.BtnHesapla.Click += new System.EventHandler(this.BtnHesapla_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(351, 158);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 24);
            this.label11.TabIndex = 20;
            this.label11.Text = "Ortalama:";
            // 
            // BtnNotKaydet
            // 
            this.BtnNotKaydet.Location = new System.Drawing.Point(6, 28);
            this.BtnNotKaydet.Name = "BtnNotKaydet";
            this.BtnNotKaydet.Size = new System.Drawing.Size(141, 64);
            this.BtnNotKaydet.TabIndex = 4;
            this.BtnNotKaydet.Text = "Kaydet";
            this.BtnNotKaydet.UseVisualStyleBackColor = true;
            this.BtnNotKaydet.Click += new System.EventHandler(this.BtnNotKaydet_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 24);
            this.label10.TabIndex = 19;
            this.label10.Text = "Sınav3:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(387, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "Ders:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(368, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "Öğrenci:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 24);
            this.label9.TabIndex = 18;
            this.label9.Text = "Sınav2:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 24);
            this.label8.TabIndex = 17;
            this.label8.Text = "Sınav1:";
            // 
            // BtnBirlesikTablolar
            // 
            this.BtnBirlesikTablolar.Location = new System.Drawing.Point(1011, 667);
            this.BtnBirlesikTablolar.Name = "BtnBirlesikTablolar";
            this.BtnBirlesikTablolar.Size = new System.Drawing.Size(215, 64);
            this.BtnBirlesikTablolar.TabIndex = 6;
            this.BtnBirlesikTablolar.Text = "Birleşik Tablolar";
            this.BtnBirlesikTablolar.UseVisualStyleBackColor = true;
            this.BtnBirlesikTablolar.Click += new System.EventHandler(this.BtnBirlesikTablolar_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 667);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(215, 64);
            this.button7.TabIndex = 13;
            this.button7.Text = "Kulüpler";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(233, 667);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(215, 64);
            this.button8.TabIndex = 14;
            this.button8.Text = "Dersler";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1238, 749);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.BtnBirlesikTablolar);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnOgrenciKaydet;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TxtKulüp;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.TextBox TxtOgrenciSoyad;
        private System.Windows.Forms.TextBox TxtOgrenciAd;
        private System.Windows.Forms.Button BtnOgrenciSil;
        private System.Windows.Forms.Button BtnOgrenciGuncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox TxtDurum;
        private System.Windows.Forms.TextBox TxtOrtalama;
        private System.Windows.Forms.TextBox TxtSınav3;
        private System.Windows.Forms.TextBox TxtSınav2;
        private System.Windows.Forms.TextBox TxtSınav1;
        private System.Windows.Forms.TextBox TxtOgrenci;
        private System.Windows.Forms.TextBox TxtDers;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button BtnHesapla;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BtnNotKaydet;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnBirlesikTablolar;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.MaskedTextBox MskNumara;
    }
}

