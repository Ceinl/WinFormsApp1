namespace WinFormsApp1
{
    public partial class CharacterSheet : Form
    {
        public CharacterSheet()
        {
            InitializeComponent();

        }

        //
        // TODO:  можливість змінювати певні лейбли під час використання

        // -- TODO:  збереження всіх лейблів при закритті програми АБО кнопку для збереження лейблів на сторінку персонажа

        // TODO:  Пододавати всі лейбли на екран персонажа
        // TODO:  Пододавати всі лейбли на екран створення
        // TODO:  Повикликати методи для зчити і запису для кожного лейбла

        // TODO:  Задизайнити вікна

        public void readCharacter(Label lbl) // Зчитка данних персонажа з файлу
        {
            string[] strings = File.ReadAllLines(MainScreen.path);

            foreach (string line in strings)
            {
                string[] parts = line.Split(' ');

                if (parts.Length > 0 && lbl.Name == parts[0])
                {
                    lbl.Text = line.Substring(parts[0].Length).Trim();
                    break;
                }

            }

        }

        void SaveCharData(Label inputData) // Функція для збереження данних після зміни
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(MainScreen.path, true))
                {
                    writer.WriteLine($"\n{inputData.Name} {inputData.Text}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
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

        private void CharacterSheet_Load(object sender, EventArgs e)
        {
            readCharacter(CharacterName);
        }

        private void CharacterSheet_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                MessageBox.Show("1");
                SaveCharData(CharacterName);
            }
        }



       

        private void lpl_playerInspiration_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }
    }

}