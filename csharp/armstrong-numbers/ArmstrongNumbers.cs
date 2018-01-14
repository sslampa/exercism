using System;

public static class ArmstrongNumbers
{
    public static bool IsArmstrongNumber(int number)
    {
        string n = number.ToString();
        double length = Convert.ToDouble(n.Length);
        int total = 0;

        foreach (char c in n)
        {
            double value = Convert.ToDouble(c.ToString());
            total += Convert.ToInt32(Math.Pow(value, length));
        }

        return total == number;
    }
}