using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanOverloadingMathod
{
    internal class Numbers
    {
        private int number1;
        private int number2;
        public int FindMinimum(int number1, int number2)
        {
            int result = 0;
            if (number1 < number2)
            {
                result = number1;
            } else
            {
                result = number2;
            }
            return result;
        }
        public int FindMinimum(int number1, int number2, float number3)
        {
            float result = 0;
            if (number1 < number2 && number1 < number3)
            {
                result = number1;
            } else if(number2 < number1 && number2 < number3)
            {
                result = number2;
            }
            else if (number3 < number1 && number3 < number2)
            {
                result = number3;
            }
            return (int)result;
        }
        public int FindMaximum(int number1, int number2)
        {
            int result = 0;
            if (number1 > number2)
            {
                result = number1;
            }
            else
            {
                result = number2;
            }
            return result;
        }
        public int FindMaximum(int number1, int number2, float number3)
        {
            float result = 0;
            if (number1 > number2 && number1 > number3)
            {
                result = number1;
            }
            else if (number2 > number1 && number2 > number3)
            {
                result = number2;
            }
            else if (number3 > number1 && number3 > number2)
            {
                result = number3;
            }
            return (int)result;
        }
    }
}
