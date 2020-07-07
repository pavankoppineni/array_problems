using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems.RunningMedian.Heaps
{
    public class MaxHeap : BaseHeap
    {
        public MaxHeap(int capacity) : base((value, currentMaxValue) => value > currentMaxValue, capacity)
        {
        }
    }
}
