using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsDolgozo
{
    internal class Dolgozo
    {
        readonly ulong id; //unsigned long
        string nev;
        DateTime szuletett;
        decimal fizetes;

        public ulong Id => id;
        public string Nev { get => nev; set => nev = value; }
        public DateTime Szuletett { get => szuletett; set => szuletett = value; }
        public decimal Fizetes { get => fizetes; set => fizetes = value; }

        public Dolgozo(ulong id, string nev, DateTime szuletett, decimal fizetes)
        {
            this.id = id;
            this.nev = nev;
            this.szuletett = szuletett;
            this.fizetes = fizetes;
        }

        public override string ToString() //a listbox-ba csak a neveket akarjuk megjeleníteni
        {
            return nev;
        }
    }
}
