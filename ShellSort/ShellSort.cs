namespace ShellSort;

public class ShellSort
{
    public int[] Sort(int[] array)
    {
        var size = array.Length;

        for (int gap = size / 2; gap > 0; gap /= 2)
        {
            for (int i = gap; i < size; i++)
            {
                var currentKey = array[i];
                var k = i;
                while (k >= gap && array[k - gap] > currentKey)
                {
                    array[k] = array[k - gap];
                    k -= gap;
                }
                array[k] = currentKey;
            }
        }

        return array;
    }
}
