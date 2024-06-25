class Solution 
{
    public:
        bool isValid(string s) 
        {
            unordered_map<char, char> bracket_pairs
			{
				{'(', ')'},
				{'[', ']'},
				{'{', '}'}
			};

			stack<char> stack;

			for(char c : s)
			{
				if(bracket_pairs.find(c) != bracket_pairs.end())
					stack.push(bracket_pairs[c]);
				
				else
				{
					if(stack.empty() || stack.top() != c)
						return false;

					stack.pop();
				}
			}

			return stack.empty();
        }
};