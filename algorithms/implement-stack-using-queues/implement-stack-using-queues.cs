public class Stack {
    Queue<int> q1 = new Queue<int>();
    Queue<int> q2 = new Queue<int>();
    
    // Push element x onto stack.
    public void Push(int x) {
        q1.Enqueue(x);
        while (q1.Peek() != x) {
            q2.Enqueue(q1.Dequeue());
            q1.Enqueue(q2.Dequeue());
        }
    }

    // Removes the element on top of the stack.
    public void Pop() {
        if (q1.Count == 0)
            throw new Exception();
        q1.Dequeue();
    }

    // Get the top element.
    public int Top() {
        return q1.Peek();
    }

    // Return whether the stack is empty.
    public bool Empty() {
        if (q1.Count == 0)
            return true;
        return false;
    }
}