using System;
using System.Collections.Generic;
using System.Linq;

public class School
{
    private SortedDictionary<string, int> schoolDB = new SortedDictionary<string, int>();

    public void Add(string student, int grade)
    {
        schoolDB.Add(student, grade);
    }

    public IEnumerable<string> Roster()
    {
        foreach(var student in schoolDB.OrderBy(s => s.Value))
        {
            yield return student.Key;
        }
    }

    public IEnumerable<string> Grade(int grade)
    {
        foreach(var student in schoolDB)
        {
            if (student.Value == grade)
            {
                yield return student.Key;
            }
        }
    }
}