using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Book_Store
{

    public partial class Kullanici : Form
    {
        public Kullanici()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-3SE8LH5;Initial Catalog=bookstore;Integrated Security=True;MultipleActiveResultSets=True");
        ListView lst = new ListView();
        public void progressolustur()
        { 
        }
        public void verigoster()
        {
            listkitap.Items.Clear();
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();

            SqlCommand komutgstr = new SqlCommand();
            komutgstr.Connection = baglanti;
            komutgstr.CommandText = ("Select * from dbo.kitap");
            SqlDataReader oku = komutgstr.ExecuteReader();
            int left = 450;
            int top = 10;
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["kitap_adi"].ToString();
                ekle.SubItems.Add(oku["kitap_yazari"].ToString());
                ekle.SubItems.Add(oku["kitap_tur"].ToString());
                ekle.SubItems.Add(oku["stok_miktari"].ToString());
                ekle.SubItems.Add(oku["toplam_adet"].ToString());
                ekle.SubItems.Add(oku["satilan_miktar"].ToString());
                ekle.SubItems.Add(oku["begeni"].ToString());

                string sorgustok = "SELECT stok_miktari FROM dbo.kitap WHERE kitap_adi='"+ekle.Text+"'";
                SqlCommand calistirstok = new SqlCommand(sorgustok, baglanti);
                int stok = Convert.ToInt16(calistirstok.ExecuteScalar());
                lblkullanici.Text = stok.ToString();

                string sorgutoplam = "SELECT satilan_miktar FROM dbo.kitap WHERE kitap_adi='"+ekle.Text+"'";
                SqlCommand calistirtoplam = new SqlCommand(sorgutoplam, baglanti);
                int toplam = Convert.ToInt16(calistirtoplam.ExecuteScalar());
                label5.Text = toplam.ToString();

                top += 26;
                ProgressBar prgresstok = new ProgressBar();
                
                prgresstok.Value = stok;
                prgresstok.Maximum = toplam;
                prgresstok.Left = left;
                prgresstok.Top=top;
                listkitap.Controls.Add(prgresstok);
                listkitap.Items.Add(ekle);
                
                //lst.Controls.Add(temp);
                
                    

            }
            baglanti.Close();
        }
        
        private void anasayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void yenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kayit kayit = new Kayit();
            kayit.Show();
            this.Hide();
        }

        private void Kullanici_Load(object sender, EventArgs e)
        {
            
        }

        private void btnsorgulatum_Click(object sender, EventArgs e)
        {
            verigoster();
        }

        public void btnsorgula_Click(object sender, EventArgs e)
        {
            verigoster();
            
            listkitap.Items.Clear();
            listkitap.Controls.Clear(); //tüm sorguları temizliyor her clikte kullan
           // lst.Controls.Remove(temp);
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();

            if (cmbkategori.SelectedIndex == 0)
                MessageBox.Show("Seçim Yapmadınız");

            if (cmbkategori.SelectedIndex==1)
            {
                SqlCommand komutbul = new SqlCommand();
                komutbul.Connection = baglanti;
                komutbul.CommandText = ("Select * from dbo.kitap WHERE kitap_tur='Kişisel Gelişim'");
                SqlDataReader okubul = komutbul.ExecuteReader();
                while (okubul.Read())
                {
                    ListViewItem eklebul = new ListViewItem();
                    eklebul.Text = okubul["kitap_adi"].ToString();
                    eklebul.SubItems.Add(okubul["kitap_yazari"].ToString());
                    eklebul.SubItems.Add(okubul["kitap_tur"].ToString());
                    eklebul.SubItems.Add(okubul["stok_miktari"].ToString());
                    eklebul.SubItems.Add(okubul["toplam_adet"].ToString());
                    eklebul.SubItems.Add(okubul["satilan_miktar"].ToString());
                    eklebul.SubItems.Add(okubul["begeni"].ToString());
                    listkitap.Items.Add(eklebul);
                }
            }
            if (cmbkategori.SelectedIndex == 2)
            {
                SqlCommand komutbul = new SqlCommand();
                komutbul.Connection = baglanti;
                komutbul.CommandText = ("Select * from dbo.kitap WHERE kitap_tur='Aksiyon'");
                SqlDataReader okubul = komutbul.ExecuteReader();
                while (okubul.Read())
                {
                    ListViewItem eklebul = new ListViewItem();
                    eklebul.Text = okubul["kitap_adi"].ToString();
                    eklebul.SubItems.Add(okubul["kitap_yazari"].ToString());
                    eklebul.SubItems.Add(okubul["kitap_tur"].ToString());
                    eklebul.SubItems.Add(okubul["stok_miktari"].ToString());
                    eklebul.SubItems.Add(okubul["toplam_adet"].ToString());
                    eklebul.SubItems.Add(okubul["satilan_miktar"].ToString());
                    eklebul.SubItems.Add(okubul["begeni"].ToString());
                    listkitap.Items.Add(eklebul);
                }
            }
            if (cmbkategori.SelectedIndex == 3)
            {
                SqlCommand komutbul = new SqlCommand();
                komutbul.Connection = baglanti;
                komutbul.CommandText = ("Select * from dbo.kitap WHERE kitap_tur='Macera'");
                SqlDataReader okubul = komutbul.ExecuteReader();
                while (okubul.Read())
                {
                    ListViewItem eklebul = new ListViewItem();
                    eklebul.Text = okubul["kitap_adi"].ToString();
                    eklebul.SubItems.Add(okubul["kitap_yazari"].ToString());
                    eklebul.SubItems.Add(okubul["kitap_tur"].ToString());
                    eklebul.SubItems.Add(okubul["stok_miktari"].ToString());
                    eklebul.SubItems.Add(okubul["toplam_adet"].ToString());
                    eklebul.SubItems.Add(okubul["satilan_miktar"].ToString());
                    eklebul.SubItems.Add(okubul["begeni"].ToString());
                    listkitap.Items.Add(eklebul);
                }
            }
            if (cmbkategori.SelectedIndex == 4)
            {
                SqlCommand komutbul = new SqlCommand();
                komutbul.Connection = baglanti;
                komutbul.CommandText = ("Select * from dbo.kitap WHERE kitap_tur='Psikoloji'");
                SqlDataReader okubul = komutbul.ExecuteReader();
                while (okubul.Read())
                {
                    ListViewItem eklebul = new ListViewItem();
                    eklebul.Text = okubul["kitap_adi"].ToString();
                    eklebul.SubItems.Add(okubul["kitap_yazari"].ToString());
                    eklebul.SubItems.Add(okubul["kitap_tur"].ToString());
                    eklebul.SubItems.Add(okubul["stok_miktari"].ToString());
                    eklebul.SubItems.Add(okubul["toplam_adet"].ToString());
                    eklebul.SubItems.Add(okubul["satilan_miktar"].ToString());
                    eklebul.SubItems.Add(okubul["begeni"].ToString());
                    listkitap.Items.Add(eklebul);
                }
            }
            if (cmbkategori.SelectedIndex == 5)
            {
                SqlCommand komutbul = new SqlCommand();
                komutbul.Connection = baglanti;
                komutbul.CommandText = ("Select * from dbo.kitap WHERE kitap_tur='Tarih'");
                SqlDataReader okubul = komutbul.ExecuteReader();
                while (okubul.Read())
                {
                    ListViewItem eklebul = new ListViewItem();
                    eklebul.Text = okubul["kitap_adi"].ToString();
                    eklebul.SubItems.Add(okubul["kitap_yazari"].ToString());
                    eklebul.SubItems.Add(okubul["kitap_tur"].ToString());
                    eklebul.SubItems.Add(okubul["stok_miktari"].ToString());
                    eklebul.SubItems.Add(okubul["toplam_adet"].ToString());
                    eklebul.SubItems.Add(okubul["satilan_miktar"].ToString());
                    eklebul.SubItems.Add(okubul["begeni"].ToString());
                    listkitap.Items.Add(eklebul);
                }
            }


            SqlCommand komutara = new SqlCommand();
            komutara.Connection = baglanti;
            komutara.CommandText = ("Select * from dbo.kitap WHERE kitap_adi='"+txtaranan.Text.ToString()+"'");
            SqlDataReader oku = komutara.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["kitap_adi"].ToString();
                ekle.SubItems.Add(oku["kitap_yazari"].ToString());
                ekle.SubItems.Add(oku["kitap_tur"].ToString());
                ekle.SubItems.Add(oku["stok_miktari"].ToString());
                ekle.SubItems.Add(oku["toplam_adet"].ToString());
                ekle.SubItems.Add(oku["satilan_miktar"].ToString());
                ekle.SubItems.Add(oku["begeni"].ToString());
                listkitap.Items.Add(ekle);
            }
            if (alfabetiksira.Checked == true)
            {
                listkitap.Items.Clear();
                listkitap.Items.Clear();
                label5.Text = "Radio seçildi";
                SqlCommand komutalfabetik = new SqlCommand();
                komutalfabetik.Connection = baglanti;
                komutalfabetik.CommandText = ("SELECT * from dbo.kitap ORDER BY kitap_adi");
                SqlDataReader okualfabetik = komutalfabetik.ExecuteReader();
                int left = 450;
                int top = 10;
                while (okualfabetik.Read())
                {
                    ListViewItem eklealfabetik = new ListViewItem();
                    eklealfabetik.Text = okualfabetik["kitap_adi"].ToString();
                    eklealfabetik.SubItems.Add(okualfabetik["kitap_yazari"].ToString());
                    eklealfabetik.SubItems.Add(okualfabetik["kitap_tur"].ToString());
                    eklealfabetik.SubItems.Add(okualfabetik["stok_miktari"].ToString());
                    eklealfabetik.SubItems.Add(okualfabetik["toplam_adet"].ToString());
                    eklealfabetik.SubItems.Add(okualfabetik["satilan_miktar"].ToString());
                    eklealfabetik.SubItems.Add(okualfabetik["begeni"].ToString());

                    string sorgustok = "SELECT stok_miktari FROM dbo.kitap WHERE kitap_adi='" + eklealfabetik.Text + "'";
                    SqlCommand calistirstok = new SqlCommand(sorgustok, baglanti);
                    int stok = Convert.ToInt16(calistirstok.ExecuteScalar());
                    lblkullanici.Text = stok.ToString();

                    string sorgutoplam = "SELECT satilan_miktar FROM dbo.kitap WHERE kitap_adi='" + eklealfabetik.Text + "'";
                    SqlCommand calistirtoplam = new SqlCommand(sorgutoplam, baglanti);
                    int toplam = Convert.ToInt16(calistirtoplam.ExecuteScalar());
                    label5.Text = toplam.ToString();

                    top += 26;
                    ProgressBar prgresstok = new ProgressBar();

                    prgresstok.Value = stok;
                    prgresstok.Maximum = toplam;
                    prgresstok.Left = left;
                    prgresstok.Top = top;
                    listkitap.Controls.Add(prgresstok);
                    listkitap.Items.Add(eklealfabetik);



                }
            }
            if (radiotop5.Checked == true)
            {
                listkitap.Controls.Clear();
                label5.Text = "Radio seçildi";
                SqlCommand komuttop5 = new SqlCommand();
                komuttop5.Connection = baglanti;
                komuttop5.CommandText = ("select top 5 * from dbo.kitap order by begeni desc");
                SqlDataReader okutop5 = komuttop5.ExecuteReader();
                int left = 450;
                int top = 10;
                while (okutop5.Read())
                {
                    ListViewItem ekletop5 = new ListViewItem();
                    ekletop5.Text = okutop5["kitap_adi"].ToString();
                    ekletop5.SubItems.Add(okutop5["kitap_yazari"].ToString());
                    ekletop5.SubItems.Add(okutop5["kitap_tur"].ToString());
                    ekletop5.SubItems.Add(okutop5["stok_miktari"].ToString());
                    ekletop5.SubItems.Add(okutop5["toplam_adet"].ToString());
                    ekletop5.SubItems.Add(okutop5["satilan_miktar"].ToString());
                    ekletop5.SubItems.Add(okutop5["begeni"].ToString());

                    string sorgustok = "SELECT stok_miktari FROM dbo.kitap WHERE kitap_adi='" + ekletop5.Text + "'";
                    SqlCommand calistirstok = new SqlCommand(sorgustok, baglanti);
                    int stok = Convert.ToInt16(calistirstok.ExecuteScalar());
                    lblkullanici.Text = stok.ToString();

                    string sorgutoplam = "SELECT satilan_miktar FROM dbo.kitap WHERE kitap_adi='" + ekletop5.Text + "'";
                    SqlCommand calistirtoplam = new SqlCommand(sorgutoplam, baglanti);
                    int toplam = Convert.ToInt16(calistirtoplam.ExecuteScalar());
                    label5.Text = toplam.ToString();

                    top += 26;
                    ProgressBar prgresstok = new ProgressBar();

                    prgresstok.Value = stok;
                    prgresstok.Maximum = toplam;
                    prgresstok.Left = left;
                    prgresstok.Top = top;
                    listkitap.Controls.Add(prgresstok);
                    
                    listkitap.Items.Add(ekletop5);
                }
            }
            if (radioencoksatan.Checked == true)
            {
                listkitap.Controls.Clear();
                label5.Text = "Radio seçildi";
                SqlCommand komutencoksatan = new SqlCommand();
                komutencoksatan.Connection = baglanti;
                komutencoksatan.CommandText = ("select top 5 * from dbo.kitap order by satilan_miktar desc");
                SqlDataReader okuencoksatan = komutencoksatan.ExecuteReader();
                int left = 450;
                int top = 10;
                while (okuencoksatan.Read())
                {
                    ListViewItem ekleencoksatan = new ListViewItem();
                    ekleencoksatan.Text = okuencoksatan["kitap_adi"].ToString();
                    ekleencoksatan.SubItems.Add(okuencoksatan["kitap_yazari"].ToString());
                    ekleencoksatan.SubItems.Add(okuencoksatan["kitap_tur"].ToString());
                    ekleencoksatan.SubItems.Add(okuencoksatan["stok_miktari"].ToString());
                    ekleencoksatan.SubItems.Add(okuencoksatan["toplam_adet"].ToString());
                    ekleencoksatan.SubItems.Add(okuencoksatan["satilan_miktar"].ToString());
                    ekleencoksatan.SubItems.Add(okuencoksatan["begeni"].ToString());

                    string sorgustok = "SELECT stok_miktari FROM dbo.kitap WHERE kitap_adi='" + ekleencoksatan.Text + "'";
                    SqlCommand calistirstok = new SqlCommand(sorgustok, baglanti);
                    int stok = Convert.ToInt16(calistirstok.ExecuteScalar());
                    lblkullanici.Text = stok.ToString();

                    string sorgutoplam = "SELECT satilan_miktar FROM dbo.kitap WHERE kitap_adi='" + ekleencoksatan.Text + "'";
                    SqlCommand calistirtoplam = new SqlCommand(sorgutoplam, baglanti);
                    int toplam = Convert.ToInt16(calistirtoplam.ExecuteScalar());
                    label5.Text = toplam.ToString();

                    top += 26;
                    ProgressBar prgresstok = new ProgressBar();

                    prgresstok.Value = stok;
                    prgresstok.Maximum = toplam;
                    prgresstok.Left = left;
                    prgresstok.Top = top;
                    listkitap.Controls.Add(prgresstok);
                    listkitap.Items.Add(ekleencoksatan);
                }
            }
            if (radiencokbegenilen.Checked == true)
            {
                listkitap.Controls.Clear();
                listkitap.Items.Clear();
                label5.Text = "Radio seçildi";
                SqlCommand komutencokbegeni = new SqlCommand();
                komutencokbegeni.Connection = baglanti;
                komutencokbegeni.CommandText = ("select top 1 * from dbo.kitap order by begeni desc");
                SqlDataReader okuencokbegeni = komutencokbegeni.ExecuteReader();
                int left = 450;
                int top = 10;
                while (okuencokbegeni.Read())
                {
                    ListViewItem ekleencokbegeni = new ListViewItem();
                    ekleencokbegeni.Text = okuencokbegeni["kitap_adi"].ToString();
                    ekleencokbegeni.SubItems.Add(okuencokbegeni["kitap_yazari"].ToString());
                    ekleencokbegeni.SubItems.Add(okuencokbegeni["kitap_tur"].ToString());
                    ekleencokbegeni.SubItems.Add(okuencokbegeni["stok_miktari"].ToString());
                    ekleencokbegeni.SubItems.Add(okuencokbegeni["toplam_adet"].ToString());
                    ekleencokbegeni.SubItems.Add(okuencokbegeni["satilan_miktar"].ToString());
                    ekleencokbegeni.SubItems.Add(okuencokbegeni["begeni"].ToString());

                    string sorgustok = "SELECT stok_miktari FROM dbo.kitap WHERE kitap_adi='" + ekleencokbegeni.Text + "'";
                    SqlCommand calistirstok = new SqlCommand(sorgustok, baglanti);
                    int stok = Convert.ToInt16(calistirstok.ExecuteScalar());
                    lblkullanici.Text = stok.ToString();

                    string sorgutoplam = "SELECT satilan_miktar FROM dbo.kitap WHERE kitap_adi='" + ekleencokbegeni.Text + "'";
                    SqlCommand calistirtoplam = new SqlCommand(sorgutoplam, baglanti);
                    int toplam = Convert.ToInt16(calistirtoplam.ExecuteScalar());
                    label5.Text = toplam.ToString();

                    top += 26;
                    ProgressBar prgresstok = new ProgressBar();

                    prgresstok.Value = stok;
                    prgresstok.Maximum = toplam;
                    prgresstok.Left = left;
                    prgresstok.Top = top;
                    listkitap.Controls.Add(prgresstok);
                    listkitap.Items.Add(ekleencokbegeni);
                }
            }


            baglanti.Close();
        }

        private void radiomaksimum_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
