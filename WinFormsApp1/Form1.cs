namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int a;

        private void button1_Click(object sender, EventArgs e)
        {
            if(a == 299)
            {
                a = 301;
            }
            a++;
            label1.Text = a.ToString();
            
        }
    }
}