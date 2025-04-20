using System;

class Program
{
    static void Main()
    {
        var parser = new DrawingCommandParser();
        var context = new DrawingContext();

        string input = @"
            P 2
            D
            W 2
            N 1
            E 2
            S 1
            U
        ";

        var commands = parser.Parse(input);
        foreach (var cmd in commands)
            cmd.Execute(context);
    }
}