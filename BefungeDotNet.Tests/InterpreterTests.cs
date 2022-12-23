namespace BefungeDotNet.Tests;

[TestFixture]
[TestOf(typeof(Interpreter))]
public class InterpreterTests
{
    [Test]
    public void InitTest()
    {
        var program =
            """"
            "!dlroW ,olleH">:v
                           |,<
                           @
            """";
        var interpreter = new Interpreter(program);
    }
}