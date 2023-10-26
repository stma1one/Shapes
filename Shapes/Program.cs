namespace Shapes
{
    internal class Program
    {

        
        public static Shape MaxShapeArea(Shape[] shapes)
        {
            double maxArea;
            Shape maxShape = shapes[0];
            if (shapes[0] is Circle) { maxArea = ((Circle)shapes[0]).Area(); }
            else
                maxArea = ((Rectangle)shapes[0]).Area();
            for(int i=1; i<shapes.Length; i++)
            {
                if (shapes[i] is Circle && ((Circle)shapes[i]).Area() > maxArea)
                {
                    maxArea = ((Circle)shapes[i]).Area();
                    maxShape = shapes[i];
                }
                else if (shapes[i] is Rectangle && ((Rectangle)shapes[i]).Area() > maxArea)
                {
                    maxArea = ((Rectangle)shapes[i]).Area();
                    maxShape = shapes[i];
                }

            }
            return maxShape;
        }
        static void Main(string[] args)
        {
            #region שימוש בבנאים
            //שימוש בבנאים השונים
            Circle c1 = new Circle(4, "red");
            Circle c2 = new Circle(4, "Circle", "Red");
            Square sq = new Square(5, "Brown");
            #endregion

            #region הצבעה
            // הורה (כל מחלקת בסיס) יכולה להצביע על אובייקטים ממחלקות יורשות
            //ההצבעה יכולה להיות על אובייקט חדש
            Shape s = new Circle(6, "Green");
            
            //או אובייקט קיים
            Shape square = sq;
            #endregion

            #region זימון פעולות
            //הפניה יכולה לזמן רק פעולות של הטיפוס שלה בלבד
            //נסיון לזמן פעולה שקיימת רק במחלקה יורשת תוביל לשגיאת קומפילציה
            // square.Area();
            #endregion


            #region מערך של צורות
            //ניתן ליצור מערך של צורות שונות. הטיפוס של המערך הוא טיפוס הורה המשותף
            Shape[] shapes = new Shape[3];
            shapes[0] = c1;
            shapes[1] = sq;
            shapes[2] = new Rectangle(5, 4, "Yellow");
            #endregion

            #region המרה כלפי מטה
            Circle c3 = (Circle)shapes[0];
            Square sq1= (Square)shapes[1];
            Console.WriteLine(c3.Area());
            Rectangle r = (Square)shapes[1];
            #endregion

            //שגיאה בזמן ריצה
           // Square square2 = (Square)shapes[0];

             #region is המרה בטוחה על שימוש ב
            for (int i=0;i<shapes.Length;i++)
            {
                if (shapes[i] is  Rectangle)
                {
                    //חובה לבצע המרה גם אחרי 
                    //is
                    Console.WriteLine( ((Rectangle)shapes[i]).GetHeight());
                }
                if (shapes[i] is Circle)
                {
                    Circle c4= (Circle)shapes[i];   
                    Console.WriteLine(c4.GetRadius());
                }
            }
            #endregion



           Shape max=MaxShapeArea(shapes);
           if(max is Circle)
                Console.WriteLine(((Circle)max).Area());
           else
            {
                Rectangle maxr= (Rectangle)max;
                Console.WriteLine(maxr.Area());
            }

         
    }
    
}