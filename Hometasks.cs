namespace Homework;

using System;

public static class Hometasks
{
    public static void Task1_1()
    {
        int count = 0;
        for (int a = 9; a >= 3; --a)
            for (int b = a - 1; b >= 2; --b)
                for (int c = b - 1; c >= 1; --c)
                    for (int d = c - 1; d >= 0; --d)
                    {
                        Console.WriteLine($"{a}{b}{c}{d}");
                        count++;
                    }
        Console.WriteLine($"Amount of magic numbers = {count}");
    }

    public static void Task1_3(int x1, int y1, int x2, int y2, int x3, int y3)
    {
        if (x1 == x2 && y2 == y3)
            for (int i = 0; i < y3; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        
        else if (x1 == x3 && y2 == y3)
            for (int i = 0; i < y3; i++)
            {
                for (int j = 0; j < y3 - i; j++)
                    Console.Write(' ');
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        else if (x1 == x3 && y1 == y2)
            for (int i = y3; i >= 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        else if (y1 == y2 && x2 == x3)
            for (int i = y3; i > 0; --i)
            {
                for (int j = 0; j < y3 - i; j++)
                    Console.Write(' ');
                
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        Console.WriteLine();
    }
    
    public static void Task1_4(int n)
    {
        for (int i = 0; i < n; i++)
        {
            int c = 1;
            for (int k = 0; k <= i; k++)
            {
                Console.Write($" {c:D}");
                c = c * (i - k) / (k + 1);
            }
            Console.Write("\n");
        }
    }
    
    public static string Task2_1(long n)
    {
        return Addons.ToBinary(n);
    }

    public static void Task2_2(int a, int b)
    {
        string binA = Task2_1(a), binB = Task2_1(b);
        string sum = Addons.ToBinary(a + b);
        binA = Addons.NormalizeBinary(binA, sum);
        binB = Addons.NormalizeBinary(binB, sum);
        Console.WriteLine(binA);
        Console.WriteLine(binB);
        Console.WriteLine(new string('-', sum.Length));
        Console.WriteLine(sum);
    }

    public static void Task2_3(short a, short b, short c, short d)
    {
        long mask = 0b0;
        mask = mask | Convert.ToInt64(d) << 48 
                    | Convert.ToInt64(c) << 32
                    | Convert.ToInt64(b) << 16
                    | Convert.ToInt64(a) << 0;
        
        Console.WriteLine(mask);
    }

    public static void Task2_4(long intTemp)
    {
        string temp = Addons.NormalizeBinary(Addons.ToBinary(intTemp), 64);

        long d = Addons.ToDecimal(temp.Substring(0, 16));
        long c = Addons.ToDecimal(temp.Substring(16, 16));
        long b = Addons.ToDecimal(temp.Substring(32, 16));
        long a = Addons.ToDecimal(temp.Substring(48, 16));
        
        Console.WriteLine(temp);
        Console.WriteLine($"{a} {b} {c} {d}");
    }
    
    public static void Task2_5(long n, short m, short k)
    {
        long d = n & 0x51 | n & 0x50;
        Console.WriteLine(Convert.ToString(n, 2));
        Console.WriteLine(d);
    }

    public static double Task3_1(int p, int[] v)
    {
        double sum = 0;
        for (int i = 0; i < v.Length; i++)
            sum += v[i];
        return Math.Pow(sum, (double) 1 / p);
    }
    
    public static int Task3_2(int k, int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)    
            for (int j = 0; j < arr.Length - 1; j++)
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp; 
                }

        arr = arr.Distinct().ToArray();

        return arr[k - 1];
    }

    public static int[] Task3_3(int[] arr, string q)
    {
        int[] qvals = q.Split(':').Select(x => int.Parse(x)).ToArray();
        int j = 0, count = 0;
        
        if (qvals[2] < 0)
            for (int i = qvals[1]; i >= qvals[0]; i += qvals[2]) 
                count++;
        else 
            for (int i = qvals[0]; i <= qvals[1]; 
                 i += qvals[2]) count++;
        
        int[] nums = new int[count];
        
        if (qvals[2] < 0)
            for (int i = qvals[1]; i >= qvals[0]; i += qvals[2])
            { nums[j] = arr[i]; j++; }
        else
            for (int i = qvals[0]; i <= qvals[1]; i += qvals[2])
            { nums[j] = arr[i]; j++; }

        return nums;
    }
}