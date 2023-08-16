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

        public void createCharacter() // Створення файлу персонажа
            {
                try
                {
                    string path = "data.txt";
                    string data = @"start";

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
            Form1 characterSheet = new Form1();
            characterSheet.Show();
            this.Hide();
        }
        

    }
}
