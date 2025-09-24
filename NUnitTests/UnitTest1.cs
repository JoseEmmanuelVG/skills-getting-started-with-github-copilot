using NUnit.Framework;

namespace NUnitTests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
        // Setup code if needed
    }

    [Test]
    public void Test_Addition_ReturnsCorrectResult()
    {
        // Arrange
        int expected = 4;
        int actual = 2 + 2;

        // Act & Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_NullReference_ThrowsException()
    {
        // Edge case: null reference
        string input = null;
        Assert.Throws<ArgumentNullException>(() => { if (input == null) throw new ArgumentNullException(); });
    }

    [Test]
    public void Test_IndexOutOfRange_ThrowsException()
    {
        // Error handling: index out of range
        int[] arr = new int[2];
        Assert.Throws<IndexOutOfRangeException>(() => { var x = arr[5]; });
    }
}