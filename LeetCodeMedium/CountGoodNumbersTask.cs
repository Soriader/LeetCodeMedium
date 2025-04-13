namespace LeetCodeMedium;

public class CountGoodNumbersTask
{
    private const int Mod = 1_000_000_007;
    
    public static int CountGoodNumbers(long n) 
    {
        long evenCount = (n + 1) / 2;
        long oddCount = n / 2;
        
        long evenPart = ModularPow(5, evenCount, Mod);
        long oddPart = ModularPow(4, oddCount, Mod);
        
        return (int)((evenPart * oddPart) % Mod);
    }
    
    private static long ModularPow(long a, long b, int mod) {
        long result = 1;
        a = a % mod;
        
        while (b > 0) 
        {
            if (b % 2 == 1)
            {
                result = (result * a) % mod;
            }
            
            a = (a * a) % mod;
            b = b / 2;
        }
        
        return result;
    }
}
//https://leetcode.com/problems/count-good-numbers/description/?envType=daily-question&envId=2025-04-13