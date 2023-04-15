namespace ArraysSorting
{
    public class SortArray
    {
        /// <summary>
        /// Сортировка пузырьком
        /// </summary>
        /// <param name="arr">Массив который нужно отсортировать</param>
        /// <returns>Отсортированный массив</returns>
        public static int[] BubbleSort(int[] arr)
        {
            while (true)
            {
                bool flag = false;

                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        (arr[i + 1], arr[i]) = (arr[i], arr[i + 1]);
                        flag = true;
                    }
                }

                if (!flag) { break; }
            }

            return arr;
        }
        /// <summary>
        /// Сортировка выбором
        /// </summary>
        /// <param name="arr">Массив который нужно отсортировать</param>
        /// <returns>Отсортированный массив</returns>
        public static int[] SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int smallestValueIndex = i;

                for (int j = i; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                        smallestValueIndex = j + 1;
                }

                (arr[i], arr[smallestValueIndex]) = (arr[smallestValueIndex], arr[i]);
            }

            return arr;
        }
        /// <summary>
        /// Сортировка вставками
        /// </summary>
        /// <param name="arr">Массив который нужно отсортировать</param>
        /// <returns>Отсортированный массив</returns>
        public static int[] InsertionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j <= 0; j--)
                {
                    if (arr[j] < arr[i])
                    {
                        (arr[i], arr[j]) = (arr[j], arr[i]);
                    }
                }
            }

            return arr;
        }
    }
}
