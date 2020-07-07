using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems.FindIfArrayHasDuplicteNumbers
{
    public class FindIfArrayHasDuplicateNumbersV1
    {
        public bool DoesArrayHasDuplicateNumbers(int[] numbers)
        {
            var i = 0;
            foreach (var number in numbers)
            {
                if ((i & (1 << number)) > 0)
                {
                    return true;
                }
                else
                {
                    i = i | 1 << number;
                }
            }
            return false;
        }
    }
}
