public class Solution {
    class Rect {
        public Point p1 {get; private set;}
        public Point p2 {get; private set;}
        public int width;
        public int height;
        public int area;
        
        public Rect(Point p1, Point p2) {
            this.p1 = p1;
            this.p2 = p2;
            this.width = Math.Abs(p1.x - p2.x);
            this.height = Math.Abs(p1.y - p2.y);
            this.area = width * height;
        }
        
        public bool isIntersectWith(Rect that, out bool isThisLeft, out bool isThisTop) {
            isThisLeft = false;
            isThisTop = false;
            bool horizontal = false;
            bool vertical = false;
            if (this.p1.x <= that.p1.x)
                isThisLeft = true;
            if (this.p1.y >= that.p1.y)
                isThisTop = true;
            if (isThisLeft) {
                if (this.p2.x > that.p1.x)
                    horizontal = true;
            }
            else {
                if (this.p1.x < that.p2.x)
                    horizontal = true;
            }
            if (isThisTop) {
                if (this.p1.y < that.p2.y)
                    vertical = true;
            }
            else {
                if (this.p2.y > that.p1.y)
                    vertical = true;
            }
            return horizontal && vertical;
        }
        
        public int intersectAreaWith(Rect that) {
            bool isThisLeft, isThisTop;
            if (!isIntersectWith(that, out isThisLeft, out isThisTop))
                return 0;
            int innerWidth, innerHeight;
            if (isThisLeft)
                innerWidth = this.p2.x - that.p1.x;
            else
                innerWidth = that.p2.x - this.p1.x;
            if (isThisTop)
                innerHeight = that.p2.y - this.p1.y;
            else
                innerHeight = this.p2.y - that.p1.y;
            if (innerWidth > this.width && this.width < that.width)
                innerWidth = this.width;
            else if (innerWidth > that.width && that.width < this.width)
                innerWidth = that.width;
            if (innerHeight > this.height && this.height < that.height)
                innerHeight = this.height;
            else if (innerHeight > that.height && that.height < this.height)
                innerHeight = that.height;

            int innerArea = innerWidth * innerHeight;
            if (innerArea > this.area && this.area < that.area)
                return this.area;
            else if (innerArea > that.area && this.area > that.area)
                return that.area;
            return innerArea;
            
        }
    }
    public int ComputeArea(int A, int B, int C, int D, int E, int F, int G, int H) {
        //solution1
        /* 
        var rect1 = new Rect(new Point(A, B), new Point(C, D));
        var rect2 = new Rect(new Point(E, F), new Point(G, H));
        return rect1.area + rect2.area - rect1.intersectAreaWith(rect2);
        */
        //solution2
        int left = Math.Max(A, E), right = Math.Max(Math.Min(C, G), left);
        int bottom = Math.Max(B, F), top = Math.Max(Math.Min(D, H), bottom);
        return (C - A) * (D - B) + (G - E) * (H - F) - (right - left) * (top - bottom);
    }
}