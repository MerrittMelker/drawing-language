public class PenDownCommand : IDrawingCommand
{
    public void Execute(DrawingContext context) => context.IsPenDown = true;
}