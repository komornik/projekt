using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    public partial class PracownikForm : Form
    {
        public delegate void opcjeFontu(Czlowiek osoba);
        public event opcjeFontu okDodaj;
        String id_pracownika="0";
        public PracownikForm()
        {
            InitializeComponent();
        }
        public PracownikForm(String id, String imie, String Nazwisko)
        {
            InitializeComponent();
            this.imie.Text = imie;
            this.nazwisko.Text = Nazwisko;
            
            id_pracownika = id;
            String connStr = "server=localhost;user=root;database=mydb;port=3306;password=Sybilla17;";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            string sql = "select idPracownik, imie,nazwisko, k.kod, k.miejscowosc, u.nazwa, nr_budynku, nr_miaszkania, telefon_kont, email, PESEL from pracownik p join Ulica u on u.idUlica=p.Ulica_idUlica join Kod k on k.idKod=u.Kod_idKod where idPracownik =@prac;";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@prac", id );

            MySqlDataReader rdr = cmd.ExecuteReader();
            try
            {
                while (rdr.Read())
                {
                    this.imie.Text = rdr[1].ToString();
                    this.nazwisko.Text = rdr[2].ToString();
                    this.kod.Text = rdr[3].ToString();
                    this.miejscowosc.Text = rdr[4].ToString();
                    this.ulica.Text = rdr[5].ToString();
                    this.nr_dom.Text = rdr[6].ToString();
                    this.nr_miesz.Text = rdr[7].ToString();
                    this.telefon.Text = rdr[8].ToString();
                    this.email.Text = rdr[9].ToString();
                    this.PESEL.Text = rdr[10].ToString();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString()); ;
            }
            conn.Close();
            
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (walidacja())
            {
                Form.ActiveForm.DialogResult = DialogResult.OK;

                okDodaj(new Pracownik(Convert.ToInt32(id_pracownika),imie.Text,nazwisko.Text,ulica.Text,nr_dom.Text,nr_miesz.Text,kod.Text,miejscowosc.Text,email.Text,telefon.Text,PESEL.Text));
            }
            
        }
        private bool walidacja()
        {
            bool validate = true;
            String im = imie.Text.Replace(" ", "");
            String na = nazwisko.Text.Replace(" ", "");
            if (im.Length < 2)
            {
                imie.BackColor= Color.Red;
                validate = false;
            }else{
                imie.BackColor= Color.White;
            }
            if (na.Length < 2)
            {
                nazwisko.BackColor = Color.Red;
                validate = false;
            }
            else
            {
                nazwisko.BackColor = Color.White;
            }

            return validate;
        }
    }
}
