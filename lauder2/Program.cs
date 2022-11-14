using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace masodik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //egysoros komment

            /*
             * többsoros komment
             */

            /*
            2. Írj egy programot, amely bekér két pozitív egész számot a felhasználótól
            és kiírja a képernyőre azokat a páros számokat, amelyek a két adott érték közötti zárt
            intervallumban találhatóak!
            */

            /*  változók típusai:
             *  int             - egész szám
             *      int váltnév = 0;
             *      int váltnév = int.Parse(Console.ReadLine());
             *      
             *  double, float   - tört szám
             *      double váltnév = double.Parse(Console.ReadLine());
             *      
             *  string          - szöveg
             *      string váltnév = "szöveg";
             *      string váltnév = Console.ReadLine();
             *      
             *  char            - karakter
             *  
             *  
             *  Console.ReadLine()  -- SZÖVEG!!!!    
             *  int.Parse("szöveg")         -- INT-É KONVERTÁLJA A SZÖVEGET!!!
             *  Console.Write("szöveg...\n") = Condole.WriteLine("szöveg...")
             *  ; MINDEN sor végén!!!!
             *  
             */

            Console.Write("Adjon meg egy számot: ");
            int elsoszam = int.Parse(Console.ReadLine()); //egész szám
            //string elsoszams = Console.ReadLine();
            Console.Write("Adjon meg még egy számot: ");
            int masodikszam = int.Parse(Console.ReadLine()); //egész szám
            //string masodikszams = Console.ReadLine();

            //Console.WriteLine(elsoszam + masodikszam);
            //     (mettől; meddig; lépésenként)
            //          2               10          +1
            for(int i = elsoszam; i < masodikszam+1; i++)//for végén NINCS ; !!!
            {
                if(i % 2 == 0)//if végén NINCS ; !!!
                {
                    Console.Write(i + " ");
                }
            }


            //osztások
            // int / int = int
            Console.WriteLine("\nKét szám hányadosa: " + (masodikszam / elsoszam));
            // float / int = float
            Console.Write("Adjon meg egy tört számot: ");//, használható!!
            float fszam = float.Parse(Console.ReadLine()); // tört szám
            Console.WriteLine("\nKét szám hányadosa: " + (masodikszam / fszam));

            //szorzás
            Console.WriteLine(elsoszam*masodikszam);    //egész számok szorzása
            Console.WriteLine(elsoszam*fszam);          //egész szám szorozva tört számmal



            Console.ReadKey();//vár az első billenytű leütéséig!!
        }
    }
}
