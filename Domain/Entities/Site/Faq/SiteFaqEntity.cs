namespace Domain.Entities.Site.Faq;

public sealed class SiteFaqEntity
{
    public Guid Id { get; } = Guid.NewGuid();

    public string Question { get; private set; } = string.Empty;
    public string Answer { get; private set; } = string.Empty;
    public string? Category { get; private set; }
    public bool IsVisible { get; private set; } = true;
    public int DisplayOrder { get; private set; }

    public DateTimeOffset CreatedAt { get; }
    public DateTimeOffset? UpdatedAt { get; private set; }

    private SiteFaqEntity() { }

    public SiteFaqEntity(
        string question,
        string answer,
        int displayOrder,
        string? category = null)
    {
        Question = question.Trim();
        Answer = answer.Trim();
        DisplayOrder = displayOrder;
        Category = category?.Trim();
        CreatedAt = DateTimeOffset.UtcNow;
    }
}