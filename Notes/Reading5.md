# Linked List 

- Linked list is way of storing a memory in our storage and is different from storing it like in an array.
- Unlike array, which data is stored together in block, linked lists are stord dyanmically across the memory and can be access through traversing through each link. 
- Due to its perfect fit in the memory, it can be stored anywhere which memory permits
- For a linked list to access its dat however, it has to traverse through each link until the data is found, whereas the array can access using its indexes.
- When adding the new link to the list, it can be done in three ways.
    - Beginning, middle and end
- When adding the data to the head(beginning), you have to check with condition whether data is there by checking for `null`, and if its not `null`, first newHead has to be connected to the next where head is connected to first, before connecting the head to the newHead.
- This logic of connecting applies to adding inbetween or end.
- Linked List ending is null and when checking for a data in the linked list, it checks until ending is `null`.
- Few types of linked lists are singly, doubly, and circular linked list.
- Singly is connected in one way however doubly connected in both way.
- Linked list contains data and next which will points to next data. Each list can be created by instance of running through the constructor.

ie 
```
public class Node 
{
    public int data;
    public Node next;
    //constructor for Node
    public Node(int i)
    {
        data = i;
        next = null;
    }
    // to print
    public void Print()
    {
        // checking that its not at the last position
        if (next !==null)
        {
            // recursive method
            next.Print();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // instantiating to new object
        Node myNode = new Node(7);
        myNode.next = new Node(4);
        myNode.next.next = new Node(5);
        myNode.next.next.next = new Node(6);

        //priting whats in the my node recursive prints out everything until value is null
        myNode.Print();

    }
}
```