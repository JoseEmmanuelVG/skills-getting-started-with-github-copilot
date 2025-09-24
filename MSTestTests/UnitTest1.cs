namespace MSTestTests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        // Arrange
        int expected = 4;
        int actual = 2 + 2;

        // Act & Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestMethod_NullInput_ShouldThrowArgumentNullException()
    {
        // Example edge case test for null input
        string input = null;
        Assert.ThrowsException<ArgumentNullException>(() => input.ToString());
    }

    [TestMethod]
    public void TestMethod_ErrorHandling()
    {
        // Example error handling test
        int[] arr = new int[2];
        Assert.ThrowsException<IndexOutOfRangeException>(() => { var x = arr[5]; });
    }
}