public class Axe : Character, ICharacter
{
    public float Armor { get; private set; }

    public Axe()
    {
        Armor = 15.0f;
        Health = 120.0f;
        Strength = 20.0f;
        Intelligence = 5.0f;
    }

    public override void Attack(Character target)
    {
        if (target != null)
        {
            float damage = Strength * 1.5f;
            target.ReceiveDamage(damage);
            Console.WriteLine($"Axe атакует, нанося {damage} урона.");
        }
    }

    public override void Move()
    {
        Console.WriteLine("Axe двигается к бою!");
    }

    public void BerserkersCall()
    {
        Armor += 5;
        Console.WriteLine("Axe использует Berserker's Call, увеличивая свою броню!");
    }
}
