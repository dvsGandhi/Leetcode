#pragma once
#include <iostream> 
#include <vector>
#include "math.h"
#include <unordered_map>
using namespace std;

class ProblemLists
{
public:
	int maxArea(vector<int>& height);
	string longestCommonPrefix(vector<string>& strs);
	vector<vector<int>> threeSum(vector<int>& nums);
	int threeSumClosest(vector<int>& nums, int target);
	vector<string> letterCombinations(string digits);

private:
	string longestCommonPrefix(string str1, string str2);
	unordered_map<char, string> M = {
		{'2', "abc"},
		{'3', "def"},
		{'4', "ghi"},
		{'5', "jkl"},
		{'6', "mno"},
		{'7', "pqrs"},
		{'8', "tuv"},
		{'9', "wxyz"}
	};
};

