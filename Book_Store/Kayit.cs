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
    public partial class Kayit : Form
    {
        public Kayit()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-3SE8LH5;Initial Catalog=bookstore;Integrated Security=True");

        private void anasayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            Kayit kayit = new Kayit();
            this.Hide();
            
        }

        private void bntkayit_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = ("INSERT INTO dbo.kayit (username,userpassword,usertel,useremail) VALUES ('"+txtkullanici.Text+"','"+txtsifre.Text+"','"+txtel.Text+"','"+txtemail.Text+"')");
            komut.ExecuteNonQuery();
            baglanti.Close();


        }

        private void kayitOlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kayit ol sayfasındasınız");
        }
    }
}
//Data Source=DESKTOP-3SE8LH5;Initial Catalog=pulsesstore;Integrated Security=True