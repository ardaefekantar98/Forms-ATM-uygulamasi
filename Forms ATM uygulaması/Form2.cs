using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public static int bakiye = 2000;
        public static int para = 1500;
        private void Form2_Load(object sender, EventArgs e)
        {
            label2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = bakiye.ToString();
            label2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
            this.Hide();
        }
    }
}
