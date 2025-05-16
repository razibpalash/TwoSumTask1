using TwoSum;

namespace TwoSumTest.Tests;

public class UnitTest
{
    [Fact]
    public void NormalReturns() // normal case
    {
        var sumCal = new TwoSumCal();
        int[] result = sumCal.TwoSum(new[] { 2, 7, 11, 15 }, 9);
        Assert.Equal(new[] { 0, 1 }, result);
    }

    [Fact]
    public void EdgeReturn()
    {
        var sumCal = new TwoSumCal();
        int[] result = sumCal.TwoSum(new[] { 3, 3, 4, 5 }, 6);
        Assert.Equal(new[] { 0, 1 }, result);
    }

    [Fact]
    public void DuplicateReturn()
    {
        var sumCal = new TwoSumCal();
        int[] result = sumCal.TwoSum(new[] { 1, 2, 3, 4 }, 8);
        Assert.Empty(result);
    }

    [Fact]
    public void NoSolutionReturn()
    {
        var sumCal = new TwoSumCal();
        int[] result = sumCal.TwoSum(new[] { 1 }, 2);
        Assert.Empty(result);
    }
}
