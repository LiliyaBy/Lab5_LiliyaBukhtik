namespace Lab5_LiliyaBukhtik
{
    internal class Program
    {
        static void Main()
        {
            Phone ex1 = new Phone();
            Phone ex2 = new Phone();
            Phone ex3 = new Phone();
            Console.WriteLine(ex1.number);
            Console.WriteLine(ex2.model);
            Console.WriteLine(ex3.weight);
            
            ex1.ReceiveCall("Сat");
            ex2.ReceiveCall("Gog");
            ex3.ReceiveCall("SnoopDog");


            Console.WriteLine(ex1.GetNumber());
            Console.WriteLine(ex2.GetNumber());
            Console.WriteLine(ex3.GetNumber());

            ex1.ReceiveCall("Сat","+79776451321");
            ex2.ReceiveCall("Gog", "+375339764354");
            ex3.ReceiveCall("SnoopDog", "+12029861805");


            ex1.SendMessage("+1202990764", "+375357864523");


        }
    }
}