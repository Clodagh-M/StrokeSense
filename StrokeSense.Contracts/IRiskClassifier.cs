namespace StrokeSense.Contracts;

public interface IRiskClassifier
{
    Task<RiskResultDto> ClassifyAsync(Stream audioStream, CancellationToken ct = default);
}
