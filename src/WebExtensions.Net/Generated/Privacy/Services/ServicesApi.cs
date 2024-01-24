using JsBind.Net;
using WebExtensions.Net.Types;

namespace WebExtensions.Net.Privacy.Services
{
    /// <inheritdoc />
    public partial class ServicesApi : BaseApi, IServicesApi
    {
        /// <summary>Creates a new instance of <see cref="ServicesApi" />.</summary>
        /// <param name="jsRuntime">The JS runtime adapter.</param>
        /// <param name="accessPath">The base API access path.</param>
        public ServicesApi(IJsRuntimeAdapter jsRuntime, string accessPath) : base(jsRuntime, AccessPaths.Combine(accessPath, "services"))
        {
        }

        /// <inheritdoc />
        public Setting PasswordSavingEnabled => GetProperty<Setting>("passwordSavingEnabled");
    }
}
