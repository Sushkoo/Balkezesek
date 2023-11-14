using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ConsoleApp8;

class Program
{
    static void Main(string[] args)
    {


   
    string[] sorok = File.ReadAllLines("C:\\Users\\szilagyi.dominik\\source\\repos\\ConsoleApp8\\ConsoleApp8\\bin\\Debug\\net6.0\\balkezesek.csv");

    List<Balkezesek> jatekosok = new List<Balkezesek>();

    for(int i = 1; i<sorok.Length; i++)
        {
            Balkezesek Balkezesek = new Balkezesek(sorok[i]);
            jatekosok.Add(Balkezesek);
        }

        Console.WriteLine("3. feladat:");
        jatekosok.Count();

        Console.WriteLine("4. feladat:");

    }
}