class Solution {
public:
    bool isPalindrome(int x) 
    {
        if(x < 0 || (x % 10 == 0 && x != 0))
			return false;

		auto reversed_number = 0;

		while(x > reversed_number)
		{
			const auto digit = x % 10;

			reversed_number = reversed_number * 10 + digit;

			x /= 10;
		}

		return x == reversed_number || x == reversed_number / 10;
    }
};