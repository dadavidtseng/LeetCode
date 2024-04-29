public class Solution 
{
    public int RomanToInt(string s) 
    {
        var romanValues = new Dictionary<char, int>
                          {
                              { 'I', 1 },
                              { 'V', 5 },
                              { 'X', 10 },
                              { 'L', 50 },
                              { 'C', 100 },
                              { 'D', 500 },
                              { 'M', 1000 }
                          };

        var result = 0;

        for (var i = 0; i < s.Length; i++)
        {
            var currentValue = romanValues[s[i]];

            if (i < s.Length - 1 && romanValues[s[i + 1]] > currentValue)
            {
                result -= romanValues[s[i]];
                continue;
            }

            result += currentValue;
        }

        return result;
    }
    
}