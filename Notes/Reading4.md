# Classes & Memory Management


*Garbage Collection*(GC) is a way of memory management. In any application, memory management is very important and usually GC is handling this in the background

Heap and stack is something that related greatly to the GC as once the stack is done GC evaluates and dispose memory that is no longer need.

The data that usually lives in heap is less responsible when it comes to managing memory.

|   |  Heap |  Stack |
|---|---|---|
| What is it?  | Heap is data that is store and can be access at any time. There is no constraint on what or which can be accessed  | This is reponsible for keeping track of what is being excuted.  |
| Difference  | Think of heap as data that can be accessed anytime  | Stack comes off from top to bottom as the data is no longer in usage and been excuted  |
| What is excuting it  | Reference Type  | Value Type(mostly)   |

When the stack created using the values, it will slowly stack on top of each other and when each stack is done, it will bud off, cleaned by GC.

When the values created and set as other int variable. the result of original variable persists same number, however, when the it is referenced and set, value will return 4 since it the original value is **referenced**.

