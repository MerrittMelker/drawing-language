public class PenCommand : IDrawingCommand
{
    private readonly int _pen;
    public PenCommand(int pen) => _pen = pen;
    public void Execute(DrawingContext context) => context.Pen = _pen;
}