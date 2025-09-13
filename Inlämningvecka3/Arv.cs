namespace Inlämningvecka3
{
    //Skapar en klass där hela kodblocket för klassen Car ska vara
    //Dessutom vill jag lägga till attributer med en metod som jag kommer därefter anropa. 
    //Tänker att man kan definera klass som attributer och metoder också
    public class Vehicle
    {
        public string Brand;
        public string Color;

        public void StartEngine()
        {
            Console.WriteLine("The engine is starting now!");
        }
        public void StopEngine()
        {
            Console.WriteLine("The engine is stopping now!");
        }
        //Sen vill jag skapa subklasser som kommer ärva från huvudklassen Car
    }

        public class Motorcycle : Vehicle
        {
            public string Model;

            public new void StopEngine()
            {
                Console.WriteLine("The motorcycles model is Kawasaki!");
            }
        }
        //Jag skapar nya attributer men jag vill också ärva attributer från huvudklassen Car
   }

