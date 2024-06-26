using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;


public class Solution
{
    static void Main(string[] args)
    {
        Console.WriteLine("Escreva o valor: ");
        var x = Convert.ToInt32(Console.ReadLine()) ;
        Console.WriteLine(IsPolindrome(x));

    }

    public static bool IsPolindrome(int x )
    {
        
        var y = x.ToString().ToCharArray();
        Array.Reverse(y);
        var ReverString = new string(y);
        return x.ToString() == ReverString;
    }
}