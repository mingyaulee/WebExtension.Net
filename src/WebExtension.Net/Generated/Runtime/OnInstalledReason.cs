using System.Text.Json.Serialization;

namespace WebExtension.Net.Runtime
{
    /// <summary>The reason that this event is being dispatched.</summary>
    [JsonConverter(typeof(EnumStringConverter<OnInstalledReason>))]
    public enum OnInstalledReason
    {
        /// <summary>install</summary>
        [EnumValue("install")]
        Install,

        /// <summary>update</summary>
        [EnumValue("update")]
        Update,

        /// <summary>browser_update</summary>
        [EnumValue("browser_update")]
        Browser_update,
    }
}
