namespace Api.src.Models.Settings;

/// <summary>
/// Gets or sets the application settings.
/// </summary>
public class AppSettings
{
    /// <summary>
    /// Gets or sets the name of the application.
    /// </summary>
    public string AppName { get; set; } = string.Empty;

    ///<inheritdoc/>
    public DatabaseSettings Database { get; set; } = new();

    ///<inheritdoc/>
    public KafkaSettings Kafka { get; set; } = new();
}
