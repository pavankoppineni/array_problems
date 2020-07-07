using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems.RunningMedian.Heaps
{
    /// <summary>
    /// https://www.geeksforgeeks.org/median-of-stream-of-integers-running-integers/
    /// </summary>
    public class RunningMedianProblemUsingHeapsV1
    {
        private readonly MinHeap minHeap;
        private readonly MaxHeap maxHeap;
        private double currentMedian;

        public RunningMedianProblemUsingHeapsV1(int capacity)
        {
            minHeap = new MinHeap(capacity);
            maxHeap = new MaxHeap(capacity);
        }

        public double[] FindRunningMedian(int[] values)
        {
            var runningMedianQueue = new double[values.Length];
            for (var i = 0; i < values.Length; i++)
            {
                CalculateMedian(values[i]);
                runningMedianQueue[i] = currentMedian;
            }
            return runningMedianQueue;
        }

        private void CalculateMedian(int value)
        {
            // Value is greater than current median, then add value to min heap
            if (value > currentMedian)
            {
                // Size of both heaps are equal
                if (minHeap.Length == maxHeap.Length)
                {
                    minHeap.Add(value);
                    currentMedian = minHeap.Peek();
                }
                // Min heap size is less than max heap
                else if (minHeap.Length < maxHeap.Length)
                {
                    minHeap.Add(value);
                    currentMedian = (minHeap.Peek() + maxHeap.Peek()) / 2.0;
                }
                // Min heap size is greated than max heap
                else
                {
                    var minHeapValue = minHeap.RemoveFront();
                    maxHeap.Add(minHeapValue);
                    minHeap.Add(value);
                    currentMedian = (minHeap.Peek() + maxHeap.Peek()) / 2.0;
                }
            }
            // Value is less than current median, then add value to max heap
            else
            {
                if (minHeap.Length == maxHeap.Length)
                {
                    maxHeap.Add(value);
                    currentMedian = maxHeap.Peek();
                }
                else if (maxHeap.Length > minHeap.Length)
                {
                    var maxHeapValue = maxHeap.RemoveFront();
                    minHeap.Add(maxHeapValue);
                    maxHeap.Add(value);
                    currentMedian = (minHeap.Peek() + maxHeap.Peek()) / 2.0;
                }
                else
                {
                    maxHeap.Add(value);
                    currentMedian = (minHeap.Peek() + maxHeap.Peek()) / 2.0;
                }
            }
        }
    }
}
