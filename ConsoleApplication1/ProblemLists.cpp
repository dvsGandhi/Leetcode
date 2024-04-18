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
