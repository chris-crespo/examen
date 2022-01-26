using Xunit;

namespace Metaverso;

public class SystemTest
{
    [Theory]
    [InlineData(15, "Metaverso")]
    [InlineData(3, "Meta")]
    [InlineData(5, "Verso")]
    [InlineData(1, "1")]
    public void WithSingleInt(int x, string expected)
    {
        // Given
        var system = new System();

        // When
        var result = system.Metaverso(x);

        // Then
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(new int[] { 1, 2, 3 }, "12Meta")]
    [InlineData(new int[] {}, "")]
    public void WithMultipleInts(int[] xs, string expected)
    {
        // Given
        var system = new System();

        // When
        var result = system.Metaverso(xs);

        // Then
        Assert.Equal(expected, result);
    }
}
