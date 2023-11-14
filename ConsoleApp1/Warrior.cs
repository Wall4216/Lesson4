﻿public class Warrior : Character, ICharacter
{
    public float Armor { get; private set; }
    public float Energy { get; private set; }

    public Warrior()
    {
        Armor = 10.0f;
        Energy = 100.0f;
        Health = 100.0f; 
        Strength = 15.0f;
    }

    public void BattleCry()
    {
        if (Energy >= 20)
        {
            Strength += 5; 
            Energy -= 20;
            Console.WriteLine("Герой использовал боевой клич! Сила увеличена!");
        }
        else
        {
            Console.WriteLine("Недостаточно энергии для боевого клича!");
        }
    }

    public override void Attack(Character target)
    {
        if (target != null)
        {
            float damage = this.Strength * (this.Energy / 100);
            target.ReceiveDamage(damage); 
            Console.WriteLine($"Воин атакует с увеличенным уроном благодаря боевому кличу! Нанесено {damage} урона.");
            target.DisplayHealth();
        }
    }

    public void Heal()
    {
        this.Health += 10; 
        Console.WriteLine("Воин исцелился!");
    }

    public override void Move()
    {
        Console.WriteLine("Воин движется!\r\n");
    }

    public void Defend()
    {
        Armor += 5; 
        Console.WriteLine("Воин защищается, увеличивая свою броню!");
    }

    public void EnergyRegeneration()
    {
        Energy += 5; 
        Console.WriteLine("Энергия воина восстанавливается!");
    }
}
