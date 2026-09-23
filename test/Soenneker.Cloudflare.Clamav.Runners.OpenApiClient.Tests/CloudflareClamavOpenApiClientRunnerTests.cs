using Soenneker.Tests.HostedUnit;

namespace Soenneker.Cloudflare.Clamav.Runners.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class CloudflareClamavOpenApiClientRunnerTests : HostedUnitTest
{
    public CloudflareClamavOpenApiClientRunnerTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
