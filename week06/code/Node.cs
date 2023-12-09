public class Node {
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data) {
        this.Data = data;
    }

    public void Insert(int value) {
        if (value < Data) {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }     
        else if (value > Data) {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
        else {
        }    
    }

    public bool Contains(int value) {
        // TODO Start Problem 2
        if (value == Data || Left is not null && Left.Contains(value) || Right is not null && Right.Contains(value)) {
            
            return true;
        }
        return false;
    }
    

    public int GetHeight() {
        // TODO Start Problem 4

        int leftSubtreeHeight = 0;
        int rightSubtreeHeight = 0;
        
        if (Left is not null && Right is not null){
        }

        if (Left is not null) {
            leftSubtreeHeight = Left.GetHeight();
        }

        if (Right is not null) {
            rightSubtreeHeight = Right.GetHeight();
        }

        var height = 1 + Math.Max(leftSubtreeHeight, rightSubtreeHeight);
        
        return height;
    }
}