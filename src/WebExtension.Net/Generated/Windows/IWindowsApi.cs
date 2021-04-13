using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebExtension.Net.Windows
{
    /// <summary>Use the <c>browser.windows</c> API to interact with browser windows. You can use this API to create, modify, and rearrange windows in the browser.</summary>
    public interface IWindowsApi
    {
        /// <summary>The windowId value that represents the absence of a browser window.</summary>
        int WINDOW_ID_NONE { get; }

        /// <summary>The windowId value that represents the $(topic:current-window)[current window].</summary>
        int WINDOW_ID_CURRENT { get; }

        /// <summary>Gets details about a window.</summary>
        /// <param name="windowId"></param>
        /// <param name="getInfo"></param>
        /// <returns></returns>
        ValueTask<Window> Get(int windowId, GetInfo getInfo);

        /// <summary>Gets the $(topic:current-window)[current window].</summary>
        /// <param name="getInfo"></param>
        /// <returns></returns>
        ValueTask<Window> GetCurrent(GetInfo getInfo);

        /// <summary>Gets the window that was most recently focused - typically the window 'on top'.</summary>
        /// <param name="getInfo"></param>
        /// <returns></returns>
        ValueTask<Window> GetLastFocused(GetInfo getInfo);

        /// <summary>Gets all windows.</summary>
        /// <param name="getInfo">Specifies properties used to filter the $(ref:windows.Window) returned and to determine whether they should contain a list of the $(ref:tabs.Tab) objects.</param>
        /// <returns></returns>
        ValueTask<IEnumerable<Window>> GetAll(object getInfo);

        /// <summary>Creates (opens) a new browser with any optional sizing, position or default URL provided.</summary>
        /// <param name="createData"></param>
        /// <returns>Contains details about the created window.</returns>
        ValueTask<Window> Create(object createData);

        /// <summary>Updates the properties of a window. Specify only the properties that you want to change; unspecified properties will be left unchanged.</summary>
        /// <param name="windowId"></param>
        /// <param name="updateInfo"></param>
        /// <returns></returns>
        ValueTask<Window> Update(int windowId, object updateInfo);

        /// <summary>Removes (closes) a window, and all the tabs inside it.</summary>
        /// <param name="windowId"></param>
        ValueTask Remove(int windowId);
    }
}
