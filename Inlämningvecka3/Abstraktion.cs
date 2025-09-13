namespace Inlämningvecka3
{
//Abstraktion en klass som kan inte göra objekt/instanser av. Och som bara används för att implementera olika metoder i nutid. Subklasser
//Huvudklass abstrakt
public abstract class PaymentMethod
    {
        public abstract void Pay();
    }
    //subklass - alla underliggande som ärver ifrån PaymentMethod. Måste ha Pay metoden, med sin egen implementering.
    //Med detta har vi deklarerat en abstrakt. Det går inte att skapa objekt av Payment.
    public class CreditCard : PaymentMethod
    {
        public override void Pay()
        //Man måste skriva över metoden i nutida subklasser.
        {
            Console.WriteLine("Paying with credit card");
        }
    }

        public class PayPal : PaymentMethod
        {
            public override void Pay()
            {
                Console.WriteLine("Paying with PayPal");
            }
        }
    }

