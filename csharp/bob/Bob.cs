using System;

public static class Bob
{
    private static bool hasLetters(string statement)
    {
      foreach (char c in statement)
      {
        if (Char.IsLetter(c))
        {
          return true;
        }
      }
      return false;
    }
    public static string Response(string statement)
    {
      statement = statement.Trim();
      string punctuation = (statement.Length > 0) ? statement[statement.Length - 1].ToString() : "";

      if (statement == "")
      {
        return "Fine. Be that way!";
      }
      else if (statement.ToUpper() == statement && hasLetters(statement))
      {
        if (punctuation == "?")
        {
          return "Calm down, I know what I'm doing!";
        } 
        else 
        {
          return "Whoa, chill out!";
        }
      }
      else if (punctuation == "?") 
      {
        return "Sure.";
      }
      else
      {
        return "Whatever.";
      }
    }
}
