using System.Collections;
using System.Collections.Generic;

namespace IteratorPattern.Enumerable
{
    public class QueueEnumerable : IEnumerable<string>
    {
        private List<string> _queueName;

        public QueueEnumerable(List<string> queueName)
        {
            this._queueName = queueName;
        }

        public IEnumerator<string> GetEnumerator()
        {
            return _queueName.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}