namespace BefungeDotNet.Core;

/// <summary>
/// Grid of the program.
/// </summary>
public class ProgramGrid
{
    private const int MIN_WIDTH = 80;
    private const int MIN_HEIGHT = 25;
    private readonly char[][] _programGrid;

    /// <summary>
    /// Initializes program grid from text;
    /// </summary>
    /// <param name="programText">Text of the program.</param>
    public ProgramGrid(string programText)
    {
        ArgumentException.ThrowIfNullOrEmpty(programText);
        var rawProgramLines = programText.Split("\n").ToList();
        Width = rawProgramLines.MaxBy(e => e.Length)!.Length;

        if (Width < MIN_WIDTH)
        {
            Width = MIN_WIDTH;
        }

        if (rawProgramLines.Count < MIN_HEIGHT)
        {
            var diff = MIN_HEIGHT - rawProgramLines.Count;
            for (var i = 0; i < diff; i++)
            {
                rawProgramLines.Add(new string(' ', Width));
            }
        }

        Height = rawProgramLines.Count;

        _programGrid = rawProgramLines.Select(programLine => programLine.PadRight(Width).ToCharArray()).ToArray();
    }

    /// <summary>
    /// Width of the grid.
    /// </summary>
    public int Width { get; }

    /// <summary>
    /// Height of the grid.
    /// </summary>
    public int Height { get; }

    /// <summary>Returns a string that represents the current object.</summary>
    /// <returns>A string that represents the current object.</returns>
    public override string ToString()
    {
        return string.Join('\n', _programGrid.Select(e => string.Concat(e)));
    }

    /// <summary>
    /// Reads the cell value.
    /// </summary>
    /// <param name="x">X coordinate.</param>
    /// <param name="y">Y coordinate.</param>
    /// <returns>Corresponding character</returns>
    public char ReadCell(int x, int y)
    {
        if (x >= Width)
        {
            throw new ArgumentOutOfRangeException(
                $"Coordinate X of {x} is equal or greater than width of grid ({Width})");
        }

        if (y >= Height)
        {
            throw new ArgumentOutOfRangeException(
                $"Coordinate Y of {y} is equal or greater than height of grid ({Height})");
        }

        return _programGrid[y][x];
    }
}