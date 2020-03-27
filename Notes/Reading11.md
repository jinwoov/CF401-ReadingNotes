# Stacks and Queues

- Stack is a data structure consists of node and how each node referencing each other to create one link list.


|methods | meaning |
|--------|---------|
| push   |node that are put into the stack |
| pop    |node or item that are popped from the stack|
| top    |top of the stack|
| peek   | view the value on the top of top node in the stack
| IsEmpty| returns true when stack is empty otherwise return false|
| FILO  |  first in last out |
| LIFO  | last in first out |
| Enqueue | adding item to the list|
| Dequeue | remove item from the list |
| Front | This is front Node of the list|
| Reare | this is last Node of the list |
| Peek | view the value of the front Node in the queue. If called when the queue is empty an exception will be raised. |


- Push, pop, peek, IsEmpty are 0(1) methods.

- For enqueue you will need to set the rear next to the added node and then set rear to node

- For dequeue you will need to you will need to set the temp to front then set front to the front next node. Thereafter you will set the next temp to null.

- To peek, you will need to return value of the front and to check if its empty you will need to return front is not equal to null.