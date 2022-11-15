int arrLength = int.Parse(Console.ReadLine());
int[] arr = new int[arrLength];
int sum = 0;
for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine("Enter array indexes:");
    arr[i] = int.Parse(Console.ReadLine());
    if (arr[i] % 2 == 0)
    {
        sum = arr[i] + sum;
    }
}
Console.WriteLine(sum);
