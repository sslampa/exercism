using System;
using System.Collections.Generic;

public enum Plant
{
    Violets,
    Radishes,
    Clover,
    Grass
}

public class KindergartenGarden
{    
    private string _top;
    private string _bottom;
    private string _students = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    public KindergartenGarden(string diagram)
    {
        string[] rows = diagram.Split('\n');
        _top = rows[0];
        _bottom = rows[1];
    }

    public KindergartenGarden(string diagram, IEnumerable<string> students)
    {
    }

    public IEnumerable<Plant> Plants(string student)
    {
        char firstLetter = student[0];
        int index = _students.IndexOf(firstLetter);
        int start = 2 * index;

        char[] plants = {_top[start], _top[start + 1], _bottom[start], _bottom[start + 1]};
        foreach (char p in plants)
        {
            yield return convertToEnum(p);
        }
    }

    private Plant convertToEnum(char p) 
    {
        switch (p)
        {
            case 'V':
                return Plant.Violets;
            case 'R':
                return Plant.Radishes;
            case 'C':
                return Plant.Clover;
            case 'G':
                return Plant.Grass;
            default:
                throw new KeyNotFoundException();
        }
    }
}