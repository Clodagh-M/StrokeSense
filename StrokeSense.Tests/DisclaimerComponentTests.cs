using Bunit;
using Shouldly;
using StrokeSense.UI.Components.Pages;

namespace StrokeSense.Tests;

public class DisclaimerComponentTests : TestContext
{
    [Fact]
    public void Disclaimer_ShowsContinueButton_WhenNotAcknowledged()
    {
        // Arrange
        var cut = Render<DisclaimerGate>(parameters => parameters
            .Add(p => p.OnAcknowledged, () => { }));

        // Assert
        cut.Find("button").TextContent.ShouldContain("continue");
    }
}