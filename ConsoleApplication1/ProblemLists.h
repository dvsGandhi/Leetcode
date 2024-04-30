#pragma once
#include <iostream> 
#include <vector>
using namespace std;
#include "math.h"

class ProblemLists
{
public:
	int maxArea(vector<int>& height);
	string longestCommonPrefix(vector<string>& strs);
	vector<vector<int>> threeSum(vector<int>& nums);
	int threeSumClosest(vector<int>& nums, int target);

private:
	string longestCommonPrefix(string str1, string str2);
};

