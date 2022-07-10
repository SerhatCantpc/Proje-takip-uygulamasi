using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Atolye_Mutfak_Proje_Takip
{
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
           // this.IsMdiContainer = true; //Form içinde form açılabilir yapıyoruz
            MySqlConnection con;
            MySqlCommand cmd;
            MySqlDataReader dr;



              MySqlConnection baglanti = new
  MySqlConnection("Server=185.118.141.56;Database=sevktakip;user=sevktakip;Pwd=Pavk7eptcu3e;SslMode=none");
              baglanti.Open();
             string mps = new MySqlCommand("SELECT COUNT(*) FROM üretime_giren_projeler", baglanti).ExecuteScalar().ToString();
             ps.Text = mps;
               baglanti.Close();


            baglanti.Open();
            string tps = new MySqlCommand("SELECT COUNT(*) FROM tamamlanan_projeler", baglanti).ExecuteScalar().ToString();
            tp.Text = tps;
            baglanti.Close();


        }





        private void anasayfa_Load(object sender, EventArgs e)
        {

            timer1.Start();
            InitializeComponent();



        }
  


        

        private void btn_app_close_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void yetki_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void proje_ekle_new_Click(object sender, EventArgs e)
        {

            //panel4.Hide();
            proje_ekle form2sec2 = new proje_ekle();
           //   form2sec2.MdiParent = this;//bu formu parent olarak veriyoruz.
            form2sec2.Show();

        }

        private void mevcut_projeler_new_Click(object sender, EventArgs e)
        {

            
            Form2 form2sec = new Form2();
           // form2sec.MdiParent = this;  
            form2sec.Show();
        }

        private void tamamlanan_projeler_new_Click(object sender, EventArgs e)
        {

     
            Tamamlanan_Projeler form2sec1 = new Tamamlanan_Projeler();
           // form2sec1.MdiParent = this;
            form2sec1.Show();
        }

        private void anasyf_Click(object sender, EventArgs e)
        {

            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tarih.Text = DateTime.Now.ToString();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
