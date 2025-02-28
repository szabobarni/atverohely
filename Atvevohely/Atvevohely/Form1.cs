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

namespace Atvevohely
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void clearButtons()
        {
            termelok.Dispose();
            atvetel.Dispose();
            gyumolcsok.Dispose();
        }

        private void termelok_Click(object sender, EventArgs e)
        {
            clearButtons();

        }

        private void gyumolcsok_Click(object sender, EventArgs e)
        {
            clearButtons();
            Label text = new Label();
            text.Text = "Gyümölcsök";
            text.Location = new Point(20,20);
            text.BackColor = Color.White;
            text.Size = new Size(400,100);
            text.Font = new Font("Arial",40,FontStyle.Bold);
            this.Controls.Add(text);

            ListBox listBox = new ListBox();
            listBox.Location = new Point(520,123);
            listBox.Size = new Size(200,200);
            this.Controls.Add(listBox);

            TextBox textBox = new TextBox();
            textBox.Location = new Point(520,60);
            textBox.AutoSize = false;
            textBox.Size = new Size(100, 28);
            this.Controls.Add(textBox);

            Button hozzaad = new Button();
            hozzaad.Location = new Point(630,59);
            hozzaad.Size = new Size(90,30);
            hozzaad.Text = "Hozzáadás";
            hozzaad.Click += hozzaad_Click;
            this.Controls.Add(hozzaad);

            string filepath = "fruits.txt";
            //string fruit = textBox.Text;
            hozzaad.Tag = new { Text = textBox.Text, FilePath = filepath };
            List<string> lines = new List<string>();

           
            using (StreamReader reader = new StreamReader(filepath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    lines.Add(line); 
                }
            }

            
            foreach (var line in lines)
            {
                listBox.Items.Add(line);
            }

        }

        private void hozzaad_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            var buttonInfo = button.Tag as dynamic;

            // Extract file path and text from button.Tag
            string filepath = buttonInfo.FilePath;
            string text = buttonInfo.Text;

            try
            {
                // Check if the file exists, if not, create it
                if (!File.Exists(filepath))
                {
                    // Create a new file and close it immediately
                    File.Create(filepath).Close();
                }

                // Append the text to the file
                using (StreamWriter sw = new StreamWriter(filepath, true)) // 'true' for appending
                {
                    sw.WriteLine(text);
                }

                MessageBox.Show("Text added successfully. "+text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void atvetel_Click(object sender, EventArgs e)
        {
            clearButtons();
        }
    }
}
