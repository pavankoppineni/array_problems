using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems.RunningMedian.Heaps
{
    public class MinHeap : BaseHeap
    {
        public MinHeap(int capacity) : base((value, currentMaxValue) => value < currentMaxValue, capacity)
        {
        }

        protected override void Heapify(int index)
        {
            var currentIndex = index;
            var currentValue = values[currentIndex];

            var rightChild = 2 * index + 1;
            var leftChild = 2 * index + 2;

            if (leftChild < values.Count)
            {
                if (values[leftChild] < currentValue)
                {
                    currentValue = values[leftChild];
                    currentIndex = leftChild;
                }
            }

            if (rightChild < values.Count)
            {
                if (values[rightChild] < currentValue)
                {
                    currentValue = values[rightChild];
                    currentIndex = rightChild;
                }
            }

            if (index == currentIndex)
            {
                return;
            }

            var temp = values[currentIndex];
            values[currentIndex] = values[index];
            values[index] = temp;
        }
    }
}
