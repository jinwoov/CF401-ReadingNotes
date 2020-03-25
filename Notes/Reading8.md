# Interface

- Interface is a contract that classes sign to belong in a group
- Usual way for creating a interface is that you apply uppercase `I` with naming. 
- As you implement interface, you are basically allowing the properties and method to be applied to your class 
- One of the simple implementation of interface is 

```
Class Dog
{
    public string Name {get;set;}

    public void bark() {};
}


--- in the interface

interface IGoldenDoole
{
    public void DoolePose();
}

--- after creating a interface

using interface

Class Dog : IGoldenDoole
{
    public string Name {get;set;}

    public void DoolePose(){
    Console.WriteLine("I often flip my belly and dance to the floor sometimes!");
    }
}


```
- Above is simple example of how we can implement interface to the class.
- using a interface allow our application to be scalable and also eliminate redundant coding.
- using the above example, you can then group every goldendoole to the interface thus allowing yourself to group them in your program file. 
- This allows you not to group them separately rather than grouping them separately and individually