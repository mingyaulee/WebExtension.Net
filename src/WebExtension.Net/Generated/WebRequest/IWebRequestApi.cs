using System.Text.Json;
using System.Threading.Tasks;

namespace WebExtension.Net.WebRequest
{
    /// <summary>Use the <c>browser.webRequest</c> API to observe and analyze traffic and to intercept, block, or modify requests in-flight.</summary>
    public interface IWebRequestApi
    {
        /// <summary>The maximum number of times that <c>handlerBehaviorChanged</c> can be called per 10 minute sustained interval. <c>handlerBehaviorChanged</c> is an expensive function call that shouldn't be called often.</summary>
        int MAX_HANDLER_BEHAVIOR_CHANGED_CALLS_PER_10_MINUTES { get; }

        /// <summary>Fired when an authentication failure is received. The listener has three options: it can provide authentication credentials, it can cancel the request and display the error page, or it can take no action on the challenge. If bad user credentials are provided, this may be called multiple times for the same request.</summary>
        OnAuthRequiredEvent OnAuthRequired { get; }

        /// <summary>Fired when a server-initiated redirect is about to occur.</summary>
        OnBeforeRedirectEvent OnBeforeRedirect { get; }

        /// <summary>Fired when a request is about to occur.</summary>
        OnBeforeRequestEvent OnBeforeRequest { get; }

        /// <summary>Fired before sending an HTTP request, once the request headers are available. This may occur after a TCP connection is made to the server, but before any HTTP data is sent. </summary>
        OnBeforeSendHeadersEvent OnBeforeSendHeaders { get; }

        /// <summary>Fired when a request is completed.</summary>
        OnCompletedEvent OnCompleted { get; }

        /// <summary>Fired when an error occurs.</summary>
        OnErrorOccurredEvent OnErrorOccurred { get; }

        /// <summary>Fired when HTTP response headers of a request have been received.</summary>
        OnHeadersReceivedEvent OnHeadersReceived { get; }

        /// <summary>Fired when the first byte of the response body is received. For HTTP requests, this means that the status line and response headers are available.</summary>
        OnResponseStartedEvent OnResponseStarted { get; }

        /// <summary>Fired just before a request is going to be sent to the server (modifications of previous onBeforeSendHeaders callbacks are visible by the time onSendHeaders is fired).</summary>
        OnSendHeadersEvent OnSendHeaders { get; }

        /// <summary>...</summary>
        /// <param name="requestId"></param>
        /// <returns></returns>
        ValueTask<JsonElement> FilterResponseData(string requestId);

        /// <summary>Retrieves the security information for the request.  Returns a promise that will resolve to a SecurityInfo object.</summary>
        /// <param name="requestId"></param>
        /// <param name="options"></param>
        ValueTask GetSecurityInfo(string requestId, object options);

        /// <summary>Needs to be called when the behavior of the webRequest handlers has changed to prevent incorrect handling due to caching. This function call is expensive. Don't call it often.</summary>
        ValueTask HandlerBehaviorChanged();
    }
}
