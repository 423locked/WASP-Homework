namespace Homework;

public static class Addons
{
    public static string NormalizeBinary(string bin, string sum)
    {
        int diff = sum.Length - bin.Length;
        return new string('0', diff) + bin;
    }

    public static string NormalizeBinary(string bin)
    {
        int diff = 8 - bin.Length;
        return new string('0', diff) + bin;
    }

    public static string NormalizeBinary(string bin, int n)
    {
        int diff = n - bin.ToString().Length;
        return new string('0', diff) + bin;
    }
    
    public static string Reverse(string s)
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    public static string ToBinary(long n)
    {
        string t = "";
        while (n > 0)
        {
            t += Convert.ToString(n % 2);
            n = n / 2;
        }

        return string.Join("", Reverse(t));
    }

    public static long ToDecimal(string bin)
    {
        long result = 0;
        for (int i = 0; i < bin.Length; i++)
        {
            try {
                int val = Int32.Parse(bin[i].ToString());
                if (val == 1)
                    result += (int) Math.Pow(2, bin.Length - 1 - i);
                else if (val > 1)
                    throw new Exception("Invalid!");
            } 
            catch { throw new Exception("Invalid!"); }
                    
        }

        return result;
    }
}