namespace Domain.Entities.Site.Document;



public sealed class SiteDocumentEntity
{
    public Guid Id { get; } = Guid.NewGuid();

    public string Title { get; private set; } = string.Empty;
    public string? Description { get; private set; }
    public string FileUrl { get; private set; } = string.Empty;
    public string FileName { get; private set; } = string.Empty;
    public long FileSizeBytes { get; private set; }
    public DocumentType Type { get; private set; }
    public string? Category { get; private set; }
    public bool IsVisible { get; private set; } = true;
    public int DisplayOrder { get; private set; }

    public DateTimeOffset CreatedAt { get; }
    public DateTimeOffset? UpdatedAt { get; private set; }

    private SiteDocumentEntity() { }

    public SiteDocumentEntity(
        string title,
        string fileUrl,
        string fileName,
        long fileSizeBytes,
        DocumentType type,
        int displayOrder,
        string? description = null,
        string? category = null)
    {
        Title = title.Trim();
        FileUrl = fileUrl.Trim();
        FileName = fileName.Trim();
        FileSizeBytes = fileSizeBytes;
        Type = type;
        DisplayOrder = displayOrder;
        Description = description?.Trim();
        Category = category?.Trim();
        CreatedAt = DateTimeOffset.UtcNow;
    }
}