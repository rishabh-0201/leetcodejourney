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