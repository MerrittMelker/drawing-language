public class MoveCommand : IDrawingCommand
{
    private readonly int _dx, _dy;
    public MoveCommand(int dx, int dy) => (_dx, _dy) = (dx, dy);
    public void Execute(DrawingContext context) => context.Move(_dx, _dy);
}