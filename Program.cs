namespace myZoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bulldog hund1 = new Bulldog("Hund","Svart/Vit",6,12,"Bulldog");
            Rottweiler hund2 = new Rottweiler("Hund", "Svart", 4, 13, "Rottweiler", false,true,true);

            Bengal katt1 = new Bengal("Katt", "Leopard färgad", 4, 15, "Bengal");
            Lion katt2 = new Lion("Katt", "Gul", 3, 12, "Lejon", false, true, true);

            Salmon fisk1 = new Salmon("Fisk", "Blanka fjäll", 1, 2, "Lax");
            Dolphin fisk2 = new Dolphin("Fisk", "Grå", 3, 8, "Delfin", true, true,true);

            
            Console.WriteLine("Djurens olika läten:");
            hund1.MakeSound();
            hund2.MakeSound();
            katt1.MakeSound();
            katt2.MakeSound();
            fisk1.MakeSound();
            fisk2.MakeSound();
            Console.WriteLine();

            Console.WriteLine("Alla djur måste ju äta också!");
            hund1.Eating("torrforder");
            hund2.Eating("köttfärs");
            katt1.Eating("whiskas");
            katt2.Eating("kadaver");
            fisk1.Eating("alger");
            fisk2.Eating("tång");
            Console.WriteLine();

            Console.WriteLine("Lite andra små saker dem har för sig:");
            fisk1.Swim(true);
            fisk1.Swim(false);
            Console.WriteLine();
            fisk2.Jump(true);
            fisk2.Jump();
            Console.WriteLine();
            katt1.PurrsOrRoars();
            katt1.BengalFunInfo();
            Console.WriteLine();
            katt2.PurrsOrRoars();
            katt2.SneakingOnPray();
            Console.WriteLine();
            hund1.BulldogSnoor();
            hund1.JumpingOfHappines();
            Console.WriteLine();
            hund2.Drool();
            hund2.JumpingOfHappines();
            Console.WriteLine();
            Console.WriteLine("Efter en sån aktiv dag så lägger sig djuren till sist.");
            katt1.Sleeps();
            katt2.Sleeps();
            hund1.Sleeps();
            hund2.Sleeps();
            fisk1.Sleeps();
            fisk2.Sleeps();

            //Det slog mig såhär i efterhand att ni kanske ville ha default värden på alla egenskaper man 
            //använder sig utav? Isf får ni gärna säga till innan ni ger mig ett IG så får jag fixa om 
            //min uppgift bara. Jag satte inte in default på sånt jag ville ha krav på att man måste 
            //fylla i när man skapar ett djur    ´\(-.-)/` 
        }
    }
}