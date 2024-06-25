class Solution 
{
    public:
        string longestCommonPrefix(vector<string>& strs) 
        {
            if(strs.empty())
				return "";

			for(int i = 0; i < static_cast<int>(strs[0].length()); ++i)
			{
				const auto c = strs[0][i];

				for(int j = 1; j < static_cast<int>(strs.size()); ++j)
				{
					if(i >= static_cast<int>(strs[j].length()) || strs[j][i] != c)
						return strs[0].substr(0, i);
				}
			}

			return strs[0];
        }
};