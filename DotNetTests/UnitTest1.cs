namespace DotNetTests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        // Arrange
        int expected = 4;
        int actual = 2 + 2;

        // Act & Assert
        Assert.Equal(expected, actual);
    }
}