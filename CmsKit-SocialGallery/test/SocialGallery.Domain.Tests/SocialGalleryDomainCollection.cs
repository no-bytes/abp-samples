using SocialGallery.MongoDB;
using Xunit;

namespace SocialGallery
{
    [CollectionDefinition(SocialGalleryTestConsts.CollectionDefinitionName)]
    public class SocialGalleryDomainCollection : SocialGalleryMongoDbCollectionFixtureBase
    {

    }
}