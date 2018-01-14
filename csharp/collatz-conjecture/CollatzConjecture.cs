using System;

public static class CollatzConjecture
{
    public static int Steps(int number)
    {
        int count = 0;

        if (number <= 0)
        {
            throw new ArgumentException();
        }

        while (number != 1)
        {
            number = (number % 2 == 0) ? number / 2 : 3 * number + 1;
            count++;
        }

        return count;
    }
}