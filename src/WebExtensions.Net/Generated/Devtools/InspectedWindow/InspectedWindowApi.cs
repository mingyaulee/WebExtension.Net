using System;
using System.Threading.Tasks;

namespace WebExtensions.Net.Devtools.InspectedWindow
{
    /// <inheritdoc />
    public partial class InspectedWindowApi : BaseApi, IInspectedWindowApi
    {
        /// <summary>Creates a new instance of <see cref="InspectedWindowApi" />.</summary>
        /// <param name="webExtensionsJSRuntime">Web Extension JS Runtime</param>
        public InspectedWindowApi(IWebExtensionsJSRuntime webExtensionsJSRuntime) : base(webExtensionsJSRuntime, "devtools.inspectedWindow")
        {
        }

        /// <inheritdoc />
        public virtual ValueTask Eval(string expression, object options, Action<object, ExceptionInfo> callback)
        {
            return InvokeVoidAsync("eval", expression, options, callback);
        }

        /// <inheritdoc />
        public virtual ValueTask Reload(ReloadOptions reloadOptions)
        {
            return InvokeVoidAsync("reload", reloadOptions);
        }

        /// <inheritdoc />
        public virtual ValueTask<int> GetTabId()
        {
            return GetPropertyAsync<int>("tabId");
        }
    }
}
