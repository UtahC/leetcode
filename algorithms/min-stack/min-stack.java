public class MinStack {
    
    int[] arr = new int[10000];
    int nowIndex = -1;
    /** initialize your data structure here. */
    public MinStack() {
        
    }
    
    public void push(int x) {
        arr[++nowIndex] = x;
    }
    
    public void pop() {
        if (nowIndex >= 0) {
            arr[nowIndex] = 0;
            nowIndex--;
        }
    }
    
    public int top() {
        return arr[nowIndex];
    }
    
    public int getMin() {
        int temp = Integer.MAX_VALUE;
        for (int i = 0; i <= nowIndex; i++) {
            if (temp >= arr[i])
                temp = arr[i];
        }
        return temp;
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.push(x);
 * obj.pop();
 * int param_3 = obj.top();
 * int param_4 = obj.getMin();
 */