namespace ders1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.frmlabel.Text=textBox1.Text;
            frm.Show();

            
        }
    }
}
