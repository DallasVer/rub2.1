namespace Prac;

public class Program
{
    public static void Main(string[] args)
    {
        string? J = Console.ReadLine();
        string? S = Console.ReadLine();
        int A = 0;

        int x = 0;
        for (int i = 0; i < J.Length; i++)
        {
            for (int j = 0; j < S.Length; j++)
            {
                if(J[i]==S[j])
                {
                    A++;
                    x++;
                }
            }
        }
        Console.WriteLine(A);      
    }
}