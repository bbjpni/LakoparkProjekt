using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LakoparkProjekt
{
    class Lakopark
    {
        private int[,] hazak;
        private int maxHazszam;
        private string nev;
        private int UtcaSzam;

        public int[,] Hazak { get => hazak; }
        public int MaxHazszam { get => maxHazszam; }
        public string Nev { get => nev; }
        public int UtcaSzam1 { get => UtcaSzam; }

        public Lakopark(int[,] hazak, int maxHazszam, string nev, int utcaSzam)
        {
            this.hazak = hazak;
            this.maxHazszam = maxHazszam;
            this.nev = nev;
            this.UtcaSzam = utcaSzam;
        }
    }
}
