using System.Collections.Generic;
using System.Threading.Tasks;

namespace ThreadSafeContainers
{
    /// <summary>
    /// Despite the name of the class, it is currently not thread-safe, and is missing use-cases as defined
    /// in the test outline.  Some methods may also be missing basic input and output validation that should
    /// also be taken into consideration
    /// </summary>
    public sealed class ThreadSafeQueue<T>
    {
        private readonly Queue<T> _queue = new Queue<T>();

        public IEnumerable<T> DequeueAll()
        {
            var list = new List<T>();

            while (_queue.Count > 0)
            {
                list.Add(_queue.Dequeue());
            }

            return list;
        }

        public int Count => _queue.Count;

        public void Enqueue(T value)
        {
            _queue.Enqueue(value);
        }

        public T Dequeue()
        {
            return _queue.Dequeue();
        }
    }
}