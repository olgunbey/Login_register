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

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand add = new SqlCommand("INSERT INTO newbilgi (pMail,pSifre,pAd) values (@pmail,@pSifre,@pAdi)", Class1.baglanti);
            Class1.baglantikontrol(Class1.baglanti);
            string hashpassword = Class2.ComputeSha256Hash(textBox3.Text); //SHA256 sifreleme mantıgını kullandık
            add.Parameters.AddWithValue("@pmail",textBox2.Text);
            add.Parameters.AddWithValue("@pAdi", textBox1.Text);
            add.Parameters.AddWithValue("@pSifre", hashpassword);
            add.ExecuteNonQuery();
            MessageBox.Show("KAYDINIZ OLUŞTURULDU...LUTFEN BEKLEYINIZ");
            Form2 frm = new Form2();
            frm.Show();

        }
    }
}
