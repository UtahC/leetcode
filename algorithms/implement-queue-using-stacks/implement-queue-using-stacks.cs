public class Queue {
    Stack<int> s1 = new Stack<int>();
    Stack<int> s2 = new Stack<int>();
    
    // Push element x to the back of queue.
    public void Push(int x) {
        int count = s1.Count;
        for (int i = 0; i < count; i++) {
            s2.Push(s1.Pop());
        }
        s1.Push(x);
        for (int i = 0; i < count; i++) {
            s1.Push(s2.Pop());
        }
    }

    // Removes the element from front of queue.
    public void Pop() {
        if (s1.Count == 0)
            throw new Exception();
        s1.Pop();
    }

    // Get the front element.
    public int Peek() {
        return s1.Peek();
    }

    // Return whether the queue is empty.
    public bool Empty() {
        return (s1.Count == 0);
    }
}