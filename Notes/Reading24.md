# Hash Tables
- Hash taking the string and converting it to values that can be used for security reason. 
    - for the hashtable, it is used for indx of array
- Bucket is like element in the array and each index is a bucket. 
- Collision is when more than one key gets hashed to the same location
- it is used often for hold unique values, dictionary, liberty
- Hash has key and value
- Hashtable is used to store key and be able to quickly retrieve the value. 
- `Hash` is way of encoding the key that will eventually point to specific position so we can directly get the value.
- Usually hashtable is O(1) time complexity
- using the loop tofind a value is O(n) operation since multiple keys are searched to find the specific value.
- Hash takes a key and return a integer of where it is
- Way to create a hash
```
Add or multiply all the ASCII values together.
Multiply it by a prime number such as 599.
Use modulo to get the remainder of the result, when divided by the total size of the array.
Insert into the array at that index.
```
When there is no entry in the specific bucket , it starts with `null`
- Perfect hash will never have collision
- When there is same hash was assigned to two different key, this is called collision.
- if two key does have collision, use `.Add(key,val)`
- Hash Map does this to store value
    - accepts a key, calculate the hash of the key, use modulus to convert the hash into an array index and store the key with the value by appending both to the end of the linked list.
- Has maps reads by
    - accepts a key,calculate the hash, use % to conver the hash into an index, this is then used to access the short linkedlist  that represent bucket and search through the bucket looking for a node with key/value
- There are three methods to hashtable
    - `Add()` adds new key/value to the hashtable
    - `find()` takes key and get the hash
    - `contains()`, accept a key and returns boolean if it exists in the hashtable
    - `gethash()` accepts key as string and create hash then return the index of the array.