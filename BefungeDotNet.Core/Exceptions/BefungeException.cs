namespace BefungeDotNet.Core.Exceptions;

/// <summary>
/// Base class for all Befunge exceptions.
/// </summary>
public abstract class BefungeException : Exception
{
    protected BefungeException(string message)
        : base(message)
    {
    }

    protected BefungeException(string message, Exception inner)
        : base(message, inner)
    {
    }
}