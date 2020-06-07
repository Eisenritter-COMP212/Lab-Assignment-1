using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace George_Zhou_QueueInheritanceLibrary
{   // class QueueInheritance inherits List's capabilities
    public class QueueInheritance : George_Zhou_LinkedListLibrary_Framework.List<IComparable>
    {
        // pass name "queue" to List constructor
        public QueueInheritance() : base("queue") { }

        // place dataValue at end of queue by inserting 
        // dataValue at end of linked list
        public void Enqueue(IComparable dataValue)
        {
            InsertAtBack(dataValue);
        }

        // remove item from front of queue by removing
        // item at front of linked list
        public object Dequeue()
        {
            return RemoveFromFront();
        }

        // Get Last Node
        public object GetLast()
        {
            return GetLastNode();
        }
    }
}
