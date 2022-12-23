using BefungeDotNet.Core.Pointer;

namespace BefungeDotNet.Core;

/// <summary>
/// Befunge interpreter.
/// </summary>
public class Interpreter
{
    private readonly ProgramGrid _grid;
    private readonly InstructionPointer _pointer;

    /// <summary>
    /// Initialize interpreter with the text of the program.
    /// </summary>
    /// <param name="programText">Text of the program.</param>
    public Interpreter(string programText)
    {
        _grid = new ProgramGrid(programText);
        _pointer = new InstructionPointer(_grid.Height, _grid.Width);
    }

    /// <summary>
    /// Starts the program asynchronous.
    /// </summary>
    /// <param name="token">Cancellation token.</param>
    public Task StartAsync(CancellationToken token = default)
    {
        return Task.Run(Start, token);
    }

    /// <summary>
    /// Starts the program.
    /// </summary>
    private void Start()
    {
        while (true)
        {
            var currentChar = _grid.ReadCell(_pointer.X, _pointer.Y);
            _pointer.Move();
        }
    }
}