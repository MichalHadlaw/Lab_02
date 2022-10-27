namespace WebApplication1.Serwices.LAB3
{
    public class rectangle: Shape
    {
        public rectangle(int width, int height)
        {
            Width = width;
         Height = height;

        }

        public static int operator +(rectangle a, rectangle b)
        {
            var result = new rectangle(a.Width + b.Width, a.Height + b.Height);
            return result.GetArea();
        }
    }
}
