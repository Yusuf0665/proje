using System.Text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.SqlClient;
using System.Security;
using System.Net.Mail;



namespace proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source = LAPTOP-I63QL2PI\\SQLEXPRESS; Initial Catalog =proje1; Integrated Security=True ");

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("L�tfen bo� alan b�rakmay�n!!!");
            }
            else
            {


                baglanti.Open();
                string user = textBox3.Text;
                string password = textBox4.Text;

                SqlCommand komut = new SqlCommand("select * from login where k_adi ='" + user + "' and sifre ='" + password + "' ", baglanti);
                SqlDataReader oku = komut.ExecuteReader();
                if (oku.Read())
                {
                    MessageBox.Show("Ho�geldiniz " + user + "...");
                }
                else
                {
                    MessageBox.Show("Hatal� kullan�c� ad� veya �ifre...");
                }


                baglanti.Close();
            } 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LinkSifremiUnuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            �ifremi_unuttum frm = new �ifremi_unuttum();
            frm.Show();
        }


        }
    }