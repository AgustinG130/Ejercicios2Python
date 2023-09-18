using System.Net.Http.Headers;
namespace Library
{
    public class Dwarves : Characters
    
    {
    private int armor;

    public int GetArmor()
    {
        return this.armor;
    }
    public void SetArmor(int value)
    {
        this.armor = value;
    }
    
    }
}