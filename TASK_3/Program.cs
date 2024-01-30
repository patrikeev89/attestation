class Program
{
    static void Main()
    {
        int[] Array = { 1, 2, 3, 4, 5 };

        Console.WriteLine("Элементы массива, начиная с конца:");
        PrintArrayRevers(Array, Array.Length - 1);

        Console.ReadLine();
    }

    static void PrintArrayRevers(int[] arr, int index)
    {
        if (index >= 0)
        {
            Console.WriteLine(arr[index]);
            PrintArrayRevers(arr, index - 1);
        }
    }
}