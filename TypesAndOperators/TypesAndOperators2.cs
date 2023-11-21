namespace TypesAndOperators2;

public class TypesAndOperators2
{
    static void Main3(string[] args)
    {
        //Задача
        int[] nums = {-4, 8, 10, 2, 12, 10};
        
        /*
        nums[0]<-> nums [nums.Length -1 -0]
        nums[1]<-> nums [nums.Length -1 -1]
        nums[2]<-> nums [nums.Length -1 -2]*/


        int n = nums.Length; // dlina massiva
        int k = n / 2;
        int tmp;

        for (int i = 0; i < k; i++)
        {
            for (int j = 0; j < k; j++)
            {
                tmp = nums[i];
                nums[i] = nums[n - 1 - i];
                nums[n -1- i] = tmp;
            }

            foreach (int item in nums)
            {
                Console.Write($"{item} \t");
            }
            Console.WriteLine();
        }
//Array.Reverse(nums);
    }
}


