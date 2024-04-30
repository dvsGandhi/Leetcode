#include "ProblemLists.h"
#include <algorithm>
#include <iostream>
#include <set>
using namespace std;
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

#pragma region 15. 3Sum
/// <summary>
/// Input: nums = [-1,0,1,2,-1,-4]
///Output : [[-1, -1, 2], [-1, 0, 1]]
///Explanation :
///    nums[0] + nums[1] + nums[2] = (-1) + 0 + 1 = 0.
///    nums[1] + nums[2] + nums[4] = 0 + 1 + (-1) = 0.
///    nums[0] + nums[3] + nums[4] = (-1) + 2 + (-1) = 0.
///    The distinct triplets are[-1, 0, 1] and [-1, -1, 2].
///    Notice that the order of the output and the order of the triplets does not matter.
/// <returns></returns>
vector<vector<int>> ProblemLists::threeSum(vector<int>& nums)
{
    vector<vector<int>> output;
    sort(nums.begin(), nums.end());
    int size = nums.size();
    set<vector<int>> s;
    for (int firstRecord = 0;firstRecord < size;firstRecord++)
    {
        int i = firstRecord;
        int j = i + 1;
        int k = size - 1;
        while (j < k)
        {
            int sum = nums[i] + nums[j] + nums[k];
            if (sum == 0)
            {
                s.insert({ nums[i], nums[j], nums[k] });
                j++;
                k--;
            }
            else if (sum < 0)
                j++;
            else
                k--;
        }
    }
    for (auto triplet : s)
    {
        output.emplace_back(triplet);
    }
    return output;
}
#pragma endregion

#pragma region 16. 3Sum Closest
int ProblemLists::threeSumClosest(vector<int>& nums, int target) {
    int sum = 0;
    for (int i = target==0?1:0;i <nums.size();i++)
    {
        sum += nums[i];
        if (nums[i] == target)
            break;
    }
    return sum;
}
#pragma endregion