public class PenUpCommand : IDrawingCommand
{
    public void Execute(DrawingContext context) => context.IsPenDown = false;
}