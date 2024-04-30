public class Solution 
{
    public bool IsValid(string s) 
    {
        var bracketPairs = new Dictionary<char, char>()
                           {
                               { '(', ')' },
                               { '[', ']' },
                               { '{', '}' }
                           };

        var stack = new Stack<char>();

        foreach (var c in s)
        {
            if (bracketPairs.TryGetValue(c, out var value))
                stack.Push(value);

            else if (stack.Count == 0 || stack.Pop() != c)
                return false;
        }

        return stack.Count == 0;
    }
}