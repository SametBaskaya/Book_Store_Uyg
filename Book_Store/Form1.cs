using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Book_Store
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-3SE8LH5;Initial Catalog=bookstore;Integrated Security=True;MultipleActiveResultSets=True");
        private void btngiris_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();

            string kullanicibilgi = txtkullanici.Text;
            string sifre2 = txtsifre.Text;
            

            string sorgu = "SELECT userpassword FROM dbo.kayit WHERE username='" + kullanicibilgi+ "'";
            SqlCommand calistir = new SqlCommand(sorgu, baglanti);
            int sifre =Convert.ToInt32(calistir.ExecuteScalar());
            

       

            if (txtkullanici.Text==kullanicibilgi && txtsifre.Text==sifre.ToString())
            {
                Kullanici kullanici = new Kullanici();
                kullanici.Show();
                this.Hide();
            }
            else if (kullanicibilgi == "user" && sifre2 == "123")
            {
                Kullanici kullanici = new Kullanici();
                kullanici.Show();
                this.Hide();
            }
            else if (kullanicibilgi == "admin" && sifre2 == "admin")
            {
                Anasayfa anasyfa = new Anasayfa();
                Admin admin = new Admin();
                admin.Show();
                this.Hide();
            }
            else
            {
                lblsonuc.Text = "Kullanıcı adı veya şifre hatalı";
            }
            baglanti.Close();
        }
        public void girisyap()
        {
            string kullanici = txtkullanici.Text;
            int sifre = int.Parse(txtsifre.Text);
        }

        private void btnkayit_Click(object sender, EventArgs e)
        {
            Kayit kayitol = new Kayit();
            kayitol.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
