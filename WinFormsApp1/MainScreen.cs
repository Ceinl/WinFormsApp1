using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace WinFormsApp1
{
   


    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();


            
        }

        public static string path = @"data.txt";

        public void createCharacter() // Створення файлу персонажа
            {
                try
                {
                    string data = @"--CharacterSheetData--";

                    File.WriteAllText(path, data);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        

        private void MainScreen_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            createCharacter();
            CreateCharacterForm characterSheet = new CreateCharacterForm();
            characterSheet.Show();
            this.Hide();  
        }


        private void button2_Click(object sender, EventArgs e)
        {
            CharacterSheet characterSheet = new CharacterSheet();
            characterSheet.Show();
            this.Hide();
        }
        

    }
}
