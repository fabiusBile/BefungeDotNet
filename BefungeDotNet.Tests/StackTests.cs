namespace BefungeDotNet.Tests;

[TestOf(typeof(BefungeStack))]
[TestFixture]
public class StackTests
{
    [SetUp]
    public void SetUp()
    {
        _stack = new BefungeStack();
    }

    private BefungeStack _stack;

    [Test]
    public void PushByteTest()
    {
        Assert.DoesNotThrow(() => _stack.Push(1));
    }

    [Test]
    [TestCase('a')]
    [TestCase('а')]
    public void PushCharTest(char value)
    {
        Assert.DoesNotThrow(() => _stack.Push(value));
    }

    [Test]
    [TestCase(1)]
    [TestCase(1000000)]
    public void PopIntTest(int value)
    {
        _stack.Push(value);
        Assert.That(_stack.PopInt(), Is.EqualTo(value));
    }

    [Test]
    [TestCase('а')]
    [TestCase('a')]
    public void PopCharTest(char value)
    {
        _stack.Push(value);
        Assert.That(_stack.PopChar(), Is.EqualTo(value));
    }
}