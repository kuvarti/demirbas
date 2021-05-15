using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Staj_projesi
{
    public partial class departman : Form
    {
        public departman()
        {
            InitializeComponent();
        }
        ana_sayfa ana = new ana_sayfa();
        private void button3_Click(object sender, EventArgs e)
        {
            ana.goruntu_yenile(dataGridView1, "Select *From Departman", "Departman", "kisi");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ana.sql_islemi("kisi", "", "insert into Departman VALUES('" + textBox1.Text + "')");
            ana.goruntu_yenile(dataGridView1, "Select *From Departman", "Departman", "kisi");
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ana.sql_islemi("kisi", "", "Delete from Departman where d_adı='"+textBox2.Text+"'");
            ana.goruntu_yenile(dataGridView1, "Select *From Departman", "Departman", "kisi");
            textBox2.Text = "";
        }

        private void departman_Load(object sender, EventArgs e)
        {

        }
    }
}
