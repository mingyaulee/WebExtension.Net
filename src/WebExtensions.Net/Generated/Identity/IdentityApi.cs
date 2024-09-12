using JsBind.Net;
using System.Threading.Tasks;

namespace WebExtensions.Net.Identity
{
    /// <inheritdoc />
    public partial class IdentityApi : BaseApi, IIdentityApi
    {
        /// <summary>Creates a new instance of <see cref="IdentityApi" />.</summary>
        /// <param name="jsRuntime">The JS runtime adapter.</param>
        /// <param name="accessPath">The base API access path.</param>
        public IdentityApi(IJsRuntimeAdapter jsRuntime, string accessPath) : base(jsRuntime, AccessPaths.Combine(accessPath, "identity"))
        {
        }

        /// <inheritdoc />
        public virtual string GetRedirectURL(string path = null)
            => Invoke<string>("getRedirectURL", path);

        /// <inheritdoc />
        public virtual ValueTask<string> LaunchWebAuthFlow(LaunchWebAuthFlowDetails details)
            => InvokeAsync<string>("launchWebAuthFlow", details);
    }
}
