//*****************************************************************************
//** Find the Power of K Size Subarrays I    leetcode                        **
//*****************************************************************************

/**
 * Note: The returned array must be malloced, assume caller calls free().
 */
int* resultsArray(int* nums, int numsSize, int k, int* returnSize) {
    *returnSize = numsSize - k + 1;
    int* retArray = (int*)malloc((*returnSize) * sizeof(int));
    int x = 0;
    for(int i = 0; i <= numsSize - k; i++) 
    {
        bool isConsecutive = true;
        for(int j = 1; j < k; j++) 
        {
            if(nums[i + j] != nums[i + j - 1] + 1) 
            {
                isConsecutive = false;
                break;
            }
        }
        
        if(isConsecutive) 
        {
            retArray[x++] = nums[i + k - 1];
        } 
        else 
        {
            retArray[x++] = -1;
        }
    }
    return retArray;
}