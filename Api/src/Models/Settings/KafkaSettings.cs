namespace Api.src.Models.Settings;

/// <summary>
/// Gets or sets the Kafka settings.
/// </summary>
public class KafkaSettings
{
    /// <summary>
    /// Gets or sets the bootstrap servers for the Kafka cluster.
    /// </summary>
    public string BootstrapServers { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the topic for the Kafka cluster.
    /// </summary>
    public string Topic { get; set; } = string.Empty;
}
