using System;

namespace ParreMedThomas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("YOOOO BRALL");
            Billa car1 = new Billa("rød", "Lett Kjøretøy", 200, "NF123456", 147);
            Billa car2 = new Billa("blå", "Lett Kjøretøy", 195, "NF654321", 150);
            Plane fly = new Plane(30, 10, 2, "LN1234", 1000);
            Boat båt = new Boat(500, 30, "ABC123", 100);

            car1.PrintInfo();
            car2.PrintInfo();
            car1.Run();
            car1.CompareCars(car2);
            fly.PrintInfo();
            fly.Run();
            båt.PrintInfo();

            //OBJEKTER
            //bil 1 regnr NF123456, effekt 147Kw, maksfart 200km/t, red farge, lett kjøretøy
            //bil 2 regnr NF654321, effekt 150Kw, maksfart 195km/t, blå farge, lett kjøretøy
            //båt regnr ABC123, effekt 100Kw, maksfart 30 knop, 500kg bruttotonnasje
            //fly regnr LN1234, effekt 100Kw, 30m vingespenn, 2 tonn lasteevne, 10 tonn egenvekt, jetfly

            //ting alle har til felles: regnr, effekt

            //FUNKSJONER
            //Printe infoen om alle kjøretøyene V
            //Sammenligne bil 1 og bil 2 V
            //be flyet om å fly, printe dette til konsollet V 
            //be bil 1 om å kjøre, printe dette til konsollet V
        }
    }
}
