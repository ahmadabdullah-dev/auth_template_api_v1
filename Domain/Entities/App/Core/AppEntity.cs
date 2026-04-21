using Domain.Entities.App.Branding;
using Domain.Entities.App.Contact;
using Domain.Entities.App.Identity;
using Domain.Entities.App.Legal;
using Domain.Entities.App.Seo;
using Domain.Entities.App.Social;
using Domain.Entities.App.Status;

namespace Domain.Entities.App.Core;

public sealed class AppEntity
{
    public Guid Id { get; } = Guid.NewGuid();

    public AppIdentityEntity Identity { get; private set; } = null!;
    public AppBrandingEntity Branding { get; private set; } = null!;
    public AppStatusEntity Status { get; private set; } = null!;
    public AppContactEntity Contact { get; private set; } = null!;
    public AppSocialEntity Social { get; private set; } = null!;
    public AppLegalEntity Legal { get; private set; } = null!;
    public AppSeoEntity Seo { get; private set; } = null!;

    private AppEntity() { }

    public AppEntity(
        AppIdentityEntity identity,
        AppBrandingEntity branding,
        AppStatusEntity status,
        AppContactEntity contact,
        AppSocialEntity social,
        AppLegalEntity legal,
        AppSeoEntity seo)
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