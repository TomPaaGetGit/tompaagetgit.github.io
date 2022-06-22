using System;

namespace Abax_Oppgaven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RoadVehicle vehicle1 = new RoadVehicle("Grønn", "Lett kjøretøy", 200, "NF123456", 146);
            RoadVehicle vehicle2 = new RoadVehicle("Blå", "Lett kjøretøy", 195, "NF654321", 150);
            Plane plane = new Plane(30, 2, 10, "jetfly", "LN1234", 1000);
            Boat boat = new Boat(500, 30,"ABC123",100);


            vehicle1.PrintInfo();
            vehicle2.PrintInfo();
            vehicle1.CompareCars(vehicle2);
            plane.PrintInfo();
            plane.Run();
            vehicle1.Run();
            boat.PrintInfo();
        }
    }
}


//Oppgaven under er laget av Kjetil Lassen i Abax. Han bruker den som "opptaksprøve" når han ansetter nye utviklere, som en test på om man har forstått objektorientering.  
//
//Oppgaven kan forsåvidt løses uten objekter i det hele tatt, men poenget her er å skjønne hvilke klasser man er ute etter og modellere dette skikkelig - selv om det blir "å skyte spurv med kanoner" i forhold til det programmet faktisk gjør.
//
//Skriv et konsoll-program i C# som kan:
//Printe informasjon om en en bil 1 med reg. nr NF123456, 147kw effekt, maksfart 200km/t, grønn farge av typen lett kjøretøy. 
//Printe informasjon om en annen bil (bil 2) med reg.nr NF654321, 150kw effekt, maksfart 195km/t, blå farge og av typen lett kjøretøy
//Sammenlikne de to bilene over for å sjekke om de er det samme kjøretøyet
//Printe informasjon om et fly med kjennetegn LN1234, 1000kw effekt, 30m vingespenn, 2tonn lasteevne, 10 tonn egenvekt I flyklasse jetfly
//Konsollprogrammet skal be flyet om å fly og printe dette i konsollet.
//Konsollprogrammet skal be bil 1 om å kjøre og printe dette I konsollet
//Printe informasjon om en båt med kjennetegn ABC123, 100kw effekt, maksfart på 30knop, 500kg bruttotonnasje.