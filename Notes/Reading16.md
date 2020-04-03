# Tree

| Term | Definition |
|:-----|:-----------|
|Node | individual item that make up the data structure|
| Root | it is first/top node in the tree|
| Left child | The node that is positioned to the left of the root or node|
| Right child | The node that is positioned to the right of the node or root|
|Edge| the edge in tree is the link between a parent and child node|
|leaf | left doesn't have any childrene|
|height| the height of a tree is determined by the number of edges from the root to the lowest node|

- There are two way to traverse
    1. depth first
    2. breadth first

## Depth first
    - we prioritize going through the depth of the tree first.
    - There are multiple ways to carry out depth first traveral

    ```
    preorder: root -> left -> right
    In-Order: left -> root -> right
    post-Order: left -> right -> root
    ```

- The most common way is recursion to traverse
- This relies on callstack.

```
static value preOrder(root)
{
    if (root.left != null)
        preOrder(root.left)  <-- recursion

    if (root.right != null)
        preOrder(root.Right) <-- recursion
}
```

- when above method is invoked, `root` is added to the bottom of the stack
- This recursive method will traverse until bottom of the tree and pop from the stack as it come back to the root as it outputs the value.
- Once the leaf is reached and traveled back up, it will move to the right side of the edge and traverse down to up
- The reason why the preOrder, inOrder, post Order is that return node.Value is located from beginnning, middle, and at end, respectively.


## Breath First

- This technique traverse through the tree by going through each level of the tree-node-by-node.
- As it traverse it will first get the node where conversion happens and adds to the queue which then adds following nodes. Following that queue is dequeued.

**The perfect binary tree is when non-leaf node has exactly two children. The maximum with is 2 to the (h-1) power**
    - h in this case height of the tree.