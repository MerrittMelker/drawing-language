using System;
using System.Collections.Generic;

public class DrawingCommandParser
{
    private readonly Dictionary<string, Func<string?, IDrawingCommand>> _commandMap;

    public DrawingCommandParser()
    {
        _commandMap = new Dictionary<string, Func<string?, IDrawingCommand>>
        {
            ["P"] = arg => new PenCommand(int.Parse(arg!)),
            ["D"] = _ => new PenDownCommand(),
            ["U"] = _ => new PenUpCommand(),
            ["N"] = arg => new MoveCommand(0, int.Parse(arg!)),
            ["S"] = arg => new MoveCommand(0, -int.Parse(arg!)),
            ["E"] = arg => new MoveCommand(int.Parse(arg!), 0),
            ["W"] = arg => new MoveCommand(-int.Parse(arg!), 0)
        };
    }

    public List<IDrawingCommand> Parse(string input)
    {
        var tokens = input.Split(new[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
        var commands = new List<IDrawingCommand>();

        for (int i = 0; i < tokens.Length; i++)
        {
            var cmd = tokens[i];
            if (!_commandMap.ContainsKey(cmd))
                throw new Exception($"Unknown command: {cmd}");

            var requiresArg = cmd is "P" or "N" or "S" or "E" or "W";
            var arg = requiresArg ? tokens[++i] : null;
            commands.Add(_commandMap[cmd](arg));
        }

        return commands;
    }
}