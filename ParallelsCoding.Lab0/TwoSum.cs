namespace ParallelsCoding.Lab1;
//Easy
//Вернуть индексы чисел из массива, сумма которых равна числу target
public class FirstTask
{
    public int[] TwoSum(int[] nums, int target) {
        for(int i = 0; i < nums.Length; i++){
            for(int j = i + 1; j < nums.Length; j++){
                if(nums[i] + nums[j] == target){
                    int[] arr = new int[]{i,j};
                    return arr;
                }
            }
        }
        int[] arr2 = new int[]{0,0};
        return arr2;
    }
}