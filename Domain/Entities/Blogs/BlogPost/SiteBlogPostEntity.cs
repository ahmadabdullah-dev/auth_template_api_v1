namespace Domain.Entities.Blogs.BlogPost;



public sealed class SiteBlogPostEntity
{
    public Guid Id { get; } = Guid.NewGuid();

    public string Title { get; private set; } = string.Empty;
    public string Slug { get; private set; } = string.Empty;
    public string Summary { get; private set; } = string.Empty;
    public string Content { get; private set; } = string.Empty;
    public string? CoverImageUrl { get; private set; }
    public string? AuthorName { get; private set; }
    public string? AuthorAvatarUrl { get; private set; }
    public BlogPostStatus Status { get; private set; } = BlogPostStatus.Draft;
    public int ReadTimeMinutes { get; private set; }
    public int ViewCount { get; private set; }
    public DateTimeOffset? PublishedAt { get; private set; }

    public DateTimeOffset CreatedAt { get; }
    public DateTimeOffset? UpdatedAt { get; private set; }

    private SiteBlogPostEntity() { }

    public SiteBlogPostEntity(
        string title,
        string slug,
        string summary,
        string content,
        int readTimeMinutes,
        string? coverImageUrl = null,
        string? authorName = null,
        string? authorAvatarUrl = null)
    {
        Title = title.Trim();
        Slug = slug.Trim().ToLowerInvariant();
        Summary = summary.Trim();
        Content = content.Trim();
        ReadTimeMinutes = readTimeMinutes;
        CoverImageUrl = coverImageUrl;
        AuthorName = authorName?.Trim();
        AuthorAvatarUrl = authorAvatarUrl;
        CreatedAt = DateTimeOffset.UtcNow;
    }
}