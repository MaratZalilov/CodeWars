using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars;

public static class ReversedStrings
{
    public static string BreakCamelCase(string str)
    {
        if (str.Length < 1)
            return "";

        string space = " ";

        foreach (char c in str) 
        {
            if (char.IsUpper(c))
                space = str.Substring(0, str.IndexOf(c)) + " " + str.Substring(str.IndexOf(c));

            str = space;
        }
        return space;
    }

    //public static string BreakCamelCase(string str)
    //{
    //    List<string> list = new List<string>();
    //    string space = " ";
    //    char c = ' ' ;
    //    int count = 0,count1 = 0;
    //    for (int i = 0; i < str.Length; i++)
    //    {
    //        if (char.IsUpper(str[i]))
    //        {     
    //            space = str.Substring(i);
    //            list.Add(space);
    //        }

    //        else if (char.IsLower(str[i]) && count >= str.Length)
    //        {
    //            return str;
    //        }
    //    }
    //    str = String.Join(c, list);
    //    return str;
    //}

    //public static string BreakCamelCase(string str)
    //{
    //    string space = " ";
    //    for (int i = 0; i < str.Length; i++)
    //    {
    //        if (char.IsUpper(str[i]))
    //        {
    //            space = str.Substring(0, i);
    //            space += " ";
    //            space += str.Substring(i);
    //        }
    //    }
    //    return str;
    //}
}
