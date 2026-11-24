namespace StrokeSense.Contracts;

public interface IRiskClassifier
{
    Task<RiskResultDto> ClassifyAsync(Stream audioStream, CancellationToken ct = default);
}

public class RiskResultDto
{
    public string Label { get; set; } = "low"; // low | moderate | elevated
    public double Confidence { get; set; }
    public int Score { get; set; } // 0-10
}