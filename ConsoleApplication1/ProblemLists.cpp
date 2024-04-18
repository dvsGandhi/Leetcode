#include "ProblemLists.h"
#pragma region 11. Container With Most Water
int ProblemLists::maxArea(vector<int>& vHeight)
{
	int maxwater = 0;
	int left = 0;
	int right = vHeight.size() - 1;
	while (left < right) {
		int height = min(vHeight.at(left), vHeight.at(right));
        int width = right - left;
        int currwater = height * width;

        maxwater = max(currwater, maxwater);
        if (vHeight.at(left) < vHeight.at(right))
        {
            left++;
        }
        else {
            right--;
        }
	}
	return maxwater;
}
#pragma endregion

#pragma region 14. Longest Common Prefix
string ProblemLists::longestCommonPrefix(vector<string>& strs)
{
    if(strs.empty())
        return "";

    string prefix = strs[0];
    for (int elementNo = 1;elementNo < strs.size();elementNo++)
    {
        prefix = longestCommonPrefix(prefix, strs[elementNo]);
    }
    return prefix;
}

string ProblemLists::longestCommonPrefix(string str1, string str2) 
{
    int i = 0;
    while (i < str1.size() && i < str2.size() && str1[i] == str2[i]) {
        i++;
    }
    return str1.substr(0, i);
}
#pragma endregion

