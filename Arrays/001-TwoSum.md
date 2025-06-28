---
Title: Two Sum
Link: https://leetcode.com/problems/two-sum/
Topic: Arrays
Difficulty: Easy
DateSolved: 28-06-2025
---

## 🧠 Approach 1: Brute Force (O(n^2))
Try every pair using two nested loops.

```csharp
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for(int i=0; i<nums.Length-1; i++){

            for(int j=i+1; j<nums.Length; j++){

                if(nums[i]+nums[j]==target){

                    return new int[]{i,j};
                }
            }
        }

        return new int[]{-1,-1};
    }
}
