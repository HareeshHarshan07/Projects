namespace SumOfMultiple
{
    public static class ArithmeticOperationExtensions
    {
        //Method to Find the sum of all natural numbers that are a multiple of 3 or 5 below the limit
        public static int AsSumOfMultipleOfThreeOrFive(this int limit)
        {
            limit--; // since we need below the limit
            return SumOfArithmeticProgression(limit, 3) + SumOfArithmeticProgression(limit, 5) -
                   SumOfArithmeticProgression(limit, 15);
        }

        private static int SumOfArithmeticProgression(int limit, int number)
        {
            limit /= number;

            // formula: n * (n + 1) * a/2
            return limit * (1 + limit) * number / 2;
        }
    }
}