namespace BefungeDotNet.Core.Pointer;

/// <summary>
/// Pointer of the program.
/// </summary>
public class InstructionPointer
{
    /// <summary>
    /// Height of the program grid.
    /// </summary>
    private readonly int _programHeight;

    /// <summary>
    /// Width of the program grid.
    /// </summary>
    private readonly int _programWidth;

    /// <summary>
    /// Initialize pointer.
    /// </summary>
    /// <param name="programHeight">Height of the program grid.</param>
    /// <param name="programWidth">Width of the program grid.</param>
    public InstructionPointer(int programHeight, int programWidth)
    {
        _programHeight = programHeight;
        _programWidth = programWidth;
        X = 0;
        Y = 0;
        CurrentDirection = PointerDirection.Right;
    }

    /// <summary>
    /// X coordinate of the pointer.
    /// </summary>
    public int X { get; set; }

    /// <summary>
    /// Y coordinate of the pointer.
    /// </summary>
    public int Y { get; set; }

    /// <summary>
    /// Current direction of the pointer.
    /// </summary>
    public PointerDirection CurrentDirection { get; set; }

    /// <summary>
    /// Moves pointer in current direction.
    /// </summary>
    public void Move()
    {
        switch (CurrentDirection)
        {
            case PointerDirection.Right:
                X = X >= _programWidth - 1 ? 0 : X + 1;

                break;
            case PointerDirection.Bottom:
                Y = Y >= _programHeight - 1 ? 0 : Y + 1;

                break;
            case PointerDirection.Left:
                X = X <= 0 ? _programWidth - 1 : X - 1;

                break;
            case PointerDirection.Top:
                Y = Y <= 0 ? _programHeight - 1 : Y - 1;

                break;
        }
    }
}