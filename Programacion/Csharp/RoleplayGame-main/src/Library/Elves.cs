using System.Net.Http.Headers;
namespace Library
{
    public class Elves : Characters

    {
    private int arrow;

    public int GetArrow()
    {
        return this.arrow;
    }
    public void SetArrow(int value)
    {
        this.arrow = value;
    }
    }
}