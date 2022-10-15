using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDolgozo
{
    public partial class FormDolgozo : Form
    {
        string muvelet;
        private Dolgozo kivalasztottDolgozo; //legeneráltuk az "update" case-nél

        public FormDolgozo(string muvelet) //adunk neki egy konstruktort, ami a műveletek adja vissza
        {
            InitializeComponent();
            this.muvelet = muvelet;
        }

        /*
        public FormDolgozo() //lehet több konstruktora az osztálynak, de erre itt most nincs szükség
        {
            InitializeComponent();
        }
        */

        private void FormDolgozo_Load(object sender, EventArgs e)
        {
            switch (muvelet) //ezzel a konstruktorból megkapja, hogy melyik gombbal léptünk át erre a fülre, és átnevezi a gombot
            {
                case "insert":
                    btMuvelet.Text = "Új dolgozó beillesztése"; //gomb neve lesz
                    this.Text = "Új dolgozó adatai"; //ablak neve lesz
                    break;

                case "update":
                    Dolgozo kivalasztottDolgozo = (Dolgozo)Program.formNyito.lbDolgozok.SelectedItem;
                    btMuvelet.Text = $"{kivalasztottDolgozo.Nev} dolgozó módosítása";
                    tbID.Text = kivalasztottDolgozo.Id.ToString();
                    tbNev.Text = kivalasztottDolgozo.Nev;
                    dateTimePickerSzuletett.Value = kivalasztottDolgozo.Szuletett;
                    numericUpDownFizetes.Value = kivalasztottDolgozo.Fizetes;
                    this.Text = $"{kivalasztottDolgozo.Nev} dolgozó módosítása";
                    break;

                case "delete":
                    kivalasztottDolgozo = (Dolgozo)Program.formNyito.lbDolgozok.SelectedItem;
                    btMuvelet.Text = $"{kivalasztottDolgozo.Nev} adatainak törlése";
                    tbID.Text = kivalasztottDolgozo.Id.ToString();
                    tbNev.Text = kivalasztottDolgozo.Nev;
                    dateTimePickerSzuletett.Value = kivalasztottDolgozo.Szuletett;
                    numericUpDownFizetes.Value = kivalasztottDolgozo.Fizetes;
                    this.Text = $"{kivalasztottDolgozo.Nev} adatainak törlése";

                    dolgozoTorles();
                    break;

                default:
                    break;
            }
        }

        private void btMuvelet_Click(object sender, EventArgs e)
        {
            switch (muvelet)
            {
                case "insert":
                    tbNev.Focus();
                    ujDolgozRogzites(); //dolgozó rögzítése gomb metódusa
                    break;

                case "update":
                    tbNev.Focus();
                    dolgozoModositas();
                    break;

                case "delete":
                    dolgozoTorles();
                    break;

                default:
                    break;
            }
        }

        private void dolgozoTorles()
        {
            if (mezokKitoltottek())
            {
                Dolgozo torles = new Dolgozo(ulong.Parse(tbID.Text), tbNev.Text, dateTimePickerSzuletett.Value, numericUpDownFizetes.Value);
                Program.adatbazis.deleteDolgozo(torles);
                MessageBox.Show("Sikeres törlés");
            }
            else
            {
                MessageBox.Show("Tölts ki minden mezőt!", "Hiba");
            }

            this.Close();
        }

        private void dolgozoModositas()
        {
            if (mezokKitoltottek()) //ha a mezők ki vannak töltve
            {
                Dolgozo modosit = new Dolgozo(ulong.Parse(tbID.Text), tbNev.Text, dateTimePickerSzuletett.Value, numericUpDownFizetes.Value);
                Program.adatbazis.updateDolgozo(modosit);
                MessageBox.Show("Sikeres módosítás");
            }
            else
            {
                MessageBox.Show("Tölts ki minden mezőt!", "Hiba");
            }

            this.Close();
        }

        private void ujDolgozRogzites()
        {
            if (mezokKitoltottek()) //ha a mezők ki vannak töltve
            {
                Dolgozo uj = new Dolgozo(0, tbNev.Text, dateTimePickerSzuletett.Value, numericUpDownFizetes.Value);
                Program.adatbazis.ujDolgozo(uj);
                MessageBox.Show("Sikeres felvétel");
            }
            else
            {
                MessageBox.Show("Tölts ki minden mezőt!", "Hiba");
            }

            this.Close(); //bezárja ezt a formot, és visszatérünk az előzőhöz
        }

        private bool mezokKitoltottek() //mezők kitöltésének ellenőrzése
        {
            if (string.IsNullOrEmpty(tbID.Text) && !muvelet.Equals("insert")) //a beillesztés gombnál kell vizsgálnunk, hogy a művelet beillesztés-e, mert hogy nem lehet szerkeszteni azt a mezőt
            {
                return false;
            }

            if (string.IsNullOrEmpty(tbNev.Text))//ha üres vagy null, akkor false-al térjen vissza, azaz nincs kitöltve
            {
                return false;
            }

            int kor = DateTime.Now.Year-dateTimePickerSzuletett.Value.Year; //életkor lekérdezése

            if (kor < 14 || kor > 100)
            {
                return false;
            }

            //fizetést nem vizsgáljuk, ingyér is dolgozhat
            return true;
        }
    }
}
