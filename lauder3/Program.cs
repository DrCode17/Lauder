
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lauder3
{
    internal class Program
    {
        //4. Írj egy szöveg értékkel visszatérő függvényt, amely paraméterként
        //kap egy egész számot és eldönti a számról, hogy osztható-e 2-vel és 3-mal is
        //egyszerre! Ha nem, akkor írja ki, mivel osztható!
        //A programodban hívd is meg ezt az alprogramot!
        public static string Oszthatosag(int szam)
        {
            if(szam % 6 == 0)
            {
                return "Osztható 2-vel és 3-al is.";
            }
            if(szam % 2 == 0)
            {
                return "Osztható 2-vel.";
            }
            if (szam % 3 == 0)
            {
                return "Osztható 3-al.";
            }

            return "Hiba! Nem osztható sem 2-vel, sem 3-al.";
        }


        static void Main(string[] args)
        {
            //3. Írj egy programot, amely bekér egy pozitív egész számot a felhasználótól és
            //kiírja a képernyőre azt a számot, amely az ennél a számnál nem nagyobb pozitív
            //egész számokösszege!
            //inp:3 -> outp:1+2+3
            //inp:5 -> outp:1+2+3+4+5
            Console.Write("Adjon meg egy 0-nál nagyobb egész számot: ");
            int kapott = int.Parse(Console.ReadLine());
            int sum = 0; 
            for(int i = kapott; i > 0; i--) 
            {
                sum += i;
            }
            Console.WriteLine("A számok összege: " + sum.ToString());

            //1. Írj egy programot, amely bekér egy dolgozat százalékát (x) a felhasználótól
            //és kiír egy érdemjegyet az alábbiak szerint!
            //1: x < 50; 2: 50 <= x < 60; 3: 60 <= x < 70; 4: 70 <= x < 85; 5: x >= 85

            Console.Write("Add meg hány százalékos dolgozatot írtál: ");
            int szazalek = int.Parse(Console.ReadLine());
            int jegy = 0;
            if(szazalek < 50)
            {
                jegy = 1;
            }else if(szazalek < 60)
            {
                jegy = 2;
            }else if(szazalek < 70)
            {
                jegy = 3;
            }else if(szazalek < 85)
            {
                jegy = 4;
            }
            else if(szazalek < 101)
            {
                jegy = 5;
            }
            else
            {
                Console.WriteLine("Nem 0 és 100 közötti értéket adtál meg!");
            }
            Console.WriteLine("A dolgozatod jegye: " + jegy.ToString());

            //4. Írj egy logikai értékkel visszatérő függvényt, amely paraméterként
            //kap egy egész számot és eldönti a számról, hogy osztható-e 2-vel és 3-mal is
            //egyszerre! Ha nem, akkor írja ki, mivel osztható!
            //A programodban hívd is meg ezt az alprogramot!

            Console.WriteLine("Adjon meg egy számot: ");
            kapott = int.Parse(Console.ReadLine());


            Console.WriteLine(Oszthatosag(kapott));




            Console.ReadKey();//billentyűzet leütésig vár
        }
    }
}
