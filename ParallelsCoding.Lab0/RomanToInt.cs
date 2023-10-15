namespace ParallelsCoding.Lab1;
//Easy
public class ThirdTask
{
    public int RomanToInt(string s) {
        var sum = 0;
        Dictionary<char, int> num = new Dictionary<char, int>
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };
        
        for(int i = 0; i < s.Length; i++)
        {
            var firstValue = num.First(item => item.Key == s[i]);
            if (i == s.Length - 1)
            {
                sum += firstValue.Value;
                break;
            }
            var secondValue = num.First(item => item.Key == s[i+1]);
            if (firstValue.Value >= secondValue.Value)
            {
                sum += firstValue.Value;
            }
            else
            {
                sum += secondValue.Value - firstValue.Value;
                i += 1;
            }
        }

        return sum;
    }
}