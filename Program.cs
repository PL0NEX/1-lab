using ConsoleApp1;

class Programm
{
    static void Main(string[] args)
    {
        List<Mammal> mammals = new List<Mammal>();
        List<Frog> frogs = new List<Frog>();
        mammals.Add(new Dog(68,40,"doberman",2));
        mammals.Add(new Dolphin(1.7, 104.5, 25));  
        mammals.Add(new UssuriTiger(120, 250, "Siberian Taiga", 500));
        mammals.Add(new Cat(5, 30, "British", "grey"));
        frogs.Add(new Frog(0.02, "yellow-black", true));
        Console.WriteLine("Mammals:");
        foreach (var mammal in mammals) 
        {
            mammal.MLInfo();
        }
        Console.WriteLine("Frog:");
        foreach (var frog in frogs)
        {
            Console.WriteLine($"Frog:Weight - {frog.Weight},Colour - {frog.Colour},IsPoisonous - {frog.IsPoisonous}");
        }
        //Frog frog = new Frog(0.02, "yellow-black", true);
        //Console.WriteLine($"Frog:Weight - {frog.Weight},Colour - {frog.Colour},IsPoisonous - {frog.IsPoisonous}");
    }
    
}
