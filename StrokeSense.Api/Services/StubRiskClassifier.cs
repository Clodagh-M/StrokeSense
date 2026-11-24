using StrokeSense.Contracts;

namespace StrokeSense.Api.Services;

public class StubRiskClassifier : IRiskClassifier
{
    public async Task<RiskResultDto> ClassifyAsync(Stream audioStream, CancellationToken ct = default)
    {
        // Simulate processing time
        await Task.Delay(500, ct);

        // Stub returns a fixed result for prototype
        return new RiskResultDto
        {
            Label = "low",
            Confidence = 0.75,
            Score = 2
        };
    }
}