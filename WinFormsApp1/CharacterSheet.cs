namespace WinFormsApp1
{
    public partial class CharacterSheet : Form
    {
        public CharacterSheet()
        {
            InitializeComponent();
            readCharacter();
        }

        public void readCharacter() // ������ ������ ��������� � �����
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {



        }

       
        private void lbl_ClassAndLevel_Click(object sender, EventArgs e)
        {

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

    }

}