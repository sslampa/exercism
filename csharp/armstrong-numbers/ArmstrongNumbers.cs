using System;
using System.Linq;

public static class ArmstrongNumbers
{
    public static bool IsArmstrongNumber(int number)
    {
        string n = number.ToString();
        int length = n.Length;
        int total = (int)n.Sum(x => Math.Pow(int.Parse(x.ToString()), length));

        return total == number;
    }
}