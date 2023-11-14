using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Balkezesek
    {
        public string nev;
        public DateTime elso;
        public DateTime utolso;
        public double suly;
        public double magassag;
    

    public Balkezesek(string sor)
    {
        string[] tordeltSor = sor.Split(";");
        string[] elsoTordeltDatum = tordeltSor[1].Split("-");
        string[] utolsoTordeltDatum = tordeltSor[2].Split("-");

        nev = tordeltSor[0];
        elso = new DateTime(Convert.ToInt32(elsoTordeltDatum[0]), Convert.ToInt32(elsoTordeltDatum[1]), Convert.ToInt32(elsoTordeltDatum[2]));
        utolso = new DateTime(Convert.ToInt32(utolsoTordeltDatum[0]), Convert.ToInt32(utolsoTordeltDatum[1]), Convert.ToInt32(utolsoTordeltDatum[2]));
        suly = Convert.ToDouble(tordeltSor[3]);
        magassag = Convert.ToDouble(tordeltSor[4]);
    }
}

}