using JsBind.Net;
using System;
using System.Threading.Tasks;
using WebExtensions.Net.Events;

namespace WebExtensions.Net.WebNavigation
{
    // Type Class
    /// <summary>Fired when the page's DOM is fully constructed, but the referenced resources may not finish loading.</summary>
    [BindAllProperties]
    public partial class OnDomContentLoadedEvent : Event
    {
        /// <summary>Registers an event listener <em>callback</em> to an event.</summary>
        /// <param name="callback">Fired when the page's DOM is fully constructed, but the referenced resources may not finish loading.</param>
        public virtual ValueTask AddListener(Action<OnDomContentLoadedEventCallbackDetails> callback)
        {
            return InvokeVoidAsync("addListener", callback);
        }

        /// <summary>Registers an event listener <em>callback</em> to an event.</summary>
        /// <param name="callback">Fired when the page's DOM is fully constructed, but the referenced resources may not finish loading.</param>
        /// <param name="filters">Conditions that the URL being navigated to must satisfy. The 'schemes' and 'ports' fields of UrlFilter are ignored for this event.</param>
        public virtual ValueTask AddListener(Action<OnDomContentLoadedEventCallbackDetails> callback, EventUrlFilters filters)
        {
            return InvokeVoidAsync("addListener", callback, filters);
        }

        /// <summary></summary>
        /// <param name="callback">Listener whose registration status shall be tested.</param>
        /// <returns>True if <em>callback</em> is registered to the event.</returns>
        public virtual ValueTask<bool> HasListener(Action<OnDomContentLoadedEventCallbackDetails> callback)
        {
            return InvokeAsync<bool>("hasListener", callback);
        }

        /// <summary></summary>
        /// <param name="callback">Listener whose registration status shall be tested.</param>
        /// <param name="filters">Conditions that the URL being navigated to must satisfy. The 'schemes' and 'ports' fields of UrlFilter are ignored for this event.</param>
        /// <returns>True if <em>callback</em> is registered to the event.</returns>
        public virtual ValueTask<bool> HasListener(Action<OnDomContentLoadedEventCallbackDetails> callback, EventUrlFilters filters)
        {
            return InvokeAsync<bool>("hasListener", callback, filters);
        }

        /// <summary>Deregisters an event listener <em>callback</em> from an event.</summary>
        /// <param name="callback">Listener that shall be unregistered.</param>
        public virtual ValueTask RemoveListener(Action<OnDomContentLoadedEventCallbackDetails> callback)
        {
            return InvokeVoidAsync("removeListener", callback);
        }

        /// <summary>Deregisters an event listener <em>callback</em> from an event.</summary>
        /// <param name="callback">Listener that shall be unregistered.</param>
        /// <param name="filters">Conditions that the URL being navigated to must satisfy. The 'schemes' and 'ports' fields of UrlFilter are ignored for this event.</param>
        public virtual ValueTask RemoveListener(Action<OnDomContentLoadedEventCallbackDetails> callback, EventUrlFilters filters)
        {
            return InvokeVoidAsync("removeListener", callback, filters);
        }
    }
}
