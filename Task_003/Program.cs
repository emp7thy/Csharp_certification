int[] HelperReverce(int[] arr, int counter, List<int> preparedData) 
    {
        if (counter == 0) {
            return preparedData.ToArray();
        }
        preparedData.Add(arr[counter - 1]);
        counter--;
        return HelperReverce(arr, counter, preparedData);
    }

int[] Reverce(int[] arr) 
    {
        List<int> preparedData = new List<int>();
        int counter = arr.Length;
        int[] result = HelperReverce(arr, counter, preparedData);
        return result;
    }

int[] arr = {1, 2, 3, 4, 5, 6,7,8,9,10};
int[] result = Reverce(arr);
Console.WriteLine(string.Join(" ", result));
