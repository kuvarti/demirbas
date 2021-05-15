using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Staj_projesi
{
    public partial class ana_sayfa : Form
    {
        public ana_sayfa()
        {
            InitializeComponent();
        }

        private void b_urunler_Click(object sender, EventArgs e)
        {
            urunler nsn = new urunler();
            nsn.ShowDialog();
        }

        private void b_kisiler_Click(object sender, EventArgs e)
        {
            personel nsn = new personel();
            nsn.ShowDialog();
        }

        private void b_form_Click(object sender, EventArgs e)
        {
            sorgular nsn = new sorgular();
            nsn.ShowDialog();
        }
        public OleDbCommand kmt = new OleDbCommand();
        public OleDbDataAdapter adptr = new OleDbDataAdapter();
        public OleDbConnection urun_baglanti = new OleDbConnection("Provider=Microsoft.JET.Oledb.4.0; Data Source=urunler.mdb");
        public OleDbConnection kisi_baglanti = new OleDbConnection("Provider=Microsoft.JET.Oledb.4.0; Data Source=Kişiler.mdb");
        public DataSet data = new DataSet();
        public OleDbDataReader oku;
        public void sql_islemi(string h_con, string tbl_isim, string sql)
        {
            if (h_con=="urun")
            {
                urun_baglanti.Open();
                kmt = new OleDbCommand(sql, urun_baglanti);
                kmt.ExecuteNonQuery();
                urun_baglanti.Close();
            }
            if (h_con=="kisi")
            {
                kisi_baglanti.Open();
                kmt = new OleDbCommand(sql, kisi_baglanti);
                kmt.ExecuteNonQuery();
                kisi_baglanti.Close();
            }
            
        }
        public void goruntu_yenile(DataGridView tablo,string sql,string tabloo,string h_con)
        {
            data.Tables.Clear();
            tablo.Refresh();

            if (h_con=="urun")
            {
                urun_baglanti.Open();
                adptr = new OleDbDataAdapter(sql, urun_baglanti);
                adptr.Fill(data, tabloo);
                tablo.DataSource = data.Tables[tabloo];
                adptr.Dispose();
                urun_baglanti.Close();
            }
            if (h_con == "kisi")
            {
                kisi_baglanti.Open();
                adptr = new OleDbDataAdapter(sql, kisi_baglanti);
                adptr.Fill(data, tabloo);
                tablo.DataSource = data.Tables[tabloo];
                adptr.Dispose();
                kisi_baglanti.Close();
            }
            
        }

        private void ana_sayfa_Load(object sender, EventArgs e)
        {

        }
    }
}
