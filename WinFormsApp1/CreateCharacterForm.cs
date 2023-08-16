using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{



    public partial class CreateCharacterForm : Form
    {


        void SendCharData(TextBox inputData) // Функція для запису данних в файл
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(MainScreen.path, true))
                {
                    writer.WriteLine($"\n  {inputData.Name} {inputData.Text}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }




        public CreateCharacterForm()
        {
            InitializeComponent();
        }


        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void SubmitDataButton_Click(object sender, EventArgs e)
        {
            SendCharData(textBox1);
            Environment.Exit(0);
        }
    }
}


// foo(lbl)
// {
//  line[n] = lbl.text
// }
//
