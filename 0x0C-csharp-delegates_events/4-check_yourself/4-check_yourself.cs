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

///<summary>CurrentHPargs class</summary>
public class CurrentHPArgs : EventArgs
{
    ///<summary>Not modifable current hp float</summary>
    public readonly float currentHp;

    ///<summary>CurrentHPargs constructor</summary>
    public CurrentHPArgs(float newHp)
    {
        this.currentHp = newHp;
    }
}

///<summary>Calculate modifier delegate</summary>
public delegate float CalculateModifier(float baseValue, Modifier modifier);

///<summary>Player class</summary>
public class Player
{
    
    private string name;
    private float maxHp;
    private float hp;
    private string status;
    ///<summary>delegate to calculate health</summary>
    public delegate void CalculateHealth(float amount);
    ///<summary>Hpcheck event handler</summary>
    public EventHandler<CurrentHPArgs> HPCheck;

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
        this.status = this.name + " is ready to go!";
        this.HPCheck = this.CheckStatus;
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
        this.HPCheck(this, new CurrentHPArgs(this.hp));
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

    ///<summary>CheckStatus method</summary>
    private void CheckStatus(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == this.maxHp)
            this.status = this.name + " is in perfect health!";
        else if (e.currentHp >= this.maxHp / 2 && e.currentHp < this.maxHp)
            this.status = this.name + " is doing well!";
        else if (e.currentHp >= this.maxHp / 4 && e.currentHp < this.maxHp / 2)
            this.status = this.name + " isn't doing too great...";
        else if (e.currentHp > 0 && e.currentHp < this.maxHp / 2)
            this.status = this.name + " needs help!";
        else if (e.currentHp == 0)
            this.status = this.name + " is knocked out!";
        Console.WriteLine(this.status);
    }

    
}