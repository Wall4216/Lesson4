public abstract class Character
{
    protected float Health { get; set; }
    protected float Strength { get; set; }
    protected float Intelligence { get; set; }

    public abstract void Attack(Character target);
    public abstract void Move();
    public void DisplayHealth()
    {
        Console.WriteLine($"У персонажа осталось {Health} хп!");
    }

    public void ReceiveDamage(float damage)
    {
        this.Health -= damage; // Уменьшение здоровья
    }
}