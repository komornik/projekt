namespace Biblioteka
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
            this.Zakladki = new System.Windows.Forms.TabControl();
            this.Pracownicy = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Kod_pracownika = new System.Windows.Forms.Label();
            this.Nrmieszkania_pracownika = new System.Windows.Forms.Label();
            this.Telefon_pracownika = new System.Windows.Forms.Label();
            this.Miejscowosc_pracownika = new System.Windows.Forms.Label();
            this.Pesel_pracownika = new System.Windows.Forms.Label();
            this.Id_pracownika = new System.Windows.Forms.Label();
            this.Email_pracownika = new System.Windows.Forms.Label();
            this.Nrbudynku_pracownika = new System.Windows.Forms.Label();
            this.Ulica_pracownika = new System.Windows.Forms.Label();
            this.Nazwisko_pracownika = new System.Windows.Forms.Label();
            this.Imie_pracownika = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Czytelnicy = new System.Windows.Forms.TabPage();
            this.Ksiazki = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Zakladki.SuspendLayout();
            this.Pracownicy.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Ksiazki.SuspendLayout();
            this.SuspendLayout();
            // 
            // Zakladki
            // 
            this.Zakladki.Controls.Add(this.Pracownicy);
            this.Zakladki.Controls.Add(this.Czytelnicy);
            this.Zakladki.Controls.Add(this.Ksiazki);
            this.Zakladki.Location = new System.Drawing.Point(1, 27);
            this.Zakladki.Name = "Zakladki";
            this.Zakladki.SelectedIndex = 0;
            this.Zakladki.Size = new System.Drawing.Size(765, 461);
            this.Zakladki.TabIndex = 0;
            // 
            // Pracownicy
            // 
            this.Pracownicy.Controls.Add(this.panel1);
            this.Pracownicy.Controls.Add(this.comboBox1);
            this.Pracownicy.Controls.Add(this.label1);
            this.Pracownicy.Location = new System.Drawing.Point(4, 22);
            this.Pracownicy.Name = "Pracownicy";
            this.Pracownicy.Padding = new System.Windows.Forms.Padding(3);
            this.Pracownicy.Size = new System.Drawing.Size(757, 435);
            this.Pracownicy.TabIndex = 0;
            this.Pracownicy.Text = "Pracownicy";
            this.Pracownicy.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Kod_pracownika);
            this.panel1.Controls.Add(this.Nrmieszkania_pracownika);
            this.panel1.Controls.Add(this.Telefon_pracownika);
            this.panel1.Controls.Add(this.Miejscowosc_pracownika);
            this.panel1.Controls.Add(this.Pesel_pracownika);
            this.panel1.Controls.Add(this.Id_pracownika);
            this.panel1.Controls.Add(this.Email_pracownika);
            this.panel1.Controls.Add(this.Nrbudynku_pracownika);
            this.panel1.Controls.Add(this.Ulica_pracownika);
            this.panel1.Controls.Add(this.Nazwisko_pracownika);
            this.panel1.Controls.Add(this.Imie_pracownika);
            this.panel1.Location = new System.Drawing.Point(138, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(615, 422);
            this.panel1.TabIndex = 3;
            // 
            // Kod_pracownika
            // 
            this.Kod_pracownika.AutoSize = true;
            this.Kod_pracownika.Location = new System.Drawing.Point(3, 220);
            this.Kod_pracownika.Name = "Kod_pracownika";
            this.Kod_pracownika.Size = new System.Drawing.Size(75, 13);
            this.Kod_pracownika.TabIndex = 10;
            this.Kod_pracownika.Text = "Kod Pocztowy";
            // 
            // Nrmieszkania_pracownika
            // 
            this.Nrmieszkania_pracownika.AutoSize = true;
            this.Nrmieszkania_pracownika.Location = new System.Drawing.Point(3, 182);
            this.Nrmieszkania_pracownika.Name = "Nrmieszkania_pracownika";
            this.Nrmieszkania_pracownika.Size = new System.Drawing.Size(74, 13);
            this.Nrmieszkania_pracownika.TabIndex = 9;
            this.Nrmieszkania_pracownika.Text = "Nr Mieszkania";
            // 
            // Telefon_pracownika
            // 
            this.Telefon_pracownika.AutoSize = true;
            this.Telefon_pracownika.Location = new System.Drawing.Point(3, 297);
            this.Telefon_pracownika.Name = "Telefon_pracownika";
            this.Telefon_pracownika.Size = new System.Drawing.Size(43, 13);
            this.Telefon_pracownika.TabIndex = 8;
            this.Telefon_pracownika.Text = "Telefon";
            // 
            // Miejscowosc_pracownika
            // 
            this.Miejscowosc_pracownika.AutoSize = true;
            this.Miejscowosc_pracownika.Location = new System.Drawing.Point(3, 259);
            this.Miejscowosc_pracownika.Name = "Miejscowosc_pracownika";
            this.Miejscowosc_pracownika.Size = new System.Drawing.Size(68, 13);
            this.Miejscowosc_pracownika.TabIndex = 7;
            this.Miejscowosc_pracownika.Text = "Miejscowość";
            // 
            // Pesel_pracownika
            // 
            this.Pesel_pracownika.AutoSize = true;
            this.Pesel_pracownika.Location = new System.Drawing.Point(3, 380);
            this.Pesel_pracownika.Name = "Pesel_pracownika";
            this.Pesel_pracownika.Size = new System.Drawing.Size(33, 13);
            this.Pesel_pracownika.TabIndex = 6;
            this.Pesel_pracownika.Text = "Pesel";
            // 
            // Id_pracownika
            // 
            this.Id_pracownika.AutoSize = true;
            this.Id_pracownika.Location = new System.Drawing.Point(3, 21);
            this.Id_pracownika.Name = "Id_pracownika";
            this.Id_pracownika.Size = new System.Drawing.Size(77, 13);
            this.Id_pracownika.TabIndex = 5;
            this.Id_pracownika.Text = "ID Pracownika";
            // 
            // Email_pracownika
            // 
            this.Email_pracownika.AutoSize = true;
            this.Email_pracownika.Location = new System.Drawing.Point(3, 342);
            this.Email_pracownika.Name = "Email_pracownika";
            this.Email_pracownika.Size = new System.Drawing.Size(32, 13);
            this.Email_pracownika.TabIndex = 4;
            this.Email_pracownika.Text = "Email";
            // 
            // Nrbudynku_pracownika
            // 
            this.Nrbudynku_pracownika.AutoSize = true;
            this.Nrbudynku_pracownika.Location = new System.Drawing.Point(3, 146);
            this.Nrbudynku_pracownika.Name = "Nrbudynku_pracownika";
            this.Nrbudynku_pracownika.Size = new System.Drawing.Size(63, 13);
            this.Nrbudynku_pracownika.TabIndex = 3;
            this.Nrbudynku_pracownika.Text = "Nr Budynku";
            // 
            // Ulica_pracownika
            // 
            this.Ulica_pracownika.AutoSize = true;
            this.Ulica_pracownika.Location = new System.Drawing.Point(3, 112);
            this.Ulica_pracownika.Name = "Ulica_pracownika";
            this.Ulica_pracownika.Size = new System.Drawing.Size(31, 13);
            this.Ulica_pracownika.TabIndex = 2;
            this.Ulica_pracownika.Text = "Ulica";
            // 
            // Nazwisko_pracownika
            // 
            this.Nazwisko_pracownika.AutoSize = true;
            this.Nazwisko_pracownika.Location = new System.Drawing.Point(3, 82);
            this.Nazwisko_pracownika.Name = "Nazwisko_pracownika";
            this.Nazwisko_pracownika.Size = new System.Drawing.Size(53, 13);
            this.Nazwisko_pracownika.TabIndex = 1;
            this.Nazwisko_pracownika.Text = "Nazwisko";
            // 
            // Imie_pracownika
            // 
            this.Imie_pracownika.AutoSize = true;
            this.Imie_pracownika.Location = new System.Drawing.Point(3, 49);
            this.Imie_pracownika.Name = "Imie_pracownika";
            this.Imie_pracownika.Size = new System.Drawing.Size(26, 13);
            this.Imie_pracownika.TabIndex = 0;
            this.Imie_pracownika.Text = "Imie";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pracownicy";
            // 
            // Czytelnicy
            // 
            this.Czytelnicy.Location = new System.Drawing.Point(4, 22);
            this.Czytelnicy.Name = "Czytelnicy";
            this.Czytelnicy.Padding = new System.Windows.Forms.Padding(3);
            this.Czytelnicy.Size = new System.Drawing.Size(757, 435);
            this.Czytelnicy.TabIndex = 1;
            this.Czytelnicy.Text = "Czytelnicy";
            this.Czytelnicy.UseVisualStyleBackColor = true;
            // 
            // Ksiazki
            // 
            this.Ksiazki.Controls.Add(this.button1);
            this.Ksiazki.Location = new System.Drawing.Point(4, 22);
            this.Ksiazki.Name = "Ksiazki";
            this.Ksiazki.Padding = new System.Windows.Forms.Padding(3);
            this.Ksiazki.Size = new System.Drawing.Size(757, 435);
            this.Ksiazki.TabIndex = 2;
            this.Ksiazki.Text = "Ksiazki";
            this.Ksiazki.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(766, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 489);
            this.Controls.Add(this.Zakladki);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.Zakladki.ResumeLayout(false);
            this.Pracownicy.ResumeLayout(false);
            this.Pracownicy.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Ksiazki.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl Zakladki;
        private System.Windows.Forms.TabPage Pracownicy;
        private System.Windows.Forms.TabPage Czytelnicy;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage Ksiazki;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Kod_pracownika;
        private System.Windows.Forms.Label Nrmieszkania_pracownika;
        private System.Windows.Forms.Label Telefon_pracownika;
        private System.Windows.Forms.Label Miejscowosc_pracownika;
        private System.Windows.Forms.Label Pesel_pracownika;
        private System.Windows.Forms.Label Id_pracownika;
        private System.Windows.Forms.Label Email_pracownika;
        private System.Windows.Forms.Label Nrbudynku_pracownika;
        private System.Windows.Forms.Label Ulica_pracownika;
        private System.Windows.Forms.Label Nazwisko_pracownika;
        private System.Windows.Forms.Label Imie_pracownika;
    }
}

