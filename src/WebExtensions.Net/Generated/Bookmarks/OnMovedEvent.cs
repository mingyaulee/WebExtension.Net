using JsBind.Net;
using System;
using System.Threading.Tasks;
using WebExtensions.Net.Events;

namespace WebExtensions.Net.Bookmarks
{
    // Type Class
    /// <summary>Fired when a bookmark or folder is moved to a different parent folder.</summary>
    [BindAllProperties]
    public partial class OnMovedEvent : Event
    {
        /// <summary>Registers an event listener <em>callback</em> to an event.</summary>
        /// <param name="callback">Fired when a bookmark or folder is moved to a different parent folder.</param>
        [JsAccessPath("addListener")]
        public virtual ValueTask AddListener(Action<string, MoveInfo> callback)
        {
            return InvokeVoidAsync("addListener", callback);
        }

        /// <summary></summary>
        /// <param name="callback">Listener whose registration status shall be tested.</param>
        /// <returns>True if <em>callback</em> is registered to the event.</returns>
        [JsAccessPath("hasListener")]
        public virtual ValueTask<bool> HasListener(Action<string, MoveInfo> callback)
        {
            return InvokeAsync<bool>("hasListener", callback);
        }

        /// <summary>Deregisters an event listener <em>callback</em> from an event.</summary>
        /// <param name="callback">Listener that shall be unregistered.</param>
        [JsAccessPath("removeListener")]
        public virtual ValueTask RemoveListener(Action<string, MoveInfo> callback)
        {
            return InvokeVoidAsync("removeListener", callback);
        }
    }
}
