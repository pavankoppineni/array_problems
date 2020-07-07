using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems.FindDuplicateNumbersInArray
{
    /// <summary>
    /// https://www.geeksforgeeks.org/find-duplicates-in-on-time-and-constant-extra-space/
    /// </summary>
    public class FindDuplicateNumbersInArrayV1
    {
        public ISet<int> FindDuplicateNumbers(int[] numbers)
        {
            var duplicateNumbers = new HashSet<int>();

            for (var i = 0; i < numbers.Length; i++)
            {
                var value = Math.Abs(numbers[i]);
                if (numbers[value] >= 0)
                {
                    numbers[value] = -1 * numbers[value];
                }
                else
                {
                    duplicateNumbers.Add(value);
                }
            }

            return duplicateNumbers;
        }
    }
}
