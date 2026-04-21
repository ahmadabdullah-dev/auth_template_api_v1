using Domain.Entities.App.Branding;
using Domain.Entities.App.Contact;
using Domain.Entities.App.Identity;
using Domain.Entities.App.Legal;
using Domain.Entities.App.Seo;
using Domain.Entities.App.Social;
using Domain.Entities.App.Status;

namespace Domain.Entities.App.Core;

public sealed class SiteEntity
{
    public Guid Id { get; } = Guid.NewGuid();

    public SiteIdentityEntity Identity { get; private set; } = null!;
    public SiteBrandingEntity Branding { get; private set; } = null!;
    public SiteStatusEntity Status { get; private set; } = null!;
    public SiteContactEntity Contact { get; private set; } = null!;
    public SiteSocialEntity Social { get; private set; } = null!;
    public SiteLegalEntity Legal { get; private set; } = null!;
    public SiteSeoEntity Seo { get; private set; } = null!;

    private SiteEntity() { }

    public SiteEntity(
        SiteIdentityEntity identity,
        SiteBrandingEntity branding,
        SiteStatusEntity status,
        SiteContactEntity contact,
        SiteSocialEntity social,
        SiteLegalEntity legal,
        SiteSeoEntity seo)
    {
        Identity = identity;
        Branding = branding;
        Status = status;
        Contact = contact;
        Social = social;
        Legal = legal;
        Seo = seo;
    }
}