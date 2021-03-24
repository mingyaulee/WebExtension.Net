// This file is auto generated at 2021-03-24T04:51:22

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;

namespace WebExtension.Net.ContentScripts
{
    /// <summary>
    /// 
    /// </summary>
    public interface IContentScriptsAPI
    {
        
        // Function Definition Interface
        /// <summary>
        /// Register a content script programmatically
        /// </summary>
        /// <param name="contentScriptOptions"></param>
        ValueTask Register(RegisteredContentScriptOptions contentScriptOptions);
    }
}
