namespace Forms_ATM_uygulaması
{
    public partial class Form1 : Form
    {
        string sifre = "1234";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == sifre)
            {
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            else
            {
                label3.Visible = true;
                textBox1.Clear();
            }
        }
    }
}