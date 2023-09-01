
//console.WriteLine("lol");
public class Program 
{
    public static string TextToNumberBinary(string str) 
    {
        string result = "";
        string[] words = str.ToLower().Split(" "); //en teoria hace un split
        
        foreach (string word in words)
        {
            if (word == "zero") 
            {
                result = result + "0";
            }
            else if (word == "one")
            {
                result = result + "1";
            }
        }
        
        int length = result.Length;
        result = result.Substring(length / 8 * 8); // no anda
        
        return result; // retornar si es que se pide

        

    }
}