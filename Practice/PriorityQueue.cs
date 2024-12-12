namespace Coding_Practice.Practice
{
    class MinComparer : IComparer<int>
    {
        public int Compare(int x, int y) => x.CompareTo(y);
    }

    public class PriorityQueue<T>
    {
        List<(T Value, int Priority)> Heap;
        IComparer<int> _comparer;

        public PriorityQueue(IComparer<int> comparer)
        {
            Heap = new List<(T Value, int Priority)> ();
            _comparer = comparer;
        }

        public bool IsEmpty()
        {
            return Heap.Count == 0;
        }

        public void Swap(int i, int j)
        {
            (Heap[i], Heap[j]) = (Heap[j], Heap[i]);
        }

        public int Count => Heap.Count;

        public void EnQueue(T value, int priority)
        {
            Heap.Add((value, priority));
            HeapifyUp(Count - 1);
        }

        private void HeapifyUp(int index)
        {
            while (index > 0)
            {
                int parentIndex = (index - 1) / 2;

                if (_comparer.Compare(Heap[parentIndex].Priority, Heap[index].Priority) <= 0)
                {
                    break;
                }

                Swap(index, parentIndex);
                index = parentIndex;
            }
        }

        public T DeQueue()
        {
            T first = Heap[0].Value;

            Heap[0] = Heap[Count - 1];
            Heap.RemoveAt(Count - 1);

            HeapifyDown(0);

            return first;
        }


        private void HeapifyDown(int index)
        {
            int lastIndex = Count - 1;

            while (true)
            {
                int leftChild = index * 2 + 1;
                int rightChild = index * 2 + 2;
                int minChild = (rightChild < Count && _comparer.Compare(rightChild, leftChild) < 0)  ?
                    rightChild : leftChild;
                if(_comparer.Compare(index, minChild) <= 0)
                {
                    break;
                }

                Swap(index, minChild);
                index = minChild;
            }
        }

        public T Peek()
        {
            if(Heap.Count == 0)
            {
                throw new Exception("No data in heap");
            }

            return Heap[0].Value;
        }
    }
}
