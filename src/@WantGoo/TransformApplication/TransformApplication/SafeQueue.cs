using System;
using System.Collections.Concurrent;

namespace TransformApplication
{
    internal class SafeQueue<T> : ConcurrentQueue<T>
    {
        public event EventHandler Enqueued;

        public new void Enqueue(T item)
        {
            base.Enqueue(item);

            if (this.Enqueued != null)
            {
                this.Enqueued(this, null);
            }
        }
    }
}