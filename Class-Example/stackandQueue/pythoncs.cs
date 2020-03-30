 public string peek(self)
 {

        if (top.value == null)
            throw new Exception("you suck");

        return top.value;

 }

public string pop() 
{
        if(top.value == null)
        throw new Exception("you suck");

        Node temp = top

        top = top.next;
        
        temp.next = null;

        temp.dispose();

        return 
}

