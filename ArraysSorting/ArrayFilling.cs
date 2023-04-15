namespace ArraysSorting
{
    public class ArrayFilling
    {
        public static int[] FillArray(int[] arr, int minValue, int maxValue)
        {
            Random random = new ();

            for(int i=0; i<arr.Length; i++)
            {
                arr[i] = random.Next(minValue, maxValue);
            }

            return arr;
        }
    }
}
