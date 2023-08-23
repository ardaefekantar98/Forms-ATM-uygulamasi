﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_ATM_uygulaması
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(textBox1.Text) <= 1000 && Convert.ToInt32(textBox1.Text) <= Form2.para)
                {
                    Form2.bakiye += Convert.ToInt32(textBox1.Text);
                    Form2.para -= Convert.ToInt32(textBox1.Text);
                    MessageBox.Show("İşlem başarılı! Hesabınıza " + textBox1.Text + " TL eklendi.");
                    textBox1.Clear();
                }
                else if (Convert.ToInt32(textBox1.Text) > Form2.para)
                {
                    MessageBox.Show("Yeterli paranız yok!");
                    textBox1.Clear();
                }
                else
                {
                    MessageBox.Show("İşlem başarısız! Lütfen geçerli bir tutar girin...");
                    textBox1.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata meydana geldi, lütfen tekrar deneyin...");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
