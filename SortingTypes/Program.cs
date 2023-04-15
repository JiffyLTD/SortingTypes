using ArraysSorting;
internal class Program
{
    private static void Main(string[] args)
    {
        int[] arr = new int[10];

        ArrayFilling.FillArray(arr, -50, 50);

        Console.WriteLine("Первоначальный массив: ");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i]);

            if(i < arr.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine("");

        var timeStartBubble = DateTime.Now;
        var bubbleArr = SortArray.BubbleSort(arr);
        var timeEndBubble = DateTime.Now;

        Console.WriteLine("\nСортировка пузырьком: ");
        for (int i = 0; i < bubbleArr.Length; i++)
        {
            Console.Write(bubbleArr[i]);

            if (i < bubbleArr.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine("\nВремя выполнения: " + (timeEndBubble-timeStartBubble));

        var timeStartSelection = DateTime.Now;
        var selectionArr = SortArray.SelectionSort(arr);
        var timeEndSelection = DateTime.Now;

        Console.WriteLine("\nСортировка выбором: ");
        for (int i = 0; i < selectionArr.Length; i++)
        {
            Console.Write(selectionArr[i]);

            if (i < selectionArr.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine("\nВремя выполнения: " + (timeEndSelection - timeStartSelection));

        var timeStartInsertion = DateTime.Now;
        var insertionArr = SortArray.InsertionSort(arr);
        var timeEndInsertion = DateTime.Now;

        Console.WriteLine("\nСортировка вставками: ");
        for (int i = 0; i < insertionArr.Length; i++)
        {
            Console.Write(insertionArr[i]);

            if (i < insertionArr.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine("\nВремя выполнения: " + (timeEndInsertion - timeStartInsertion));
    }
}