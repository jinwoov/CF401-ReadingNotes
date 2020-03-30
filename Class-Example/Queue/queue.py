#Queue

# FIFO first in first out

# LILO last in last out

class Queue:
    
    def _init__(self):
        self.front = None
        self.rear = None

    def enqueue(self, value):
        node = Node(value)

        if not self.rear:
            self.rear = node
        else:

        self.rear.next = node

        self.rear = node


    def dequeue(self):
        if not self.front:
            raise IndexErorr("you suck")

        temp = self.front

        self.front = self.front.next

        temp.next = None #grbage colleted

        return temp.value #orange



    def peek(self):
        if not self.front:
            raise IndexError("you suck")

        return self.front.value
    
    def is_empty(self):
        return self.front == None

# for stack you can't 

#  stack is powerful becuase they are simpler

#  queue 