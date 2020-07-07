using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ArrayProblems.RunningMedian.Heaps
{
    public abstract class BaseHeap
    {
        protected readonly IList<int> values;
        private readonly Func<int, int, bool> predicate;

        protected BaseHeap(Func<int, int, bool> predicate, int capacity)
        {
            this.predicate = predicate;
            values = new List<int>(capacity);
        }

        public int Length => values.Count;

        public void Add(int value)
        {
            values.Add(value);
            Heapify();
        }

        public int RemoveFront()
        {
            var fronValue = values[0];
            var lastValue = values[values.Count - 1];
            values[0] = lastValue;
            values.RemoveAt(values.Count - 1);
            Heapify();
            return fronValue;
        }

        public void Heapify()
        {
            if(values.Count == 0)
            {
                return;
            }

            for (var i = (values.Count / 2) - 1; i >= 0; i--)
            {
                Heapify(i);
            }
        }

        public int Peek()
        {
            return values[0];
        }

        protected virtual void Heapify(int index)
        {
            var currentIndex = index;
            var currentValue = values[currentIndex];

            var rightChild = 2 * index + 1;
            var leftChild = 2 * index + 2;

            if (leftChild < values.Count)
            {
                if (predicate(values[leftChild], currentValue))
                {
                    currentValue = values[leftChild];
                    currentIndex = leftChild;
                }
            }

            if (rightChild < values.Count)
            {
                if (predicate(values[rightChild], currentValue))
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
