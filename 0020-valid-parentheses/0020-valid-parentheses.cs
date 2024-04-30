public class Solution 
{
    public bool IsValid(string s) 
    {
        if (s.Length % 2 != 0)
            return false;
        
        var bracketDictionary = new Dictionary<char, char>()
                              {
                                  { '(', ')' },
                                  { '[', ']' },
                                  { '{', '}' }
                              };
        
        var stack = new Stack<char>();
        
        foreach (var c in s)
        {
            if (bracketDictionary.ContainsKey(c))
                stack.Push(c);
            else
            {
                if (stack.Count == 0 || bracketDictionary[stack.Peek()] != c)
                    return false;
                
                stack.Pop();
            }
        }
        
        return stack.Count == 0;
    }
}