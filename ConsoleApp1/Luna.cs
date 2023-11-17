public class Luna : Character, ICharacter
{
    public Luna()
    {
        Health = 90.0f;
        Strength = 18.0f;
        Intelligence = 15.0f;
    }

    public override void Attack(Character target)
    {
        if (target != null)
        {
            float damage = Strength * 1.2f;
            target.ReceiveDamage(damage);
            Console.WriteLine($"Luna атакует, нанося {damage} урона.");
        }
    }

    public override void Move()
    {
        Console.WriteLine("Luna быстро передвигается!");
    }

    public void LunarBlessing()
    {
        Strength += 5;
        Console.WriteLine("Luna использует Lunar Blessing, увеличивая свой урон!");
    }
}
