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
        public string result;

        class Adatok
        {
            public string nev, lakcim, id, gyumolcs;
            public int telefonszam, adoazonosito,mennyiseg;
            public DateTime ido;
        }

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

            Button hozzaad = new Button();
            hozzaad.Location = new Point(520, 330);
            hozzaad.Size = new Size(90, 30);
            hozzaad.Text = "Hozzáadás";
            hozzaad.Click += new_termelo;
            this.Controls.Add(hozzaad);

            Button vissza = new Button();
            vissza.Text = "Vissza";
            vissza.Location = new Point(630, 330);
            vissza.Size = new Size(90, 30);
            vissza.Click += visszaButton_Click;
            this.Controls.Add(vissza);    

            

            List<string> lines = new List<string>();

            using (StreamReader reader = new StreamReader("termelok.txt"))
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

			//lista
            ListBox listBox = new ListBox();
            listBox.Location = new Point(580, 123);
            listBox.Size = new Size(200, 200);
            this.Controls.Add(listBox);

			//NUMERIC UP DOWN szam
            NumericUpDown darab = new NumericUpDown();
			//darab.Value = 0;
            darab.Location = new Point(390, 190);
            darab.AutoSize = false;
            darab.Size = new Size(100, 28);
			darab.Minimum = 0;
			darab.Maximum = 99999999999;
            this.Controls.Add(darab);

			DateTimePicker dtp = new DateTimePicker();
			dtp.Format = DateTimePickerFormat.Short;
			dtp.Width = 100;
			dtp.Location = new Point(390,220);
			this.Controls.Add(dtp);

			//label db
			Label db = new Label();
			db.Text = "Kg";
			db.Location = new Point(490, 192);
			db.BackColor = Color.White;
			db.Size = new Size(430, 100);
			db.Font = new Font("Arial", 10, FontStyle.Bold);
			this.Controls.Add(db);

			//hozzaad
			Button hozzaad = new Button();
            hozzaad.Location = new Point(580, 330);
            hozzaad.Size = new Size(90, 30);
            hozzaad.Text = "Hozzáadás";
            hozzaad.Click += atvetelHozzaad;
            this.Controls.Add(hozzaad);

			//vissza
            Button vissza = new Button();
            vissza.Text = "Vissza";
            vissza.Location = new Point(690, 330);
            vissza.Size = new Size(90, 30);
            vissza.Click += visszaButton_Click;
            this.Controls.Add(vissza);

            //statisztika
            Button stat = new Button();
            stat.Text = "Statisztika";
            stat.Location = new Point(580, 370);
            stat.Size = new Size(200, 30);
            stat.Click += statButton_click;
            this.Controls.Add(stat);

            List<string> lines = new List<string>();

			using (StreamReader reader = new StreamReader("atvetelek.txt"))
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


            //GYÜMÖLCSÖK
            ComboBox gyumolcsLenyilo = new ComboBox();
            gyumolcsLenyilo.Text = "Gyümölcsök";
            gyumolcsLenyilo.Location = new Point(390, 160);
            this.Controls.Add(gyumolcsLenyilo);

            string fruits = "fruits.txt";
            List<string> gyumolcs_adatok = new List<string>();


            using (StreamReader reader = new StreamReader(fruits))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    gyumolcs_adatok.Add(line);
                }
            }


            foreach (var line in gyumolcs_adatok)
            {
                gyumolcsLenyilo.Items.Add(line);
            }

            //TERMELŐK
            ComboBox termelokLenyilo = new ComboBox();
            termelokLenyilo.Text = "Termelők";
            termelokLenyilo.Location = new Point(390, 130);
            this.Controls.Add(termelokLenyilo);

            string termelok = "termelok.txt";
            List<Adatok> termelok_adatok = new List<Adatok>();


            using (StreamReader reader = new StreamReader(termelok))
            {
                
                while (!reader.EndOfStream)
                {
                    string sor = reader.ReadLine();
                    string[] sorok = sor.Split(';');
                    Adatok sv = new Adatok();
                    sv.nev = sorok[0];
                    sv.lakcim = sorok[1];
                    sv.telefonszam = int.Parse(sorok[2]);
                    sv.adoazonosito = int.Parse(sorok[3]);
                    sv.id = sorok[4];
                    termelok_adatok.Add(sv);
                }
            }



			for (int i = 0; i < termelok_adatok.Count; i++)
			{
				termelokLenyilo.Items.Add(termelok_adatok[i].nev);
			}

			hozzaad.Tag = new { Name = termelokLenyilo, Gyumolcs = gyumolcsLenyilo, Darab = darab , Ido = dtp};
		}
        
        private void visszaButton_Click(object sender, EventArgs e)
        {
            start(); 
        }
        private void new_termelo(object sender, EventArgs e)
        {
            clearButtons();

            Label text = new Label();
            text.Text = "Új termelő";
            text.Location = new Point(20, 20);
            text.BackColor = Color.White;
            text.Size = new Size(400, 100);
            text.Font = new Font("Arial", 40, FontStyle.Bold);
            this.Controls.Add(text);

            Label name = new Label();
            name.Text = "Teljes név: ";
            name.Location = new Point(350, 120);
            name.BackColor = Color.White;
            name.Size = new Size(75, 15);
            name.Font = new Font("Arial", 10);
            this.Controls.Add(name);

            TextBox name_text = new TextBox();
            name_text.Location = new Point(465, 120);
            name_text.AutoSize = false;
            name_text.Size = new Size(100, 15);
            this.Controls.Add(name_text);

            Label lakcim = new Label();
            lakcim.Text = "Lakcím: ";
            lakcim.Location = new Point(350, 140);
            lakcim.BackColor = Color.White;
            lakcim.Size = new Size(75, 15);
            lakcim.Font = new Font("Arial", 10);
            this.Controls.Add(lakcim);

            TextBox lakcim_text = new TextBox();
            lakcim_text.Location = new Point(465, 140);
            lakcim_text.AutoSize = false;
            lakcim_text.Size = new Size(100, 15);
            this.Controls.Add(lakcim_text);

            Label telefonszam = new Label();
            telefonszam.Text = "Telefonszám:";
            telefonszam.Location = new Point(350, 160);
            telefonszam.BackColor = Color.White;
            telefonszam.Size = new Size(90, 15);
            telefonszam.Font = new Font("Arial", 10);
            this.Controls.Add(telefonszam);

            TextBox telefonszam_text = new TextBox();
            telefonszam_text.Location = new Point(465, 160);
            telefonszam_text.AutoSize = false;
            telefonszam_text.Size = new Size(100, 15);
            this.Controls.Add(telefonszam_text);

            Label adoazonosito = new Label();
            adoazonosito.Text = "Adóazonosító: ";
            adoazonosito.Location = new Point(350, 180);
            adoazonosito.BackColor = Color.White;
            adoazonosito.Size = new Size(98, 15);
            adoazonosito.Font = new Font("Arial", 10);
            this.Controls.Add(adoazonosito);

            TextBox adoazonosito_text = new TextBox();
            adoazonosito_text.Location = new Point(465, 180);
            adoazonosito_text.AutoSize = false;
            adoazonosito_text.Size = new Size(100, 15);
            this.Controls.Add(adoazonosito_text);

            Button save = new Button();
            save.Text = "Mentés";
            save.Location = new Point(350, 200);
            save.Size = new Size(80, 25);
            save.AutoSize = false;
            save.Click += termeloHozzaad;
            save.Click += termelok_Click;
            this.Controls.Add(save);

            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

            Random random = new Random();

            for (int i = 0; i < 5; i++)
            {
                result += (chars[random.Next(chars.Length)]).ToString();
            }

            save.Tag = new { Name = name_text, Lakcim = lakcim_text, Telefonszam = telefonszam_text, Adoazonosito = adoazonosito_text, Result = result};
            result = "";
        }

        #region Hozzáadás
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
        private void termeloHozzaad(object sender, EventArgs e) 
        {
            Button button = sender as Button;
            var buttonInfo = button.Tag as dynamic;

            string filepath = "termelok.txt";
            string name = buttonInfo.Name.Text;
            string lakcim = buttonInfo.Lakcim.Text;
            string telefonszam = buttonInfo.Telefonszam.Text;
            string adoazonosito = buttonInfo.Adoazonosito.Text;
            string result = buttonInfo.Result;

            try
            {
                if (!File.Exists(filepath))
                {
                    File.Create(filepath).Close();
                }

                using (StreamWriter sw = new StreamWriter(filepath, true))
                {
                    sw.WriteLine($"{name};{lakcim};{telefonszam};{adoazonosito};{result}");
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
        private void atvetelHozzaad(object sender, EventArgs e)
		{
			string filepath = "atvetelek.txt";
			Button button = sender as Button;
			var buttonInfo = button.Tag as dynamic;


			string name = buttonInfo.Name.SelectedItem;
			string gyumolcs = buttonInfo.Gyumolcs.SelectedItem;
			int db = (int)buttonInfo.Darab.Value;
			string ido = buttonInfo.Ido.Value.ToString("dd/MM/yyyy");


			try
			{
				if (!File.Exists(filepath))
				{
					File.Create(filepath).Close();
				}

				using (StreamWriter sw = new StreamWriter(filepath, true))
				{
					sw.WriteLine($"{name};{gyumolcs};{db};{ido}");
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
        #endregion

        #region Statisztika
        private DateTimePicker nap;
        private Dictionary<string, Label> fruitLabels = new Dictionary<string, Label>();
        private void statButton_click(object sender, EventArgs e)  
        {
            clearButtons();

            Button napi_bontas = new Button();
            napi_bontas.Location = new Point(480, 100);
            napi_bontas.Size = new Size(90, 30);
            napi_bontas.Text = "Napi Bontás";
            napi_bontas.Click += napi_bontas_Click;
            this.Controls.Add(napi_bontas);

            Button adott_idoszak_fajta = new Button();
            adott_idoszak_fajta.Location = new Point(480, 140);
            adott_idoszak_fajta.Size = new Size(90, 30);
            adott_idoszak_fajta.Text = "AI - Termelő";
            adott_idoszak_fajta.Click += napi_bontas_Click;
            this.Controls.Add(adott_idoszak_fajta);

            Button adott_idoszak_termelo = new Button();
            adott_idoszak_termelo.Location = new Point(480, 180);
            adott_idoszak_termelo.Size = new Size(90, 30);
            adott_idoszak_termelo.Text = "AI - Fajta";
            adott_idoszak_termelo.Click += napi_bontas_Click;
            this.Controls.Add(adott_idoszak_termelo);

            Button termelo_stat = new Button();
            termelo_stat.Location = new Point(480, 220);
            termelo_stat.Size = new Size(90, 80);
            termelo_stat.Text = "Termelő Tracker";
            termelo_stat.Click += napi_bontas_Click;
            this.Controls.Add(termelo_stat);


            //lista
            ListBox lista = new ListBox();
            lista.Location = new Point(580, 100);
            lista.Size = new Size(200, 300);
            this.Controls.Add(lista);
        }

        #region Napi Bontás
        private void napi_bontas_Click(object sender, EventArgs e)
        {
            clearButtons();

            Label text = new Label();
            text.Text = "Napi bontás";
            text.Location = new Point(20, 20);
            text.BackColor = Color.White;
            text.Size = new Size(400, 100);
            text.Font = new Font("Arial", 40, FontStyle.Bold);
            this.Controls.Add(text);


            nap = new DateTimePicker();
            nap.Format = DateTimePickerFormat.Short;
            nap.Width = 100;
            nap.Location = new Point(560, 55);
            nap.ValueChanged += napvaltozas;
            this.Controls.Add(nap);

            Button vissza = new Button();
            vissza.Text = "Vissza";
            vissza.Location = new Point(690, 330);
            vissza.Size = new Size(90, 30);
            vissza.Click += statButton_click;
            this.Controls.Add(vissza);

            napiFrissit();
        }
        private void napvaltozas(object sender, EventArgs e)
        {
            napiFrissit();
        }
        private void napiFrissit()
        {
            string atvetel = "atvetelek.txt";
            List<Adatok> atvetel_adatok = new List<Adatok>();

            using (StreamReader reader = new StreamReader(atvetel))
            {
                string sor;
                while ((sor = reader.ReadLine()) != null)
                {
                    string[] sorok = sor.Split(';');
                    Adatok sv = new Adatok();
                    sv.nev = sorok[0];
                    sv.gyumolcs = sorok[1];
                    sv.mennyiseg = int.Parse(sorok[2]);
                    sv.ido = DateTime.Parse(sorok[3]);
                    atvetel_adatok.Add(sv);
                }
            }

            var fruitTotals = atvetel_adatok
                .Where(a => a.ido.Date == nap.Value.Date)
                .GroupBy(a => a.gyumolcs)
                .ToDictionary(g => g.Key, g => g.Sum(a => a.mennyiseg));

            int startY = 130;

            foreach (var label in fruitLabels.Values)
            {
                this.Controls.Remove(label);
            }
            fruitLabels.Clear();

            Label text = new Label();
            text.Text = "Gyümölcsök";
            text.Location = new Point(520, 85);
            text.BackColor = Color.White;
            text.Size = new Size(400, 30);
            text.Font = new Font("Arial", 20, FontStyle.Bold);
            this.Controls.Add(text);

            foreach (var kvp in fruitTotals)
            {
                Label fruitLabel = new Label();
                fruitLabel.Text = $"{kvp.Key}: {kvp.Value} kg";
                fruitLabel.Location = new Point(550, startY);
                startY += 40;
                fruitLabel.Font = new Font("Arial", 15, FontStyle.Bold);
                fruitLabel.Size = new Size(150,25);

                this.Controls.Add(fruitLabel);
                fruitLabels[kvp.Key] = fruitLabel;
            }
        }
        #endregion

        #region asd
        #endregion 

        #endregion
    }
}
            
