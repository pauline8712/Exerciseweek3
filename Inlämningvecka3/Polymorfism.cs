namespace Inlämningvecka3
{
    //Polymorfism är när en metod kan ha olika beteenden beroende på vilken klass som anropar den.
    //Huvudklassen. Polymorfism är i grunden arv men vill ha samma metoder, med samma namn men med olika implementationer - funktioner.
    //Deklarera - att tala om för datorn att något finns
    public class Shape
    {
        public string Color;
        public string Name;

        public virtual void Draw()
        {             
          Console.WriteLine("Drawing a shape");
        }
        //subklasser som ärver från huvudklassen Shape

        public class Triangle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Drawing a triangle");
            }

        }
        public class Circle : Shape
        {
         public override void Draw()
            {
                Console.WriteLine("Drawing a circle");
            }
        }
    }
}
