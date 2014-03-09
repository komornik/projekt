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
            this.textBoxPesel = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxTelefon = new System.Windows.Forms.TextBox();
            this.textBoxMiejscowosc = new System.Windows.Forms.TextBox();
            this.textBoxKod = new System.Windows.Forms.TextBox();
            this.textBoxNrMieszkania = new System.Windows.Forms.TextBox();
            this.textBoxNrBudynku = new System.Windows.Forms.TextBox();
            this.textBoxUlica = new System.Windows.Forms.TextBox();
            this.textBoxNazwisko = new System.Windows.Forms.TextBox();
            this.textBoxImie = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxCzMiejscowosc = new System.Windows.Forms.TextBox();
            this.textBoxCzKodPocztowy = new System.Windows.Forms.TextBox();
            this.textBoxCzUlica = new System.Windows.Forms.TextBox();
            this.textBoxCzEmail = new System.Windows.Forms.TextBox();
            this.textBoxCzTelefon = new System.Windows.Forms.TextBox();
            this.textBoxCzNrMieszkania = new System.Windows.Forms.TextBox();
            this.textBoxCzNrBudynku = new System.Windows.Forms.TextBox();
            this.textBoxCzNazwa = new System.Windows.Forms.TextBox();
            this.textBoxCzNazwisko = new System.Windows.Forms.TextBox();
            this.textBoxCzImie = new System.Windows.Forms.TextBox();
            this.textBoxCzID = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Ksiazki = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Zakladki.SuspendLayout();
            this.Pracownicy.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Czytelnicy.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.Pracownicy.AutoScroll = true;
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
            this.panel1.Controls.Add(this.textBoxPesel);
            this.panel1.Controls.Add(this.textBoxEmail);
            this.panel1.Controls.Add(this.textBoxTelefon);
            this.panel1.Controls.Add(this.textBoxMiejscowosc);
            this.panel1.Controls.Add(this.textBoxKod);
            this.panel1.Controls.Add(this.textBoxNrMieszkania);
            this.panel1.Controls.Add(this.textBoxNrBudynku);
            this.panel1.Controls.Add(this.textBoxUlica);
            this.panel1.Controls.Add(this.textBoxNazwisko);
            this.panel1.Controls.Add(this.textBoxImie);
            this.panel1.Controls.Add(this.textBoxID);
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
            // textBoxPesel
            // 
            this.textBoxPesel.Location = new System.Drawing.Point(183, 372);
            this.textBoxPesel.Name = "textBoxPesel";
            this.textBoxPesel.Size = new System.Drawing.Size(100, 20);
            this.textBoxPesel.TabIndex = 21;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(183, 335);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(100, 20);
            this.textBoxEmail.TabIndex = 20;
            // 
            // textBoxTelefon
            // 
            this.textBoxTelefon.Location = new System.Drawing.Point(183, 289);
            this.textBoxTelefon.Name = "textBoxTelefon";
            this.textBoxTelefon.Size = new System.Drawing.Size(100, 20);
            this.textBoxTelefon.TabIndex = 19;
            // 
            // textBoxMiejscowosc
            // 
            this.textBoxMiejscowosc.Location = new System.Drawing.Point(183, 252);
            this.textBoxMiejscowosc.Name = "textBoxMiejscowosc";
            this.textBoxMiejscowosc.Size = new System.Drawing.Size(100, 20);
            this.textBoxMiejscowosc.TabIndex = 18;
            // 
            // textBoxKod
            // 
            this.textBoxKod.Location = new System.Drawing.Point(183, 212);
            this.textBoxKod.Name = "textBoxKod";
            this.textBoxKod.Size = new System.Drawing.Size(100, 20);
            this.textBoxKod.TabIndex = 17;
            // 
            // textBoxNrMieszkania
            // 
            this.textBoxNrMieszkania.Location = new System.Drawing.Point(183, 174);
            this.textBoxNrMieszkania.Name = "textBoxNrMieszkania";
            this.textBoxNrMieszkania.Size = new System.Drawing.Size(100, 20);
            this.textBoxNrMieszkania.TabIndex = 16;
            // 
            // textBoxNrBudynku
            // 
            this.textBoxNrBudynku.Location = new System.Drawing.Point(183, 138);
            this.textBoxNrBudynku.Name = "textBoxNrBudynku";
            this.textBoxNrBudynku.Size = new System.Drawing.Size(100, 20);
            this.textBoxNrBudynku.TabIndex = 15;
            // 
            // textBoxUlica
            // 
            this.textBoxUlica.Location = new System.Drawing.Point(183, 104);
            this.textBoxUlica.Name = "textBoxUlica";
            this.textBoxUlica.Size = new System.Drawing.Size(100, 20);
            this.textBoxUlica.TabIndex = 14;
            // 
            // textBoxNazwisko
            // 
            this.textBoxNazwisko.Location = new System.Drawing.Point(183, 75);
            this.textBoxNazwisko.Name = "textBoxNazwisko";
            this.textBoxNazwisko.Size = new System.Drawing.Size(100, 20);
            this.textBoxNazwisko.TabIndex = 13;
            // 
            // textBoxImie
            // 
            this.textBoxImie.Location = new System.Drawing.Point(183, 42);
            this.textBoxImie.Name = "textBoxImie";
            this.textBoxImie.Size = new System.Drawing.Size(100, 20);
            this.textBoxImie.TabIndex = 12;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(183, 14);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(100, 20);
            this.textBoxID.TabIndex = 11;
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
            this.Czytelnicy.Controls.Add(this.panel2);
            this.Czytelnicy.Controls.Add(this.comboBox2);
            this.Czytelnicy.Controls.Add(this.label2);
            this.Czytelnicy.Location = new System.Drawing.Point(4, 22);
            this.Czytelnicy.Name = "Czytelnicy";
            this.Czytelnicy.Padding = new System.Windows.Forms.Padding(3);
            this.Czytelnicy.Size = new System.Drawing.Size(757, 435);
            this.Czytelnicy.TabIndex = 1;
            this.Czytelnicy.Text = "Czytelnicy";
            this.Czytelnicy.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBoxCzMiejscowosc);
            this.panel2.Controls.Add(this.textBoxCzKodPocztowy);
            this.panel2.Controls.Add(this.textBoxCzUlica);
            this.panel2.Controls.Add(this.textBoxCzEmail);
            this.panel2.Controls.Add(this.textBoxCzTelefon);
            this.panel2.Controls.Add(this.textBoxCzNrMieszkania);
            this.panel2.Controls.Add(this.textBoxCzNrBudynku);
            this.panel2.Controls.Add(this.textBoxCzNazwa);
            this.panel2.Controls.Add(this.textBoxCzNazwisko);
            this.panel2.Controls.Add(this.textBoxCzImie);
            this.panel2.Controls.Add(this.textBoxCzID);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(134, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(615, 422);
            this.panel2.TabIndex = 2;
            // 
            // textBoxCzMiejscowosc
            // 
            this.textBoxCzMiejscowosc.Location = new System.Drawing.Point(179, 346);
            this.textBoxCzMiejscowosc.Name = "textBoxCzMiejscowosc";
            this.textBoxCzMiejscowosc.Size = new System.Drawing.Size(100, 20);
            this.textBoxCzMiejscowosc.TabIndex = 21;
            // 
            // textBoxCzKodPocztowy
            // 
            this.textBoxCzKodPocztowy.Location = new System.Drawing.Point(179, 312);
            this.textBoxCzKodPocztowy.Name = "textBoxCzKodPocztowy";
            this.textBoxCzKodPocztowy.Size = new System.Drawing.Size(100, 20);
            this.textBoxCzKodPocztowy.TabIndex = 20;
            // 
            // textBoxCzUlica
            // 
            this.textBoxCzUlica.Location = new System.Drawing.Point(179, 277);
            this.textBoxCzUlica.Name = "textBoxCzUlica";
            this.textBoxCzUlica.Size = new System.Drawing.Size(100, 20);
            this.textBoxCzUlica.TabIndex = 19;
            // 
            // textBoxCzEmail
            // 
            this.textBoxCzEmail.Location = new System.Drawing.Point(179, 240);
            this.textBoxCzEmail.Name = "textBoxCzEmail";
            this.textBoxCzEmail.Size = new System.Drawing.Size(100, 20);
            this.textBoxCzEmail.TabIndex = 18;
            // 
            // textBoxCzTelefon
            // 
            this.textBoxCzTelefon.Location = new System.Drawing.Point(179, 205);
            this.textBoxCzTelefon.Name = "textBoxCzTelefon";
            this.textBoxCzTelefon.Size = new System.Drawing.Size(100, 20);
            this.textBoxCzTelefon.TabIndex = 17;
            // 
            // textBoxCzNrMieszkania
            // 
            this.textBoxCzNrMieszkania.Location = new System.Drawing.Point(179, 169);
            this.textBoxCzNrMieszkania.Name = "textBoxCzNrMieszkania";
            this.textBoxCzNrMieszkania.Size = new System.Drawing.Size(100, 20);
            this.textBoxCzNrMieszkania.TabIndex = 16;
            // 
            // textBoxCzNrBudynku
            // 
            this.textBoxCzNrBudynku.Location = new System.Drawing.Point(179, 137);
            this.textBoxCzNrBudynku.Name = "textBoxCzNrBudynku";
            this.textBoxCzNrBudynku.Size = new System.Drawing.Size(100, 20);
            this.textBoxCzNrBudynku.TabIndex = 15;
            // 
            // textBoxCzNazwa
            // 
            this.textBoxCzNazwa.Location = new System.Drawing.Point(179, 103);
            this.textBoxCzNazwa.Name = "textBoxCzNazwa";
            this.textBoxCzNazwa.Size = new System.Drawing.Size(100, 20);
            this.textBoxCzNazwa.TabIndex = 14;
            // 
            // textBoxCzNazwisko
            // 
            this.textBoxCzNazwisko.Location = new System.Drawing.Point(179, 72);
            this.textBoxCzNazwisko.Name = "textBoxCzNazwisko";
            this.textBoxCzNazwisko.Size = new System.Drawing.Size(100, 20);
            this.textBoxCzNazwisko.TabIndex = 13;
            // 
            // textBoxCzImie
            // 
            this.textBoxCzImie.Location = new System.Drawing.Point(179, 42);
            this.textBoxCzImie.Name = "textBoxCzImie";
            this.textBoxCzImie.Size = new System.Drawing.Size(100, 20);
            this.textBoxCzImie.TabIndex = 12;
            // 
            // textBoxCzID
            // 
            this.textBoxCzID.Location = new System.Drawing.Point(179, 14);
            this.textBoxCzID.Name = "textBoxCzID";
            this.textBoxCzID.ReadOnly = true;
            this.textBoxCzID.Size = new System.Drawing.Size(100, 20);
            this.textBoxCzID.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1, 353);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Miejscowość";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1, 212);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Nr Telefonu";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1, 319);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Kod Pocztowy";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1, 284);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Ulica";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1, 247);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Nr Mieszkania";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Nr Budynku";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Nazwa Uzytkownika";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nazwisko";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Imie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "ID Czytelnika";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Dodaj Czytelnika"});
            this.comboBox2.Location = new System.Drawing.Point(8, 19);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Czytelnicy";
            // 
            // Ksiazki
            // 
            this.Ksiazki.Controls.Add(this.panel3);
            this.Ksiazki.Controls.Add(this.label14);
            this.Ksiazki.Location = new System.Drawing.Point(4, 22);
            this.Ksiazki.Name = "Ksiazki";
            this.Ksiazki.Padding = new System.Windows.Forms.Padding(3);
            this.Ksiazki.Size = new System.Drawing.Size(757, 435);
            this.Ksiazki.TabIndex = 2;
            this.Ksiazki.Text = "Ksiazki";
            this.Ksiazki.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(139, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(610, 422);
            this.panel3.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Wyszukaj Książke";
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
            this.Czytelnicy.ResumeLayout(false);
            this.Czytelnicy.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.Ksiazki.ResumeLayout(false);
            this.Ksiazki.PerformLayout();
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
        private System.Windows.Forms.TextBox textBoxPesel;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxTelefon;
        private System.Windows.Forms.TextBox textBoxMiejscowosc;
        private System.Windows.Forms.TextBox textBoxKod;
        private System.Windows.Forms.TextBox textBoxNrMieszkania;
        private System.Windows.Forms.TextBox textBoxNrBudynku;
        private System.Windows.Forms.TextBox textBoxUlica;
        private System.Windows.Forms.TextBox textBoxNazwisko;
        private System.Windows.Forms.TextBox textBoxImie;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCzMiejscowosc;
        private System.Windows.Forms.TextBox textBoxCzKodPocztowy;
        private System.Windows.Forms.TextBox textBoxCzUlica;
        private System.Windows.Forms.TextBox textBoxCzEmail;
        private System.Windows.Forms.TextBox textBoxCzTelefon;
        private System.Windows.Forms.TextBox textBoxCzNrMieszkania;
        private System.Windows.Forms.TextBox textBoxCzNrBudynku;
        private System.Windows.Forms.TextBox textBoxCzNazwa;
        private System.Windows.Forms.TextBox textBoxCzNazwisko;
        private System.Windows.Forms.TextBox textBoxCzImie;
        private System.Windows.Forms.TextBox textBoxCzID;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label14;
    }
}

