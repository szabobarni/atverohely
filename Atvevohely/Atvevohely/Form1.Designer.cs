namespace Atvevohely
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.termelok = new System.Windows.Forms.Button();
            this.gyumolcsok = new System.Windows.Forms.Button();
            this.atvetel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // termelok
            // 
            this.termelok.Location = new System.Drawing.Point(451, 36);
            this.termelok.Name = "termelok";
            this.termelok.Size = new System.Drawing.Size(223, 64);
            this.termelok.TabIndex = 0;
            this.termelok.Text = "Termelők";
            this.termelok.UseVisualStyleBackColor = true;
            this.termelok.Click += new System.EventHandler(this.termelok_Click);
            // 
            // gyumolcsok
            // 
            this.gyumolcsok.Location = new System.Drawing.Point(451, 172);
            this.gyumolcsok.Name = "gyumolcsok";
            this.gyumolcsok.Size = new System.Drawing.Size(223, 64);
            this.gyumolcsok.TabIndex = 1;
            this.gyumolcsok.Text = "Gyümölcsök";
            this.gyumolcsok.UseVisualStyleBackColor = true;
            this.gyumolcsok.Click += new System.EventHandler(this.gyumolcsok_Click);
            // 
            // atvetel
            // 
            this.atvetel.Location = new System.Drawing.Point(451, 326);
            this.atvetel.Name = "atvetel";
            this.atvetel.Size = new System.Drawing.Size(223, 64);
            this.atvetel.TabIndex = 2;
            this.atvetel.Text = "Átvétel";
            this.atvetel.UseVisualStyleBackColor = true;
            this.atvetel.Click += new System.EventHandler(this.atvetel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.atvetel);
            this.Controls.Add(this.gyumolcsok);
            this.Controls.Add(this.termelok);
            this.Name = "Form1";
            this.Text = "Gyümölcs átvevőhely";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button termelok;
        private System.Windows.Forms.Button gyumolcsok;
        private System.Windows.Forms.Button atvetel;
    }
}

