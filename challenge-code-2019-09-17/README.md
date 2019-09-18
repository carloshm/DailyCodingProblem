# Given an array of integers, return a new array such that each element at index i of the new array is the product of all the numbers in the original array except the one at i.
For example, if our input was [1, 2, 3, 4, 5], the expected output would be [120, 60, 40, 30, 24]. If our input was [3, 2, 1], the expected output would be [2, 3, 6].

## Follow-up: what if you can't use division?

This problem was asked by Uber.

**Looking to resolve the challenge, you can aggregate and divide by the position, or loop through the values but the position involved; while considering edge case 0.**

```csharp

            int[] data = new int[5] {1, 2, 3, 4, 5};
            int[] resultDiv = new int[5];
            int[] result = new int[5] {1, 1, 1, 1, 1};
            int denominator = data.Aggregate((x, y) => {
                if (x != 0 && y!= 0){
                    return (x*y);
                    }
                else
                    {
                    if (x == 0){
                        return (1*y);
                        }
                    else
                        {
                        return (x*1);
                        }
                    }
                });

            for (int loop = 0; loop < data.Length; loop++){
                if(data[loop] != 0) {
                    resultDiv[loop] = denominator / data[loop];
                }
            }
            Console.WriteLine(string.Join(",", resultDiv));

            for (int i = 0; i < result.Length; i++){
                for (int j = 0; j < data.Length; j++){
                    if(i != j){
                        if (data[j] != 0)
                        {
                            result[i] = result[i] * data[j];
                        }
                        else
                        {
                        result[j] = 0;
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(",", result));
