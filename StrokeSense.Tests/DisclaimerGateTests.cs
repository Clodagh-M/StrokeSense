using StrokeSense.Contracts;

namespace StrokeSense.Tests;

public class DisclaimerGateTests
{
    [Fact]
    public void Disclaimer_StartsUnacknowledged()
    {
        var disclaimer = new DisclaimerDto();
        Assert.False(disclaimer.Acknowledged);
    }

    [Fact]
    public void Disclaimer_WhenAcknowledged_SetsTimestamp()
    {
        var disclaimer = new DisclaimerDto { Acknowledged = true };
        Assert.True(disclaimer.Acknowledged);
    }
}