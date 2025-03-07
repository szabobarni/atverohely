using Atvevohely.Properties;
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
            this.Controls.Clear();
        }
        private void start()
        {
            clearButtons();

            Button termelok = new Button();
            termelok.Location = new System.Drawing.Point(451, 36);
            termelok.Text = "Termelők";
            termelok.Size = new System.Drawing.Size(223, 64);
            termelok.TabIndex = 0;
            termelok.UseVisualStyleBackColor = true;
            termelok.Click += termelok_Click;
            this.Controls.Add(termelok);

            Button gyumolcsok = new Button();
            gyumolcsok.Location = new System.Drawing.Point(451, 172);
            gyumolcsok.Name = "gyumolcsok";
            gyumolcsok.Size = new System.Drawing.Size(223, 64);
            gyumolcsok.TabIndex = 1;
            gyumolcsok.Text = "Gyümölcsök";
            gyumolcsok.UseVisualStyleBackColor = true;
            gyumolcsok.Click += gyumolcsok_Click;
            this.Controls.Add(gyumolcsok);

            Button atvetel = new Button();
            atvetel.Location = new System.Drawing.Point(451, 326);
            atvetel.Name = "atvetel";
            atvetel.Size = new System.Drawing.Size(223, 64);
            atvetel.TabIndex = 2;
            atvetel.Text = "Átvétel";
            atvetel.UseVisualStyleBackColor = true;
            atvetel.Click += atvetel_Click;
            this.Controls.Add(atvetel);
        }
        private void termelok_Click(object sender, EventArgs e)
        {
            clearButtons();
            Label text = new Label();
            text.Text = "Termelők";
            text.Location = new Point(20, 20);
            text.BackColor = Color.White;
            text.Size = new Size(400, 100);
            text.Font = new Font("Arial", 40, FontStyle.Bold);
            this.Controls.Add(text);

            ListBox listBox = new ListBox();
            listBox.Location = new Point(520, 123);
            listBox.Size = new Size(200, 200);
            this.Controls.Add(listBox);

            TextBox textBox = new TextBox();
            textBox.Location = new Point(520, 60);
            textBox.AutoSize = false;
            textBox.Size = new Size(100, 28);
            this.Controls.Add(textBox);

            Button hozzaad = new Button();
            hozzaad.Location = new Point(630, 59);
            hozzaad.Size = new Size(90, 30);
            hozzaad.Text = "Hozzáadás";
            hozzaad.Click += hozzaad_Click;
            this.Controls.Add(hozzaad);

            Button vissza = new Button();
            vissza.Text = "Vissza";
            vissza.Location = new Point(630, 330);
            vissza.Size = new Size(90, 30);
            vissza.Click += visszaButton_Click;
            this.Controls.Add(vissza);

            string filepath = "termelok.txt";
            hozzaad.Tag = new { TextBox = textBox, FilePath = filepath };
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

            Button vissza = new Button();
            vissza.Text = "Vissza";
            vissza.Location = new Point(630, 330);
            vissza.Size = new Size(90, 30);
            vissza.Click += visszaButton_Click;
            this.Controls.Add(vissza);

            string filepath = "fruits.txt";
            hozzaad.Tag = new { TextBox = textBox, FilePath = filepath };
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
        private void atvetel_Click(object sender, EventArgs e)
        {
            clearButtons();
            Label text = new Label();
            text.Text = "Átvétel";
            text.Location = new Point(20, 20);
            text.BackColor = Color.White;
            text.Size = new Size(400, 100);
            text.Font = new Font("Arial", 40, FontStyle.Bold);
            this.Controls.Add(text);

            ListBox listBox = new ListBox();
            listBox.Location = new Point(520, 123);
            listBox.Size = new Size(200, 200);
            this.Controls.Add(listBox);

            TextBox textBox = new TextBox();
            textBox.Location = new Point(520, 60);
            textBox.AutoSize = false;
            textBox.Size = new Size(100, 28);
            this.Controls.Add(textBox);

            Button hozzaad = new Button();
            hozzaad.Location = new Point(630, 59);
            hozzaad.Size = new Size(90, 30);
            hozzaad.Text = "Hozzáadás";
            hozzaad.Click += hozzaad_Click;
            this.Controls.Add(hozzaad);

            Button vissza = new Button();
            vissza.Text = "Vissza";
            vissza.Location = new Point(630, 330);
            vissza.Size = new Size(90, 30);
            vissza.Click += visszaButton_Click;
            this.Controls.Add(vissza);

            string filepath = "atvetelek.txt";
            hozzaad.Tag = new { TextBox = textBox, FilePath = filepath };
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

            string filepath = buttonInfo.FilePath;
            string text = buttonInfo.TextBox.Text;

            try
            {
                if (!File.Exists(filepath))
                {
                    File.Create(filepath).Close();
                }

                using (StreamWriter sw = new StreamWriter(filepath, true)) 
                {
                    sw.WriteLine(text);
                }
                ListBox listBox = this.Controls.OfType<ListBox>().FirstOrDefault();
                if (listBox != null)
                {              
                    listBox.Items.Clear();

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
                MessageBox.Show("Sikeresen hozzáadva. ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void visszaButton_Click(object sender, EventArgs e)
        {
            start(); 
        }
    }
}
