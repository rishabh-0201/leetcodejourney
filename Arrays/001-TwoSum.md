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
```
## 🧠 Approach 2: Two Pointer Approach (O(nlogn))
Just sorting with array.sort method changes the original index which was the problem, so for that we have stored the original indexes and sort the values only.


```csharp
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
     int left = 0; int right = nums.Length-1;
     var indexedNums = nums.Select((value,index)=> new {value,index}).ToList();

     indexedNums.Sort((a,b)=>a.value.CompareTo(b.value));
     while(left<right){
        if(indexedNums[left].value+indexedNums[right].value<target){
            left++;
        }else if(indexedNums[left].value+indexedNums[right].value>target){
            right--;
        }
        else if(indexedNums[left].value+indexedNums[right].value==target){

            return new int[]{indexedNums[left].index,indexedNums[right].index};
        }       
     }
     return new int[]{-1,-1};
    }
}
```