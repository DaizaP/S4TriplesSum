
internal class Program
{
    public static List<int> FindTriplesSum(int[] inputArray, int requiredNumber)
    {
        Array.Sort(inputArray);
        List<int> result = [];
        for (int i = 0; i < inputArray.Length - 2; i++)
        {
            int left = i + 1;
            int right = inputArray.Length - 1;
            while (left < right)
            {
                int sum = inputArray[i] + inputArray[left] + inputArray[right];
                
                if(sum == requiredNumber)
                {
                    result.Add(inputArray[i]);
                    result.Add(inputArray[left]);
                    result.Add(inputArray[right]);
                    break;
                }
                else if (sum < requiredNumber)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

            if(result.Count > 0)
            {
                break;
            }
        }

        return result;
    }
    private static void Main(string[] args)
    {
        //Дан массив и число. Найдите три числа в массиве сумма которых равна искомому числу.
        //Подсказка: если взять первое число в массиве, можно ли найти в оставшейся его
        //части два числа равных по сумме первому.
        int[] arrayInt = [2, 3, 5, 8, 0, 5, 5, 7, 0, 9, 64, 2, 1, 4, 6, 8, 9, 3, 3, 6];
        int requiredNumber = 20;
        List<int> resListInt = FindTriplesSum(arrayInt, requiredNumber);
        if(resListInt.Count > 0)
        {
            Console.Write("Комбинация найдена ");
            resListInt.ForEach(Console.Write);
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Комбинация не найдена.");
        }
    }
}