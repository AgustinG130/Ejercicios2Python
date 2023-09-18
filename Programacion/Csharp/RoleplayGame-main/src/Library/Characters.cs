using System.Net.Http.Headers;
namespace Library 
{

    public class Characters
    {
    private string name;
    private int attack;
    private int defence;
    private int health;
    private string item;

    public string GetName()
    {
        return this.name;
    }
    public void SetName(string value)
    {
        this.name = value;
    }
    public int GetAttack()
    {
        return this.attack;
    }
    public void SetAttack(int value)
    {
        this.attack = value;
    }
    
    public int GetDefence()
    {
        return this.defence;
    }
    public void SetDefence(int value)
    {
        this.defence = value;
    }
    public int GetHealth()
    {
        return this.health;
    }
    public void SetHealth(int value)
    {
        this.health = value;
    }
    public string GetItem()
    {
        return this.item;
    }
    public void SetItem(string value)
    {
        this.item = value;
    }
    }  
} 