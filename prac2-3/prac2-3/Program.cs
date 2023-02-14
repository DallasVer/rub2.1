namespace prac2_3;

public class Program
{
    public static void Main(string[] args)
    {
        int[] nums = { 1, 4, 5, 1, 6, 3 };
        bool ot = false;
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[i] == nums[j])
                {
                    ot = true;
                    break;
                }
            }
        }
        Console.WriteLine(ot);
    }
}