using System;
using System.Collections.Generic;

public class NucleotideCount
{
    IDictionary<char, int> counts = new Dictionary<char, int>(){
        {'A', 0},
        {'C', 0},
        {'G', 0},
        {'T', 0}
    };
    public NucleotideCount(string sequence)
    {
        foreach (char c in sequence)
        {
            switch (c)
            {
                case 'A':
                    counts['A'] += 1;
                    break;
                case 'C':
                    counts['C'] += 1;
                    break;
                case 'G':
                    counts['G'] += 1;
                    break;
                case 'T':
                    counts['T'] += 1;
                    break;
                default:
                    throw new InvalidNucleotideException();
            }
        }
    }

    public IDictionary<char, int> NucleotideCounts
    {
        get
        {
            return counts;
        }
    }
}
public class InvalidNucleotideException : Exception { }
