namespace Domain.Entities.App.Social;

public sealed class SiteSocialEntity
{
    public string? TwitterUrl { get; private set; }
    public string? LinkedInUrl { get; private set; }
    public string? GitHubUrl { get; private set; }
    public string? InstagramUrl { get; private set; }
    public string? YouTubeUrl { get; private set; }
    public string? DiscordUrl { get; private set; }
    public string? TelegramUrl { get; private set; }
    public string? FacebookUrl { get; private set; }

    public SiteSocialEntity() { }
}