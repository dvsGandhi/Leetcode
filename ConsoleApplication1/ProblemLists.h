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

	struct ListNode {
		int val;
		ListNode* next;
		ListNode() : val(0), next(nullptr) {}
		ListNode(int x) : val(x), next(nullptr) {}
		ListNode(int x, ListNode* next) : val(x), next(next) {}
	};
	ListNode* removeNthFromEnd(ListNode* head, int n);

	bool isValid(string s);
	ListNode* mergeTwoLists(ListNode* list1, ListNode* list2);

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

