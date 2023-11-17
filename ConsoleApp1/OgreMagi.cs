public class OgreMagi : Character, ICharacter
{
    public OgreMagi()
    {
        Health = 100.0f;
        Strength = 12.0f;
        Intelligence = 20.0f;
    }

    public override void Attack(Character target)
    {
        if (target != null)
        {
            float damage = Intelligence * 1.5f;
            target.ReceiveDamage(damage);
            Console.WriteLine($"Ogre Magi атакует, нанося {damage} урона.");
        }
    }

    public override void Move()
    {
        Console.WriteLine("Ogre Magi медленно передвигается.");
    }

    public void Fireblast(Character target)
    {
        if (target != null)
        {
            float damage = Intelligence * 2.0f;
            target.ReceiveDamage(damage);
            Console.WriteLine($"Ogre Magi использует Fireblast, нанося {damage} урона и оглушая цель.");
        }
    }
}
