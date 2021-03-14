using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LakoparkProjekt
{
    class HappyLiving
    {
        private List<Lakopark> lakoparkok = new List<Lakopark>();

        public List<Lakopark> Lakoparkok { get => lakoparkok; }

        public HappyLiving(string filenev)
        {
            try
            {
                using (StreamReader sr = new StreamReader(filenev))
                {
                    while(!sr.EndOfStream)
                    {
                        string nev = sr.ReadLine();
                        string[] meret = sr.ReadLine().Split(';');
                        int[,] hazak = new int[Int32.Parse(meret[0]), Int32.Parse(meret[1])];
                        string sor = sr.ReadLine();
                        while(sor != "")
                        {
                            string[] adatok = sor.Split(';');
                            int i = int.Parse(adatok[0]) -1;
                            int j = int.Parse(adatok[1]) -1;
                            int tipus = int.Parse(adatok[2]);
                            Console.WriteLine(i+"-"+j+"-"+tipus);
                            hazak[i, j] = tipus;
                            sor = sr.ReadLine();
                        }
                        Lakopark lp = new Lakopark(hazak, hazak.GetLength(1), nev, hazak.GetLength(0));
                        lakoparkok.Add(lp);
                    }
                }
            }
            catch(FileNotFoundException)
            {
                
            }
            
        }
    }
}
