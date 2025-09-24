using Xunit;

namespace DotNetTests {
    public class TestBasicCases {
        [Fact]
        public void Addition_ReturnsCorrectResult() {
            int expected = 4;
            int actual = 2 + 2;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void NullReference_ThrowsException() {
            string inputValue = null;
            Assert.Throws<ArgumentNullException>(() => ThrowIfNull(inputValue));
        }

        private void ThrowIfNull(string value) {
            if (value == null) throw new ArgumentNullException();
        }

        [Fact]
        public void IndexOutOfRange_ThrowsException() {
            int[] arr = new int[2];
            Assert.Throws<IndexOutOfRangeException>(() => { var _ = arr[5]; });
        }
    }
}
