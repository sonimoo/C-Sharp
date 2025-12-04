#pragma warning disable CS8321 // Local function is declared but never used

    {
        int[] arr1 = [1, 2, 3, 9, 2];
        int[] arr2 = [4, 5, 6, 9];
        int[] resultWhile = new int[arr1.Length];
        int[] resultFor = new int[arr1.Length];

        resultWhile = ArraySumW(arr1, arr2, resultWhile);
        Console.WriteLine("Result array with while: " + string.Join(", ", resultWhile));

        // resultFor = ArraySumF(arr1, arr2, resultFor);
        // Console.WriteLine("Result array with for: " + string.Join(", ", resultFor));
    }

    static int[] ArraySumW(int[] arrfirst, int[] arrsecond, int[] res)
    {
        if (arrfirst.Length != arrsecond.Length)
            throw new ArgumentException("Arrays are different length");

        int i = 0;
        while (i < arrfirst.Length)
        {
            res[i] = arrfirst[i] + arrsecond[i];
            i++;
        }
        return res;
    }

static int[] ArraySumF(int[] arrfirst, int[] arrsecond, int[] res)
    {
        if (arrfirst.Length != arrsecond.Length)
            throw new ArgumentException("Arrays are different length");
        for (int i = 0; i < arrfirst.Length; i++)
        {
            res[i] = arrfirst[i] + arrsecond[i];
        }
        return res;
    }
