using System.Threading.Channels;

namespace Homework;

public static class Tests
{
    public static void Test2_2()
    {
        Hometasks.Task2_2(5, 12);
    }
    
    public static void Test2_3_4()
    {
        Hometasks.Task2_3(1, 2, 4, 8);
        Hometasks.Task2_4(2251816993685505);
    }

    public static void Test1_3()
    {
        Hometasks.Task1_3(0, 0, 0, 4, 4, 4);
        Hometasks.Task1_3(4, 0, 0, 4, 4, 4);
        Hometasks.Task1_3(0, 0, 4, 0, 0, 4);
        Hometasks.Task1_3(0, 0, 4, 0, 4, 4);
    }

    public static void Test3_1()
    {
        int[] a = {1, 1, 1, 1};
        int p = 2;
        Console.WriteLine(Hometasks.Task3_1(p, a));
    }
    
    public static void Test3_2()
    {
        int[] a = {5, 6, 0, -1, 3, 9, 4, 4, 4, 8};
        Console.WriteLine(Hometasks.Task3_2(2, a));
    }

    public static void Test3_3()
    {
        int[] a = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        string query = "2:10:-2";
        foreach (var el in Hometasks.Task3_3(a, query))
            Console.WriteLine($"{el} ");
    }
}