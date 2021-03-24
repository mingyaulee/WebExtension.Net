// This file is auto generated at 2021-03-24T04:51:22

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;

namespace WebExtension.Net.WebRequest
{
    /// <inheritdoc />
    public class WebRequestAPI : IWebRequestAPI
    {
        private readonly WebExtensionJSRuntime webExtensionJSRuntime;
        /// <summary>Creates a new instance of WebRequestAPI.</summary>
        /// <param name="webExtensionJSRuntime">Web Extension JS Runtime</param>
        public WebRequestAPI(WebExtensionJSRuntime webExtensionJSRuntime)
        {
            this.webExtensionJSRuntime = webExtensionJSRuntime;
        }

        
        // Function Definition
        /// <summary>
        /// Needs to be called when the behavior of the webRequest handlers has changed to prevent incorrect handling due to caching. This function call is expensive. Don't call it often.
        /// </summary>
        public virtual ValueTask HandlerBehaviorChanged()
        {
            return webExtensionJSRuntime.InvokeVoidAsync("webRequest.handlerBehaviorChanged");
        }
        
        // Function Definition
        /// <summary>
        /// ...
        /// </summary>
        /// <param name="requestId"></param>
        /// <returns></returns>
        public virtual ValueTask<JsonElement> FilterResponseData(string requestId)
        {
            return webExtensionJSRuntime.InvokeAsync<JsonElement>("webRequest.filterResponseData", requestId);
        }
        
        // Function Definition
        /// <summary>
        /// Retrieves the security information for the request.  Returns a promise that will resolve to a SecurityInfo object.
        /// </summary>
        /// <param name="requestId"></param>
        /// <param name="options"></param>
        public virtual ValueTask GetSecurityInfo(string requestId, object options)
        {
            return webExtensionJSRuntime.InvokeVoidAsync("webRequest.getSecurityInfo", requestId, options);
        }
    }
}
