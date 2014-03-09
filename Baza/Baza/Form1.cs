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
    public partial class Form1 : Form
    {
        MySqlDataAdapter daCountry;
        DataSet dsCountry;
        int zaznaczony=0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)

        {
            wczytajBaze();
            wyszuPo.Items.Add("idPracownik");
            wyszuPo.Items.Add("imie");
            wyszuPo.Items.Add("nazwisko");
            wyszuPo.SelectedIndex = 0;
            
            
        }

        private void dodaj_Click(object sender, EventArgs e)
        {
            Pracownik prac = new Pracownik();
            prac.dodaj(new Pracownik(), "server=localhost;user=root;database=mydb;port=3306;password=Sybilla17;");
            wczytajBaze();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pracownik prac = new Pracownik();
            prac.modyfikuj(new Pracownik(Convert.ToInt32(dataGridView1.Rows[zaznaczony].Cells[0].Value.ToString()),"","","","","","","","","",""),  "server=localhost;user=root;database=mydb;port=3306;password=Sybilla17;");
            wczytajBaze();
        }

        private void dodaje(String id ,String imie, String Nazwisko)
        {
            string connStr = "server=localhost;user=root;database=testy;port=3306;password=Sybilla17;";
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {

                conn.Open();
                // Perform database operations
                string sql = "INSERT INTO pracownicy (Imie, Nazwisko) VALUES ('" + imie + "','" + Nazwisko + "')";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();
            wczytajBaze();
            

            
        }

        private void modyfikuj(String id, String im, String Naz)
        {
            string connStr = "server=localhost;user=root;database=testy;port=3306;password=Sybilla17;";
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {

                conn.Open();
                // Perform database operations UPDATE t_nowe_dane SET koszty = 40 WHERE miesiac = 1
                string sql = "UPDATE `pracownicy` SET Imie = '" + im + "' ,Nazwisko = '" + Naz + "' WHERE id_pracownika= '" +id+"'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();
            wczytajBaze();
            

            
        }
        private void wczytajBaze()
        {
            string connStr = "server=localhost;user=root;database=mydb;port=3306;password=Sybilla17;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {


                string sql = "select idPracownik, imie,nazwisko, k.kod, k.miejscowosc, u.nazwa, nr_budynku, nr_miaszkania, telefon_kont, email, PESEL from pracownik p join Ulica u on u.idUlica=p.Ulica_idUlica join Kod k on k.idKod=u.Kod_idKod;";
                daCountry = new MySqlDataAdapter(sql, conn);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(daCountry);

                dsCountry = new DataSet();
                daCountry.Fill(dsCountry, "Imie");
                dataGridView1.DataSource = dsCountry;
                dataGridView1.DataMember = "Imie";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString()); ;
            }
        }

        private void usun_Click(object sender, EventArgs e)
        {
            if (zaznaczony >= 0)
            {
                string id_prac = dataGridView1.Rows[zaznaczony].Cells[0].Value.ToString();
                string connStr = "server=localhost;user=root;database=mydb;port=3306;password=Sybilla17;";
                MySqlConnection conn = new MySqlConnection(connStr);

                try
                {

                    conn.Open();
                    // Perform database operations
                    string sql = " delete from pracownik where idPracownik = '" + id_prac + "';";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                   // cmd.Parameters.AddWithValue("@id_pra", id_prac);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                conn.Close();
                wczytajBaze();
                zaznaczony = -1;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            zaznaczony=e.RowIndex;
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string connStr = "server=localhost;user=root;database=mydb;port=3306;password=Sybilla17;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {


                string sql = "select idPracownik, imie,nazwisko, k.kod, k.miejscowosc, u.nazwa, nr_budynku, nr_miaszkania, telefon_kont, email, PESEL from pracownik p join Ulica u on u.idUlica=p.Ulica_idUlica join Kod k on k.idKod=u.Kod_idKod WHERE " + wyszuPo.Text + " LIKE '%" + textBox1.Text + "%';";
                daCountry = new MySqlDataAdapter(sql, conn);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(daCountry);

                dsCountry = new DataSet();
                daCountry.Fill(dsCountry, "Imie");
                dataGridView1.DataSource = dsCountry;
                dataGridView1.DataMember = "Imie";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString()); ;
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            int width =Form.ActiveForm.Size.Width;
            int height = Form.ActiveForm.Size.Height;

            dataGridView1.Size = new Size(width - 243, height - 83);
            panel1.Size = new Size(width - 237, height - 63);
            //dataGridView1.Size.Width = width - 243;
        }

        
    }
}
