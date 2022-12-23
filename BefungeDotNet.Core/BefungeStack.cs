namespace BefungeDotNet.Core;

/// <summary>
/// Application stack.
/// </summary>
public class BefungeStack
{
    private readonly Stack<int> _stack = new();

    /// <summary>
    /// Pops char value.
    /// </summary>
    public char PopChar()
    {
        var bt = PopInt();

        return Convert.ToChar(bt);
    }

    /// <summary>
    /// Pops integer value.
    /// </summary>
    public int PopInt()
    {
        return _stack.Pop();
    }

    /// <summary>
    /// Pushes integer value into the stack.
    /// </summary>
    /// <param name="value">Integer value,</param>
    public void Push(int value)
    {
        _stack.Push(value);
    }

    /// <summary>
    /// Pushes char value into the stack.
    /// </summary>
    /// <param name="value">Char value.</param>
    public void Push(char value)
    {
        Push(Convert.ToInt32(value));
    }
}