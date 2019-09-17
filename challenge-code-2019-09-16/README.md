# Given a list of numbers and a number k, return whether any two numbers from the list add up to k.
For example, given [10, 15, 3, 7] and k of 17, return true since 10 + 7 is 17.

## Bonus: Can you do this in one pass?

Reading this first challenge, I was playing with the numbers and the potential distribution. This brought to my mind the [triangle numbers](https://en.wikipedia.org/wiki/Triangular_number) as the number of combinations for the array numbers would follow n(n-1)/2. In the example 4 numbers will have 6 pairs. On the other hand, it reminded me of [polygons diagonals](https://en.wikipedia.org/wiki/Diagonal#Polygons). You can check as well that when you connect any two vertex, you will find them follow a triangle number: diagonals = n(n-3)/2. Adding the sides you will have n(n-3)/2 + n = n(n-1)/2

Origin: Google

**Looking to resolve the challenge, you can check for each element, if there is other element that match the sum.**

```csharp

    int[] data = new int[4] {10, 15, 3, 7};
    int sum = 17;

    Console.ForegroundColor = ConsoleColor.White;
    foreach (int val in data){
        if(Array.Exists(data, number => number == (sum - val))){
            Console.WriteLine(val);
        }                
    }
