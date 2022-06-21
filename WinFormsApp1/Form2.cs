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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand kontrol = new SqlCommand("select * from newbilgi where pMail=@pMail and pSifre=@pSif ",Class1.baglanti);
            string newpass = Class2.ComputeSha256Hash(textBox3.Text);
            kontrol.Parameters.AddWithValue("@pMail", textBox1.Text);
            kontrol.Parameters.AddWithValue("@pSif",newpass);

            Class1.baglantikontrol(Class1.baglanti);
            SqlDataReader dr = kontrol.ExecuteReader();
            if(dr.Read())
            {
                MessageBox.Show("Doğru giris");
                textBox1.Clear();
                textBox3.Clear();

            }
            else
            {
                MessageBox.Show("Adınız veya şifre hatalı");
            }
            Class1.baglanti.Close();
        }
    }
}
