class Program
{
    static void Main(string[] args)
    {
        Warrior warrior1 = new Warrior();
        Warrior warrior2 = new Warrior();

        Console.WriteLine("Начало боя между воинами!\r\n");

        warrior1.BattleCry(); 
        warrior1.Attack(warrior2); 

        warrior2.Defend(); 
        warrior2.Heal(); 
        warrior2.Attack(warrior1);

        warrior1.EnergyRegeneration();
        warrior1.Move(); 
    }
}
