```cs

class Node
{
    public int Value;
    public Node Next;
}


class list
{
    public void Traversal(Node head)
    {
        public Node current = head;

        while(current != null){
            Console.WriteLine(current.value);
            current = current.next;

        }
    }
}

```

- data structure
    - abstract represetation of real word information organization
        - pattern found to be useful in holding info
        - leave out unneeded deetails
        - include only common element
    - some general solution are especially useful in computing
        - string, arrays, linked lists, stacks, queue
        - hashmap, tree, graph

- tree
    - hierachical pattern
    - branching pattern
    - parent child pattern

- root: The node on tree that doesn't have in income node.
    - think of this as beinning of your treee
- Edge: The connection between nodes and there is only one incoming and multiple outgoing
    - the 'link' / connection between the nodes.

- Properties of Tree nodes
    - Leftchild ,Rightchild : some outoging reference to the another node
    - typically left value is less than right values

- leaf: node without any outgoing connections
    - no child

- height: maximum level at any node within the tree
    - level: the number of level 
    - path: a list of nodes, leading to the target node

- parent: a node with an outgoing edge.
    - child:a node with a incoming edge
    - siblings: nods that share the same parent
-

```cs


class Node
{
    public Node Left;
    public Node right;
    public int Value;

    public Node(int value){
        this.Value = value;
    }

    public void display()
    {
        Console.WriteLine(Value);
    }
}

class BinarySearchTree
{
    public Node Root;

    public Node Insert(Node root, int value)
    {
        if (root == null)
        {
            root = new Node();
            root.Value = value;
        }
        else if (value < root.Value)
        {
            root.left = insert(root.Left, value);
        }
        else
        {
            root.right = insert(root.Right, value);
        }

        this.Root = root
        return this.Root;

        // Node Current = root;
        // // we want to check if this root is a thing
        // while(Current != null)
        // {
        //     // 2 paths => current.leftNode && current.RightNode

        //     if (value > Current.Value)
        //     {
        //         Current.RightNode= new Node();
        //         Current.RightNode.Value = value;
        //     }
        //     else
        //     {
        //         Current.LeftNode

        //     }

        //     Current = new Node();
        //     Current.Value = value;

        // }

        // whats the vluae
    }
    public void Traveral(Node root)
    {
        if (root == null)
        {
            return;
        }
        root.display();

        traversal(root.Left);
        traversal(root.Right);
    }
}

class Program
{
    static void Main()
    {
        BinarySearchTree tree = new BinarySearchTree();

        tree.Root = new Node();
        tree.Root.Value 3;
        

        tree.insert(tree.Root, 4)

        // works but not programmatic, how can we add things to this tree?
        tree.Root.Left = new Node();
        tree.Root.Left.Value = 4;
        tree.Root.Right = new Node();

        tree.Root.Right.Value = 5;

    }
}

```