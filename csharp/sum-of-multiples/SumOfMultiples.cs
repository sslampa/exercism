using System;
using System.Collections.Generic;
using System.Linq;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        List<int> group = new List<int>();
        foreach (int m in multiples)
        {
            int current = m;
            int i = 1;
            while (current < max)
            {
                current = m * i++;
                if (current < max && group.Contains(current) == false)
                {
                    group.Add(current);
                }
            }
        }

        return group.Sum();
    }
}