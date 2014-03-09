using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
   public class Pracownik: Czlowiek 
    {
        string connStr ;
        public Pracownik() { }

        public Pracownik(int id,String imie, String nazwisko, String ulica ,String nr_dom,
            String nr_mieszkania, String nr_kod, String miasto, String email,
            String tel, String PESEL)
            : base(id, imie, nazwisko, ulica, 
            nr_dom, nr_mieszkania, nr_kod, miasto,
            email, tel, PESEL)
        {

        }

        public override bool dodaj(Czlowiek osoba, String connStr)
        {
            this.connStr = connStr;
            PracownikForm d = new PracownikForm();
            d.okDodaj += new PracownikForm.opcjeFontu(dodaje);
            DialogResult result = d.ShowDialog();
            return true;

            
        }

        private void dodaje(Czlowiek osoba)
        {
           String id_miejsc= "";
           String id_ulica = "";
            
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {

                conn.Open();
                // Sprawdzenie czy wbazie zanajduje się miejscowosc
                string sql = "SELECT idKod FROM kod WHERE kod = @kod AND miejscowosc= @miejscowosc";
                
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@kod", osoba.nr_kod );
                cmd.Parameters.AddWithValue("@miejscowosc", osoba.miasto);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    id_miejsc=rdr[0].ToString();
                    
                }
                rdr.Close();
                conn.Close();
                if (id_miejsc.Length == 0)
                {
                    conn.Open();
                   
                    sql = "INSERT INTO kod (kod, miejscowosc) VALUES ( @kod , @miejscowosc)";
                    cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@kod", osoba.nr_kod);
                    cmd.Parameters.AddWithValue("@miejscowosc", osoba.miasto);
                     cmd.ExecuteNonQuery();
                     sql = "SELECT idKod FROM kod WHERE kod = @kod AND miejscowosc= @miejscowosc";

                     cmd = new MySqlCommand(sql, conn);
                     cmd.Parameters.AddWithValue("@kod", osoba.nr_kod);
                     cmd.Parameters.AddWithValue("@miejscowosc", osoba.miasto);
                     rdr = cmd.ExecuteReader();

                     while (rdr.Read())
                     {
                         id_miejsc = rdr[0].ToString();

                     }
                     rdr.Close();
                    conn.Close();
                }


                //sprawdzenie czy w bazie znajduje się ulica
                conn.Open();
                sql = "SELECT idUlica FROM ulica WHERE nazwa = @nazwa AND Kod_idKod = @Kod";

                cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nazwa", osoba.ulica);
                cmd.Parameters.AddWithValue("@Kod", id_miejsc);
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    id_ulica = rdr[0].ToString();

                }
                rdr.Close();
                conn.Close();
                if (id_ulica.Length == 0)
                {
                    conn.Open();

                    sql = "INSERT INTO ulica (nazwa, Kod_idKod) VALUES ( @nazwa , @Kod)";
                    cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@nazwa", osoba.ulica);
                    cmd.Parameters.AddWithValue("@Kod", id_miejsc);
                    cmd.ExecuteNonQuery();
                    sql = "SELECT idUlica FROM ulica WHERE nazwa = @nazwa AND Kod_idKod = @Kod";

                    cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@nazwa", osoba.ulica);
                    cmd.Parameters.AddWithValue("@Kod", id_miejsc);
                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        id_ulica = rdr[0].ToString();

                    }
                    rdr.Close();
                    conn.Close();
                }


                // sprawdzenie czy pracownik istnieje
                string id_prac = "";
                     conn.Open();
                sql = "SELECT idPracownik FROM pracownik WHERE imie = @imie AND nazwisko = @nazwisko AND Ulica_idUlica = @ulica AND nr_budynku= @budynek AND PESEL = @pesel";

                cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@imie", osoba.imie);
                cmd.Parameters.AddWithValue("@nazwisko", osoba.nazwisko);
                cmd.Parameters.AddWithValue("@ulica", id_ulica);
                cmd.Parameters.AddWithValue("@budynek", osoba.nr_dom);
                cmd.Parameters.AddWithValue("@PESEL", osoba.PESEL);
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    id_prac = rdr[0].ToString();

                }
                rdr.Close();
                conn.Close();
                if (id_prac.Length == 0)
                {
                    conn.Open();

                    sql = "INSERT INTO pracownik (imie, nazwisko , Ulica_idUlica, nr_budynku, nr_miaszkania, telefon_kont, email, PESEL) VALUES ( @imie, @nazwisko , @Ulica, @nr_budynku, @nr_mieszkania, @telefon_kont, @email , @PESEL)";
                    cmd = new MySqlCommand(sql, conn);
                    
                    cmd.Parameters.AddWithValue("@imie", osoba.imie);
                    cmd.Parameters.AddWithValue("@nazwisko", osoba.nazwisko);
                    cmd.Parameters.AddWithValue("@Ulica", id_ulica);
                    cmd.Parameters.AddWithValue("@nr_budynku", osoba.nr_dom);
                    cmd.Parameters.AddWithValue("@nr_mieszkania", osoba.nr_mieszkania);
                    cmd.Parameters.AddWithValue("@telefon_kont", osoba.tel);
                    cmd.Parameters.AddWithValue("@email", osoba.email);
                    cmd.Parameters.AddWithValue("@PESEL", osoba.PESEL);

                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                


                MessageBox.Show(id_miejsc + " " + id_ulica);
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.ToString());
            }
            conn.Close();
            //wczytajBaze();

           



        }

        public override bool modyfikuj(Czlowiek osoba, string connStr)
        {
            this.connStr = connStr;
            PracownikForm d = new PracownikForm(Convert.ToString(osoba.id),"","");
            d.okDodaj += new PracownikForm.opcjeFontu(modyfikuje);
            DialogResult result = d.ShowDialog();
            return true;
            
        }

        private void modyfikuje(Czlowiek osoba)
        {
            String id_miejsc = "";
            String id_ulica = "";
            string connStr = "server=localhost;user=root;database=mydb;port=3306;password=Sybilla17;";
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {

                conn.Open();

                string sql = "SELECT idKod FROM kod WHERE kod = @kod AND miejscowosc= @miejscowosc";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@kod", osoba.nr_kod);
                cmd.Parameters.AddWithValue("@miejscowosc", osoba.miasto);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    id_miejsc = rdr[0].ToString();

                }
                rdr.Close();
                conn.Close();
                if (id_miejsc.Length == 0)
                {
                    conn.Open();

                    sql = "INSERT INTO kod (kod, miejscowosc) VALUES ( @kod , @miejscowosc)";
                    cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@kod", osoba.nr_kod);
                    cmd.Parameters.AddWithValue("@miejscowosc", osoba.miasto);
                    cmd.ExecuteNonQuery();
                    sql = "SELECT idKod FROM kod WHERE kod = @kod AND miejscowosc= @miejscowosc";

                    cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@kod", osoba.nr_kod);
                    cmd.Parameters.AddWithValue("@miejscowosc", osoba.miasto);
                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        id_miejsc = rdr[0].ToString();

                    }
                    rdr.Close();
                    conn.Close();
                }


                //sprawdzenie czy w bazie znajduje się ulica
                conn.Open();
                sql = "SELECT idUlica FROM ulica WHERE nazwa = @nazwa AND Kod_idKod = @Kod";

                cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nazwa", osoba.ulica);
                cmd.Parameters.AddWithValue("@Kod", id_miejsc);
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    id_ulica = rdr[0].ToString();

                }
                rdr.Close();
                conn.Close();
                if (id_ulica.Length == 0)
                {
                    conn.Open();

                    sql = "INSERT INTO ulica (nazwa, Kod_idKod) VALUES ( @nazwa , @Kod)";
                    cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@nazwa", osoba.ulica);
                    cmd.Parameters.AddWithValue("@Kod", id_miejsc);
                    cmd.ExecuteNonQuery();
                    sql = "SELECT idUlica FROM ulica WHERE nazwa = @nazwa AND Kod_idKod = @Kod";

                    cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@nazwa", osoba.ulica);
                    cmd.Parameters.AddWithValue("@Kod", id_miejsc);
                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        id_ulica = rdr[0].ToString();

                    }
                    rdr.Close();
                    conn.Close();
                }
                // Perform database operations UPDATE t_nowe_dane SET koszty = 40 WHERE miesiac = 1
                sql = "Update `pracownik` SET imie=@imie ,nazwisko=@nazwisko , Ulica_idUlica =@Ulica, nr_budynku=@nr_budynku, nr_miaszkania=@nr_mieszkania, telefon_kont=@telefon_kont, email=@email , pesel=@PESEL where idPracownik =@prac;";
                conn.Open();
               
                    cmd = new MySqlCommand(sql, conn);
                    
                    cmd.Parameters.AddWithValue("@imie", osoba.imie);
                    cmd.Parameters.AddWithValue("@nazwisko", osoba.nazwisko);
                    cmd.Parameters.AddWithValue("@Ulica", id_ulica);
                    cmd.Parameters.AddWithValue("@nr_budynku", osoba.nr_dom);
                    cmd.Parameters.AddWithValue("@nr_mieszkania", osoba.nr_mieszkania);
                    cmd.Parameters.AddWithValue("@telefon_kont", osoba.tel);
                    cmd.Parameters.AddWithValue("@email", osoba.email);
                    cmd.Parameters.AddWithValue("@PESEL", osoba.PESEL);
                    cmd.Parameters.AddWithValue("@prac", osoba.id);
                 
                
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();
            
        }

    }
}
