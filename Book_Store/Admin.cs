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
    

    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-3SE8LH5;Initial Catalog=bookstore;Integrated Security=True;MultipleActiveResultSets=True");
        public void verilerigoster()
        {
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            if (baglanti.State != ConnectionState.Closed)
            {
                string kayitgoster = "SELECT * from dbo.kitap";
                SqlCommand komut = new SqlCommand(kayitgoster, baglanti);
                SqlDataAdapter dA = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                dA.Fill(dt);
                datalist.DataSource = dt;
            }
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            baglanti.Close();
           
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand komutekle = new SqlCommand();
                komutekle.Connection = baglanti;
                komutekle.CommandText = ("INSERT INTO dbo.kitap (kitap_adi,kitap_yazari,kitap_tur,stok_miktari,toplam_adet,satilan_miktar,begeni) VALUES ('" + txtkitapadi.Text + "','" + txtkitapyazari.Text + "','" + cmbxtur.Text.ToString() + "','" + txtstok.Text.ToString() + "','"+txttoplam.Text.ToString()+"','"+txtsatilan.Text.ToString()+"','"+txtbegen.Text+"')");
                komutekle.ExecuteNonQuery();
                komutekle.Dispose();
                verilerigoster(); 
            }
            txtkitapadi.Clear();
            txtkitapyazari.Clear();
            txtstok.Clear();
            txtsatilan.Clear();
            txttoplam.Clear();
            cmbxtur.SelectedIndex = 0;
            baglanti.Close();
        }

        private void btngoruntule_Click(object sender, EventArgs e)
        {
            verilerigoster();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            /*
             bu buton değiştirildi
             if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            for (int i = 0; i < datalist.SelectedRows.Count; i++)
            {
               // SqlCommand komutsil = new SqlCommand();
              //  komutsil.Connection = baglanti;
               // komutsil.CommandText = ("DELETE FROM dbo.kitap WHERE  kitap_adi='" + datalist.SelectedRows[i].Cells["id"].ToString() + "'") ;
              //  komutsil.ExecuteNonQuery();
                baglanti.Close();
                
            }

            verilerigoster();
            */
        }
        
        private void btnguncelle_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();

            SqlCommand komutgnclle = new SqlCommand();
            komutgnclle.Connection = baglanti;
            komutgnclle.CommandText = ("UPDATE dbo.kitap SET kitap_adi='"+txtkitapadi.Text+ "',kitap_yazari='"+txtkitapyazari.Text+ ",kitap_tur='"+cmbxtur.Text+ ",stok_miktari='"+txtstok.Text+ "',toplam_adet='"+txttoplam.Text+ "',satilan_miktar='"+txtsatilan.Text+"' WHERE kitap_adi='"+txtkitapadi.Text+"'");
            komutgnclle.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster();
        }

        private void btngoruntule_Click_1(object sender, EventArgs e)
        {
            verilerigoster();
        }

        private void btnsil_Click_1(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();

            for (int i = 0; i < datalist.SelectedRows.Count; i++)
            {
                SqlCommand komutsil = new SqlCommand();
                komutsil.Connection = baglanti;
                komutsil.CommandText = ("DELETE FROM dbo.kitap WHERE id='" + datalist.SelectedRows[i].Cells[0].Value.ToString() + "'");
                
                komutsil.ExecuteNonQuery();
            }
           
            baglanti.Close();
            verilerigoster();
            // komutsil.CommandText = ("DELETE FROM dbo.kitap WHERE id='" + datalist.CurrentRow.Cells["id"].Value.ToString() + "'");
        }

        private void btnguncelle_Click_1(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();

            SqlCommand komutgnclle = new SqlCommand();
            komutgnclle.Connection = baglanti;
            komutgnclle.CommandText = ("UPDATE dbo.kitap SET kitap_adi='"+txtkitapadi.Text+"',kitap_yazari='"+txtkitapyazari.Text+ "',kitap_tur='"+cmbxtur.Text.ToString()+ "',stok_miktari='"+txtstok.Text+"',toplam_adet='"+txtstok.Text+ "',satilan_miktar='"+txtsatilan.Text+"' WHERE id='"+ datalist.CurrentRow.Cells["id"].Value.ToString()+"'");
            komutgnclle.ExecuteNonQuery();
            
            verilerigoster();



            string kayitgoster = "SELECT * from dbo.kitap";
            SqlCommand komut = new SqlCommand(kayitgoster, baglanti);
            SqlDataAdapter dA = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            dA.Fill(dt);
            datalist.DataSource = dt;
            baglanti.Close();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void anasayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void btnkayittemizle_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();

            SqlCommand komuttemizle = new SqlCommand();
            komuttemizle.Connection = baglanti;
            komuttemizle.CommandText = ("DELETE FROM dbo.kitap");
            komuttemizle.ExecuteNonQuery();
            verilerigoster();

        }

        private void listkitap_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void datalist_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtkitapadi.Text = datalist.CurrentRow.Cells["kitap_adi"].Value.ToString();
            txtkitapyazari.Text = datalist.CurrentRow.Cells["kitap_yazari"].Value.ToString();
            cmbxtur.Text = datalist.CurrentRow.Cells["kitap_tur"].Value.ToString();
            txtstok.Text = datalist.CurrentRow.Cells["stok_miktari"].Value.ToString();
            txttur.Text = datalist.CurrentRow.Cells["kitap_tur"].Value.ToString();
            txtsatilan.Text = datalist.CurrentRow.Cells["satilan_miktar"].Value.ToString();
            txttoplam.Text = datalist.CurrentRow.Cells["toplam_adet"].Value.ToString();
            txtbegen.Text = datalist.CurrentRow.Cells["begeni"].Value.ToString();
            

        }

        private void datalist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // txtoperasyon.Text = datalist.CurrentRow.Cells["id"].Value.ToString();
           
        }
    }
   
}
