using BefungeDotNet.Core.Pointer;

namespace BefungeDotNet.Tests;

[TestFixture]
[TestOf(typeof(InstructionPointer))]
public class PointerTests
{
    [SetUp]
    public void Setup()
    {
        _pointer = new InstructionPointer(10, 10);
    }

    private InstructionPointer _pointer = null!;

    [Test]
    [TestCase(PointerDirection.Right, 5, 5, 0)]
    [TestCase(PointerDirection.Right, 10, 0, 0)]
    [TestCase(PointerDirection.Bottom, 5, 0, 5)]
    [TestCase(PointerDirection.Bottom, 10, 0, 0)]
    [TestCase(PointerDirection.Left, 3, 7, 0)]
    [TestCase(PointerDirection.Top, 3, 0, 7)]
    public void MoveOneDirection(PointerDirection direction, int amount, int targetX, int targetY)
    {
        _pointer.CurrentDirection = direction;

        Move(amount);

        Assert.Multiple(() =>
        {
            Assert.That(_pointer.X, Is.EqualTo(targetX));
            Assert.That(_pointer.Y, Is.EqualTo(targetY));
        });
    }

    [Test]
    public void MoveCustom()
    {
        Move(5);
        _pointer.CurrentDirection = PointerDirection.Bottom;
        Move(2);
        _pointer.CurrentDirection = PointerDirection.Right;
        Move(1);
        
        Assert.Multiple(() =>
        {
            Assert.That(_pointer.X, Is.EqualTo(6));
            Assert.That(_pointer.Y, Is.EqualTo(2));
        });
    }
    
    private void Move(int amount)
    {
        for (var i = 0; i < amount; i++)
        {
            _pointer.Move();
        }
    }
}