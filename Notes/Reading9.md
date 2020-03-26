# Enumerator types
- The default enumerating type is (E)
- enum can be us to set a mutually excusive value or a combination
- For enum yu can use `|` or `&` operator to reference two value for one
- If selecting enum is out of range, then it will output integer of input rather than what you reference from enum
- Enum.IsDefined is a method to determine whether an enumeration type contains an enu member with contain associated value

# Collection

- two ways to group objects are array and collection.
- array are mostly useful if you use fixed number, however if you aren't sure of the size of elements you will be storing, it good idea to use `collection`.
- If you know what are items that are going to be in the collection, you can initializ as you create the collection  

- Few good method to use for collection

| method      | use case |
| ----------- | ----------- |
| .Add(item)      | to add to collection       |
| .Remove(item)   | to remove from collection        |
| .Sort() | to sort the items |
| .indexOf()| index of item|
| List<T>  | lit of object|
| Queue<T> | repreent FIFO(first in first out)|
| Dictionary | can be used to associate value and key|
| yield return | return each item one at a time|
| yield break | to end the iteration|



