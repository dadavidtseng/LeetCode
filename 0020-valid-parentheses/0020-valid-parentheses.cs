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
            if (bracketDictionary.TryGetValue(c, out var correspondingBracket))
                stack.Push(correspondingBracket);
            
            else if (stack.Count == 0 || stack.Pop() != c)
                return false;
        }
        
        return stack.Count == 0;
    }
}