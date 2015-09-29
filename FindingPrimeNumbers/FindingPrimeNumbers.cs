namespace FindingPrimeNumbers
{
    public class FindingPrimeNumbers
    {
        public long FindSumOfPrimeNumbers(int n)
        {


            long sum = 0;
            int count = 0;
            int num = 2;
            while (count < n)
            {
                if (PrimeNumbers(num))
                {
                    count++;
                    sum = sum + num;
                }

                num++;
            }

            return sum;
        }
        public bool PrimeNumbers(int num)
        {
            bool current = true;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0) current = false;

            }

            return current;
        }
    }
}