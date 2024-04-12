namespace Binary_Ones_Count;

public class Counter
{
    public static int CountOnes(int number)
    {
        int b;
        int count = 0;

        while (number != 0)
        {
            b = number % 2;
            count += b;
            number = (number - b) / 2;
        }

        return count;
    }
}
