public class DrawingContext
{
    public int Pen { get; set; } = 1;
    public bool IsPenDown { get; set; } = false;
    public int X { get; set; } = 0;
    public int Y { get; set; } = 0;

    public void Move(int dx, int dy)
    {
        X += dx;
        Y += dy;
        if (IsPenDown)
        {
            Console.WriteLine($"Drawing to ({X},{Y}) with pen {Pen}");
        }
        else
        {
            Console.WriteLine($"Moving to ({X},{Y}) without drawing");
        }
    }
}