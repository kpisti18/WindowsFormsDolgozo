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
    public partial class FormNyito : Form
    {
        public FormNyito()
        {
            InitializeComponent();
        }

        private void FormNyito_Load(object sender, EventArgs e)
        {
            lbUpdate();
        }

        void lbUpdate()
        {
            lbDolgozok.Items.Clear(); //kiürítjük a listboxot üresre

            foreach (Dolgozo item in Program.adatbazis.osszesDolgozo())
            {
                lbDolgozok.Items.Add(item); // hozzáadjuk a listboxhoz az adatokat
            }
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            FormDolgozo formDolgozo = new FormDolgozo("insert");
            formDolgozo.ShowDialog();
            lbUpdate();
        }

        private void btFrissit_Click(object sender, EventArgs e) // újra meghívja az lbUpdate() metódust
        {
            lbUpdate();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (lbDolgozok.SelectedIndex < 0) //ekkor nincs kiválasztott elem, mert itt kell már kiválasztani a listából dolgozót
            {
                MessageBox.Show("Nincs kiválasztott!");
                return;
            }
            
            FormDolgozo formDolgozo = new FormDolgozo("update");
            formDolgozo.ShowDialog(); // ezzel megjelenítjük az ablakot
            lbUpdate();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (lbDolgozok.SelectedIndex < 0)
            {
                MessageBox.Show("Nincs kiválasztott!");
                return;
            }

            FormDolgozo formDolgozo = new FormDolgozo("delete");
            formDolgozo.ShowDialog();
            lbUpdate();
        }
    }
}
