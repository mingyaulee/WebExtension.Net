// This file is auto generated at 2021-03-24T04:51:22

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WebExtension.Net.WebRequest
{
    // Enum Definition
    /// <summary>
    /// 
    /// </summary>
    [JsonConverter(typeof(EnumStringConverter<OnAuthRequiredOptions>))]
    public enum OnAuthRequiredOptions
    {
        /// <summary>responseHeaders</summary>
        [EnumValue("responseHeaders")]
        ResponseHeaders,
        /// <summary>blocking</summary>
        [EnumValue("blocking")]
        Blocking,
        /// <summary>asyncBlocking</summary>
        [EnumValue("asyncBlocking")]
        AsyncBlocking,
    }
}

