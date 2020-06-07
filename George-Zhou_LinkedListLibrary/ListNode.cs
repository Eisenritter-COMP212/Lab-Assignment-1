using System;
using System.Collections.Generic;
using System.Text;

namespace George_Zhou_LinkedListLibrary
{
    // class to represent one node in a list
         // We are now convertiong our linkedList to generic LinkedList
        class ListNode<T> // Add an angle <>, in the angle bracket add a typeholder
        {
            // automatic read-only property Data
            public T Data { get; private set; }

            // automatic property Next
            public ListNode<T> Next { get; set; }

            // constructor to create ListNode that refers to dataValue
            // and is last node in list
            public ListNode(T dataValue) : this(dataValue, null) { }

            // constructor to create ListNode that refers to dataValue
            // and refers to next ListNode in List
            public ListNode(T dataValue, ListNode<T> nextNode)
            {
                Data = dataValue;
                Next = nextNode;
            }

        }
}
