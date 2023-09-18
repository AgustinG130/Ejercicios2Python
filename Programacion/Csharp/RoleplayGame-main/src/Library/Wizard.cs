using System.Net.Http.Headers;
namespace Library
{
    public class Wizard : Characters
    
    {
    private int magic;

    public int GetMagic()
    {
        return this.magic;
    }
    public void SetMagic(int value)
    {
        this.magic = value;
    }
    }
}