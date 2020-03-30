class Stack:
    
    def _int_(self):
        self.top = None


    def is_empty(self):
        return self.top == None
    
    def push(self, value):

        old_top = self.top
        self.top = Node(value)
        self.top.next = old_top
        # if empty
        # if not empty
        # should be 0(1)
        # node = Node(value)
    
        # if not self.top:
        #     self.top = node

        # else:
        #     old_top = self.top
        #     self.top = node
        #     node.next = old_top
        
        self.top = Node(value, self.top)

    def peek(self):

        if not self.top:
            raise IndexError("empty stack")

        return self.top.value

    def pop(self):

        current_top = self.top

        if not self.top:
            raise IndexError("there is no top")
        self.top = self.top.next

        return current_top.value



class Node:
    def _init_(self, value, next_=None):
        self.value = value
        self.next = next_


# class Stack<string>(){

#     private Node top

#     public stack()
#     {
#         //initalize
#     }

#     # Stack()
#     # {
#     #     // do constrctor stuff
#     #     this.top = null;
#     # }

#     public push(string, value)()
#     {
#         Node oldTop = this.top; #head
#         this.top = new Node(value);
#         this.top.next = oldTop;
#     }

#     public bool isEmpty()
#     {
#         return this.top == null;
#     }

# }
