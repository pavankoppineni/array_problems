using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrayProblems.FindThePointWhereMaximumIntervalsOverlap
{
    /// <summary>
    /// https://www.geeksforgeeks.org/find-the-point-where-maximum-intervals-overlap/
    /// </summary>
    public class FindThePointWhereMaximumIntervalsOverlapV1
    {
        public int Find(int[] inTimeValues, int[] outTimeValues)
        {
            var min = inTimeValues.Min();
            var max = outTimeValues.Max();

            var intervals = new int[max];
            foreach(var inTime in inTimeValues)
            {
                intervals[inTime - 1] += 1;
            }

            foreach(var outTime in outTimeValues)
            {
                intervals[outTime - 1] -= 1;
            }

            return MaximumInterval(intervals);
        }

        private int MaximumInterval(int[] intervals)
        {
            var maxPeople = 0;
            var numberOfPeople = 0;
            var maxInterval = 0;
            for (var i = 0; i < intervals.Length; i++)
            {
                numberOfPeople += intervals[i];
                if (numberOfPeople > maxPeople)
                {
                    maxInterval = i;
                    maxPeople = numberOfPeople;
                }
            }

            return maxInterval + 1;
        }
    }
}
