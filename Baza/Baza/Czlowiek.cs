using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace WindowsFormsApplication1
{
    public class Czlowiek
    {
        
       public String imie, nazwisko, ulica , nr_dom, nr_mieszkania, nr_kod, miasto, email, tel, PESEL;
       public int id;
        public Czlowiek() { }


        public Czlowiek(int id,String imie, String nazwisko, String ulica ,String nr_dom,
            String nr_mieszkania, String nr_kod, String miasto, String email,
            String tel, String PESEL)
        {
            this.id = id;
            this.imie = imie;
            this.nazwisko= nazwisko;
            this.ulica= ulica;
            this.nr_dom= nr_dom;
            this.nr_mieszkania=nr_mieszkania;
            this.nr_kod=nr_kod;
            this.miasto=miasto;
            this.email= email;
            this.tel=tel;
            this.PESEL = PESEL;

        }

        public virtual bool pobierz(DataGridView data,String connStr ){

            return true;
        }

        public virtual bool dodaj(Czlowiek osoba,String connStr ){

            return true;
        }

        public virtual bool modyfikuj(Czlowiek osoba,String connStr )
        {

            return true;
        }

        public virtual bool usun(Czlowiek osoba,String connStr )
        {

            return true;
        }


    }
}
