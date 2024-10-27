using game1401_la_starter;


Console.WriteLine("The battle between Dragon and Venusaur is gonna start\n");
Console.WriteLine("Their types are mentioned below:\n");

Console.WriteLine($"Dragon: Fire.\n");
Console.WriteLine($"Venusaur: Grass.\n");
Dragon dragon = new Dragon();
dragon.Attack();

Venusaur venusaur = new Venusaur();
venusaur.Attack();

return 0;