namespace Binary_Ones_Count;

public class Counter
{
    public static void CountOnes(int number)
    {
        int a = number;
        int b;
        int count = 0;

        while (a != 0)
        {
            b = a % 2;
            count += b;
            a = (a - b) / 2;
        }

        Console.WriteLine($"{number} -> {count}");
    }
}
