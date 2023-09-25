using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Takacs_Laszlo_dolgozat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Kérj be a felhasználótól egy N valós számot.
            Console.WriteLine("Adj meg egy valós számot:");
            int szam = Convert.ToInt32(Console.ReadLine());

            //2. Hozz létre egy N elemű valós számú tömböt.
            int[] szamok = new int[szam];

            //3. A tömböt töltsd fel random számokkal (0 és 100 között legyen).
            int i = 0;
            Random veletlenSzam = new Random();
            while (i < szamok.Length)
            {
                szamok[i] = veletlenSzam.Next(0, 101);
                i++;
            }
            //Számok kiíratása magamnak:
            Console.WriteLine("Tömbben szereplő számok: ");
            int j = 0;
            while (j < szamok.Length)
            {
                Console.Write(szamok[j] + " ");
                j++;
            }

            //4. Vizsgáld meg a tömb elemeit és írd ki az alábbi adatokat:
            int[] parosSzamok = new int[szam];
            int parosSzamokDb = 0;
            int[] paratlanSzamok = new int[szam];
            int paratlanSzamokDb = 0;
            int[] primSzamok = new int[szam];
            int primSzamokDb = 0;
            double atlag = 0;
            int legkisebbSzam = szamok[0];
            int legnagyobbSzam = szamok[0];

            //Páros, páratlan vizsgálat:
            for (int k = 0; k < szamok.Length; k++)
            {
                if (szamok[k] % 2 == 0)
                {
                    parosSzamok[k] = szamok[k];
                    parosSzamokDb++;
                } else {
                    paratlanSzamok[k] = szamok[k];
                    paratlanSzamokDb++;
                }

            }


            //kiiratás:
            Console.WriteLine($"\n4/a Feladat: {parosSzamokDb} db páros szám van, melyek:");
            foreach (int paros in parosSzamok)
            {
                if (paros != 0)
                {
                    Console.Write(paros + " ");
                }
            }

            Console.WriteLine($"\n4/b Feladat: {paratlanSzamokDb} db páratlan szám van, melyek:");
            foreach (int paratlan in paratlanSzamok)
            {
                if (paratlan != 0)
                {
                    Console.Write(paratlan + " ");
                }
            }

            //Prím számok kiíratása + darabszám
            Console.WriteLine($"\n4/c Feladat: Prím számok:");
            for (int k = 0; k < szamok.Length; k++) 
            {
                if (primSzam(szamok[k]))
                {
                    primSzamokDb++;
                    Console.Write(szamok[k] + " ");
                }
            }
            Console.WriteLine($"\n{primSzamokDb} db prím szám van a tömbben!");

            //Tömb átlaga:
            double osszeg = 0;
            for (int k = 0; k < szamok.Length; k++)
            {
                osszeg += szamok[k];
                atlag = osszeg / szamok.Length;
            }
            Console.WriteLine("4/d Feladat: A tömb átlaga: " + atlag);

            //Legkisebb, legnagyobb szám vizsgálata: 
            for (int k = 0; k < szamok.Length; k++)
            {
                if (legkisebbSzam > szamok[k])
                {
                    legkisebbSzam = szamok[k];
                }

                if (legnagyobbSzam < szamok[k] )
                {
                    legnagyobbSzam = szamok[k];
                }
            }
            Console.WriteLine("4/e Feladat: Legkisebb: " + legkisebbSzam);
            Console.WriteLine("4/f Feladat: Legnagyobb: " + legnagyobbSzam);

            //5. Feladat: 
            Console.WriteLine("Adj meg 5 szót: ");
            string[] szavak = new string[5];
           
            for (int k = 0;  k < szavak.Length; k++)
            {
                Console.WriteLine($"Add meg a(z) {k+1}. szót:");
                szavak[k] = Console.ReadLine();
            }

            string legrovidebbSzo = szavak[0];
            string leghosszabbSzo = szavak[0];
            string elsoSzo = szavak[0];

            for (int k = 0;k < szavak.Length; k++)
            {
                if (legrovidebbSzo.Length > szavak[k].Length)
                {
                    legrovidebbSzo = szavak[k];
                }

                if (leghosszabbSzo.Length < szavak[k].Length)
                {
                    leghosszabbSzo = szavak[k];
                }


                if (elsoSzo.Equals(szavak[k]))
                {
                    Console.WriteLine($"{elsoSzo} kétszer szerepel!");
                }
            }
            Console.WriteLine("5. Feladat:");
            Console.WriteLine($"Legrövidebb szó: {legrovidebbSzo}");
            Console.WriteLine($"Leghosszabb szó: {leghosszabbSzo}");

            //1. Feladat: 


            //2. Feladat:
            int bekertSzam;
            while (true)
            {
                Console.WriteLine("Adjon meg egy páros számot: ");
                bekertSzam = Convert.ToInt32(Console.ReadLine());

                if (bekertSzam % 2 == 0)
                {
                    Console.WriteLine("A szám páros, megfelelő!");
                    break;
                }
            }


            //3. Feladat: 
            int bekertSzam2;
            while (true)
            {
                Console.WriteLine("Kérek egy pozitív számot: ");
                bekertSzam2 = int.Parse(Console.ReadLine());
                if (bekertSzam2 > 0)
                {
                    int maradek = bekertSzam2 / 5;
                    Console.WriteLine($"A szám megfelelő, 5-tel való osztás maradéka: {maradek}");
                    break;
                }

            }

            //4. Feladat: 

            double szam1, szam2;

            Console.WriteLine("Kérem adja meg az első számot: ");
            szam1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Kérem adja meg az második számot: ");
            szam2 = double.Parse(Console.ReadLine());

            while (szam1 != szam2)
            {
                if (szam1 > szam2)
                {
                    Console.WriteLine($"{szam1} nagyobb, mint {szam2}");
                }
                else
                {
                    Console.WriteLine($"{szam2} nagyobb, mint {szam1}");
                }

                Console.WriteLine("Kérem adja meg az első számot: ");
                szam1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Kérem adja meg az második számot: ");
                szam2 = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("A két szám egyenlő!");
        }

        static bool primSzam(int prim)
        {
            for (int i = 2; i * i <= prim; i++)
            {
                if (prim % 2 == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
