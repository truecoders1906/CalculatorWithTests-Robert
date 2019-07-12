using System;

namespace CalculatorWithTests
{
    public class Calculator
    {
        public int Addnums(int[] numbers)
        {
            int i = 0;
            foreach (var sum in numbers)
            {
                i = i + sum;

            }
            if (i == 0)
            {
                return 0;
            }

            else
            {
                return i;
            }
        }


        public int Subnums(int[] numbers)
        {
            int i = 0;
            foreach (var sum in numbers)
            {
                i = (-sum) + (-i);

            }
            if (i == 0)
            {
                return 0;
            }

            else
            {
                return i;
            }
        }

        public int MultiNum(int[] numbers)
        {
            int i = 0;
            foreach (var sum in numbers)
            {
                i = (sum) * (i);

            }
            if (i == 0)
            {
                return 0;
            }
            else
            {
                return i;
            }


        }

        public int DividNum(int[] numbers)
        {
            int i = 0;
            foreach (var sum in numbers)
            {
                i = i / sum;

            }
            if (i==0)
            {
                return 0;
            }
            else
            {
                return i;
            }
        }

        public int FactNum(int[] numbers)
        {
            throw new NotImplementedException();
        }


    }
}

