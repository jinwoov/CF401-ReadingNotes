using System;
using System.Collections.Generic;
using System.Text;

namespace Linkedlist.Node
{
    public class LinkList
    {
        public Node head = null;

        public void Insert(int num)
        {
            Node node = new Node();

            node.value = num;

            node.Next = head;

            head = node;
        }

        public bool Includes(int value)
        {
            // set c = h;

            Node current = head;
            // while current is not equal to null
            while (current != null)
            {

                // check if value is equal

                if (current.value == value)
                {
                    return true;
                }
                current = current.Next;
            }
            // go to the next node

            // check if value = 30

            // if so return true
            return false;
        }
    }
}
