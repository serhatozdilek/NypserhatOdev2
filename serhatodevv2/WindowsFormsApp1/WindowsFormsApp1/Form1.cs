﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            string kullaniciAdi, sifre;
            kullaniciAdi = textBox1.Text;
            sifre = textBox2.Text;

            if (kullaniciAdi == "serhatozdilek" && sifre == "serhat")
            {
                f2.Show();
                MessageBox.Show("Başarılı giriş yaptınız.");
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı. Tekrar deneyin.");
            }
        }
    }
}
