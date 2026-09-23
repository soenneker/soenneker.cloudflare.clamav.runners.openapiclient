using System.Threading;
using System.Threading.Tasks;

namespace Soenneker.Cloudflare.Clamav.Runners.OpenApiClient.Utils.Abstract;

public interface IFileOperationsUtil
{
    ValueTask Process(CancellationToken cancellationToken = default);
}
