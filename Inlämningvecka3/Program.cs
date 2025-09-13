using static Inlämningvecka3.Shape;

namespace Inlämningvecka3
{
    internal class Program
    {
        static void Main(string[] args)
        
        {
            //Arv
            Vehicle vehicle1 = new Vehicle();
            vehicle1.StopEngine();

            //Polymorfism

            Motorcycle motorcycle1 = new Motorcycle();
            motorcycle1.StopEngine();
            
            //Inkaspling

            Shape shape1 = new Shape();
            shape1.Draw();

            Circle circle1 = new Circle();
            circle1.Draw();

              
            Triangle triangle1 = new Triangle();
            triangle1.Draw();

            //Abstraktion

             CreditCard creditcard1 = new CreditCard();
             creditcard1.Pay();

             PayPal payPal1 = new PayPal();
             payPal1.Pay();



            
        }

    }
}