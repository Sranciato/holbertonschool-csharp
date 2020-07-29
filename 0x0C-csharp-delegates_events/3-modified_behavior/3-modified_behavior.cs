using System;


///<summary>Modifier enum</summary>
public enum Modifier
{
    ///<summary>Weak Modifier</summary>
    Weak,
    ///<summary>Base Modifier</summary>
    Base,
    ///<summary>Strong Modifier</summary>
    Strong
}

///<summary>Calculate modifier delegate</summary>
public delegate float CalculateModifier(float baseValue, Modifier modifier);

///<summary>Player class</summary>
public class Player
{
    private string name;
    private float maxHp;
    private float hp;
    ///<summary>delegate to calculate health</summary>
    public delegate void CalculateHealth(float amount);

    ///<summary>Constructor</summary>
    public Player(string name = "Player", float maxHp = 100f)
    {
        this.name = name;
        if (maxHp <= 0)
        {
            this.maxHp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        else
        {
            this.maxHp = maxHp;
        }
        this.hp = this.maxHp;
    }

    ///<summary>Print health of player method</summary>
    public void PrintHealth()
    {
        Console.WriteLine(this.name + " has " + this.hp + " / " + this.maxHp + " health");
    }

    ///<summary>Take damage method</summary>
    public void TakeDamage(float damage)
    {
        if (damage < 0)
            Console.WriteLine(this.name + " takes 0 damage!");
        else
            Console.WriteLine(this.name + " takes " + damage + " damage!");
        this.ValidateHP(this.hp - damage);
    }

    ///<summary>heal damage method</summary>
    public void HealDamage(float heal)
    {
        if (heal < 0)
            Console.WriteLine(this.name + " heals 0 HP!");
        else
            Console.WriteLine(this.name + " heals " + heal + " HP!");
        this.ValidateHP(this.hp + heal);
    }

    ///<summary>Validate hp method</summary>
    public void ValidateHP(float newHp)
    {
        if (newHp < 0)
            this.hp = 0;
        else if (newHp > this.maxHp)
            this.hp = this.maxHp;
        else
            this.hp = newHp;
    }

    ///<summary>Modifier enum</summary>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        if (modifier == Modifier.Weak)
            return baseValue / 2;
        else if (modifier == Modifier.Base)
            return baseValue;
        else if (modifier == Modifier.Strong)
            return baseValue * 1.5f;
        return baseValue;
    }
}