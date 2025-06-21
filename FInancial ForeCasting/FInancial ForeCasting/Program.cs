using System;

class FinancialForecast
{
    public static double PredictFutureValue(double principal, double rate, int years)
    {
        if (years == 0)
            return principal;
        return PredictFutureValue(principal, rate, years - 1) * (1 + rate);
    }
    public static double PredictFutureValueMemo(double principal, double rate, int years, double[] memo)
    {
        if (years == 0)
            return principal;

        if (memo[years] != 0)
            return memo[years];

        memo[years] = PredictFutureValueMemo(principal, rate, years - 1, memo) * (1 + rate);
        return memo[years];
    }

    static void Main(string[] args)
    {
        double principal = 1000;   
        double rate = 0.05;        
        int years = 10;          

        Console.WriteLine("Recursive Future Value: $" + PredictFutureValue(principal, rate, years));

        // Optimized using memoization
        double[] memo = new double[years + 1];
        Console.WriteLine("Memoized Future Value: $" + PredictFutureValueMemo(principal, rate, years, memo));
    }
}
