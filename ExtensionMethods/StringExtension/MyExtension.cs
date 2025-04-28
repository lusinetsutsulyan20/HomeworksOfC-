// String տիպի համար ընդլայնել հետևյալ մեթոդները
// string [] Split(string seperator)
// int IndexOf(string str)
// bool Contains(string str)
// string Substring(int start, int count)

using System.Text;

namespace MyExtensionsNamespace
{
public static class Extensions
{
    public static List<string> MySplit(this string str, char c)
    {
        List <string> _array = new List<string>();
        int start = 0;
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == c)
            {
                _array.Add(MySubstring(str, start, i - start));
                start = i + 1;
            }
        }
        _array.Add(MySubstring(str, start, str.Length - start));
        return _array;
    }

    public static int MyIndexOf(this string str, char c)
    {
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == c)
            {
                return i;
            }
        }
        return -1;
    }
    public static bool MyContains(this string str, string cmp)
    {
        bool isContain = false;
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == cmp[0])
            {
                isContain = MyCompare(str, cmp, i);
            }
        }
        return isContain;
    }
    public static bool MyCompare(this string str, string cmp, int index)
    {
        int j = 0;
        for (int i = index; i < cmp.Length; i++)
        {
            if (str[i] != cmp[j++])
            {
                return false;
            }
        }
        return true;
    }
    
    public static string MySubstring (this string str, int start,  int count)
    {
        StringBuilder _array = new StringBuilder();
        int index = 0;
        for (int i = start; i < start + count; i++)
        {
           _array.Append(str[i]);
        }
        string res = _array.ToString();
        return res;
    }
}
}
