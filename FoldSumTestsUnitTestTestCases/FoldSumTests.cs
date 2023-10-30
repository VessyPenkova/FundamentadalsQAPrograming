
namespace FoldSumTestsUnitTestTestCases;


public class FoldSumTests
{
    [TestCase(new int[] { 1, 2, 3, 4 }, "1234")]
    [TestCase(new int[] { 4, 3, 2, 1 }, "4321")]
    [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7 }, "2134576")]
    [TestCase(new int[] { 2, 1, 3, 4, 5, 7, 6 }, "1234567")]
    [TestCase(new int[] { 4, 3, 2, 1, 5, 6, 7, 8, 9, 10, 11, 12, 16, 15, 14, 13 }, "12345678910111213141516")]
    [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, "43215678910111216151413")]

    public void Test_FoldArray_ReturnsCorrectString(int[] arr, string expected)
    {
        //Arrange

        //Act

        //Assert
    }
}
