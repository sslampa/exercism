using System;

public static class Raindrops
{
    public static string Convert(int number)
    {
        string result = "";
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0) 
            {
                switch (i)
                {
                    case 3:
                        result += "Pling";
                        break;
                    case 5:
                        result += "Plang";
                        break;
                    case 7:
                        result += "Plong";
                        break;
                }
            }
        }

        if (result == "")
        {
            return number.ToString();
        }

        return result;
    }
}