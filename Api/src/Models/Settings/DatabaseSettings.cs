namespace Api.src.Models.Settings;

/// <summary>
/// Gets or sets the database settings.
/// </summary>
public class DatabaseSettings
{
    /// <summary>
    /// Gets or sets the connection string for the database.
    /// </summary>
    public string ConnectionString { get; set; } = string.Empty;
}
