namespace WindowsFormsApplication1
{
    partial class PracownikForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.imie = new System.Windows.Forms.TextBox();
            this.nazwisko = new System.Windows.Forms.TextBox();
            this.nr_dom = new System.Windows.Forms.TextBox();
            this.ulica = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.miejscowosc = new System.Windows.Forms.TextBox();
            this.kod = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.telefon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nr_miesz = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.PESEL = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(208, 270);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "Anuluj";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Imie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nazwisko";
            // 
            // imie
            // 
            this.imie.Location = new System.Drawing.Point(113, 30);
            this.imie.Name = "imie";
            this.imie.Size = new System.Drawing.Size(112, 20);
            this.imie.TabIndex = 4;
            // 
            // nazwisko
            // 
            this.nazwisko.Location = new System.Drawing.Point(113, 60);
            this.nazwisko.Name = "nazwisko";
            this.nazwisko.Size = new System.Drawing.Size(112, 20);
            this.nazwisko.TabIndex = 5;
            // 
            // nr_dom
            // 
            this.nr_dom.Location = new System.Drawing.Point(113, 134);
            this.nr_dom.Name = "nr_dom";
            this.nr_dom.Size = new System.Drawing.Size(112, 20);
            this.nr_dom.TabIndex = 9;
            // 
            // ulica
            // 
            this.ulica.Location = new System.Drawing.Point(113, 104);
            this.ulica.Name = "ulica";
            this.ulica.Size = new System.Drawing.Size(112, 20);
            this.ulica.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Numer Domu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ulica";
            // 
            // miejscowosc
            // 
            this.miejscowosc.Location = new System.Drawing.Point(340, 60);
            this.miejscowosc.Name = "miejscowosc";
            this.miejscowosc.Size = new System.Drawing.Size(112, 20);
            this.miejscowosc.TabIndex = 13;
            // 
            // kod
            // 
            this.kod.Location = new System.Drawing.Point(340, 30);
            this.kod.Name = "kod";
            this.kod.Size = new System.Drawing.Size(112, 20);
            this.kod.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(264, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Miejscowosc";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(264, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Kod pocztowy";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(340, 134);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(112, 20);
            this.email.TabIndex = 17;
            // 
            // telefon
            // 
            this.telefon.Location = new System.Drawing.Point(340, 104);
            this.telefon.Name = "telefon";
            this.telefon.Size = new System.Drawing.Size(112, 20);
            this.telefon.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(264, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(264, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "telefon";
            // 
            // nr_miesz
            // 
            this.nr_miesz.Location = new System.Drawing.Point(113, 163);
            this.nr_miesz.Name = "nr_miesz";
            this.nr_miesz.Size = new System.Drawing.Size(112, 20);
            this.nr_miesz.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Numer Mieszkania";
            // 
            // PESEL
            // 
            this.PESEL.Location = new System.Drawing.Point(340, 163);
            this.PESEL.Name = "PESEL";
            this.PESEL.Size = new System.Drawing.Size(112, 20);
            this.PESEL.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(264, 170);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "PESEL";
            // 
            // PracownikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 351);
            this.Controls.Add(this.PESEL);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.nr_miesz);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.email);
            this.Controls.Add(this.telefon);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.miejscowosc);
            this.Controls.Add(this.kod);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nr_dom);
            this.Controls.Add(this.ulica);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nazwisko);
            this.Controls.Add(this.imie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "PracownikForm";
            this.Text = "dane";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox imie;
        private System.Windows.Forms.TextBox nazwisko;
        private System.Windows.Forms.TextBox nr_dom;
        private System.Windows.Forms.TextBox ulica;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox miejscowosc;
        private System.Windows.Forms.TextBox kod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox telefon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox nr_miesz;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox PESEL;
        private System.Windows.Forms.Label label10;
    }
}