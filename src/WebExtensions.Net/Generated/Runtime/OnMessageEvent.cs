using JsBind.Net;
using System;
using System.Threading.Tasks;
using WebExtensions.Net.Events;

namespace WebExtensions.Net.Runtime
{
    // Type Class
    /// <summary>Fired when a message is sent from either an extension process or a content script.</summary>
    [BindAllProperties]
    public partial class OnMessageEvent : Event
    {
        /// <summary>Registers an event listener <em>callback</em> to an event.</summary>
        /// <param name="callback">Fired when a message is sent from either an extension process or a content script.</param>
        public virtual ValueTask AddListener(Func<object, MessageSender, Action, bool> callback)
        {
            return InvokeVoidAsync("addListener", callback);
        }
        /// <summary>Registers an event listener <em>callback</em> to an event.</summary>
        /// <param name="callback">Fired when a message is sent from either an extension process or a content script.</param>
        public virtual ValueTask AddListener(Func<object, MessageSender, Action<object>, bool> callback)
        {
            return InvokeVoidAsync("addListener", callback);
        }

        /// <summary></summary>
        /// <param name="callback">Listener whose registration status shall be tested.</param>
        /// <returns>True if <em>callback</em> is registered to the event.</returns>
        public virtual ValueTask<bool> HasListener(Func<object, MessageSender, Action, bool> callback)
        {
            return InvokeAsync<bool>("hasListener", callback);
        }
        /// <summary></summary>
        /// <param name="callback">Listener whose registration status shall be tested.</param>
        /// <returns>True if <em>callback</em> is registered to the event.</returns>
        public virtual ValueTask<bool> HasListener(Func<object, MessageSender, Action<object>, bool> callback)
        {
            return InvokeAsync<bool>("hasListener", callback);
        }

        /// <summary>Deregisters an event listener <em>callback</em> from an event.</summary>
        /// <param name="callback">Listener that shall be unregistered.</param>
        public virtual ValueTask RemoveListener(Func<object, MessageSender, Action, bool> callback)
        {
            return InvokeVoidAsync("removeListener", callback);
        }
        /// <summary>Deregisters an event listener <em>callback</em> from an event.</summary>
        /// <param name="callback">Listener that shall be unregistered.</param>
        public virtual ValueTask RemoveListener(Func<object, MessageSender, Action<object>, bool> callback)
        {
            return InvokeVoidAsync("removeListener", callback);
        }
    }
}
