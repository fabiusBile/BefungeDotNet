namespace BefungeDotNet.Core.Instructions;

/// <summary>
/// Interface for Befunge language instructions.
/// </summary>
public interface IInstruction
{
    void Execute(char value);
}