class Solution 
{
public:
    int romanToInt(const string& s) 
    {
        unordered_map<char, int> roman_values
			{
				{'I', 1},
				{'V', 5},
				{'X', 10},
				{'L', 50},
				{'C', 100},
				{'D', 500},
				{'M', 1000}
			};

			auto result = 0;

			for(int i = 0; i < static_cast<int>(s.length()); ++i)
			{
				const auto current_value = roman_values[s[i]];

				if(i < static_cast<int>(s.length()) && roman_values[s[i + 1]] > current_value)
				{
					result -= roman_values[s[i]];
					continue;
				}

				result += current_value;
			}

			return result;
    }
};