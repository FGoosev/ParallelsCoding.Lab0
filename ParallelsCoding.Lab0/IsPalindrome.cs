namespace ParallelsCoding.Lab1;
//Easy
public class SecondTask
{
    public bool IsPalindrome(int x) {
        string str = x.ToString();
        char[] chars = str.ToCharArray();
        if (chars[0] == '-')
        {
            return false;
        }

        var reverseStr = str.Reverse().ToArray();

        for (int i = 0; i < chars.Length; i++)
        {
            if (chars[i] != reverseStr[i])
            {
                return false;
            }
        }

        return true;
    }
}