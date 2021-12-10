using JsBind.Net;
using System.Text.Json.Serialization;

namespace WebExtensions.Net.Action
{
    // Type Class
    /// <summary></summary>
    [BindAllProperties]
    public partial class SetBadgeTextDetails : BaseObject
    {
        /// <summary>Any number of characters can be passed, but only about four can fit in the space.</summary>
        [JsonPropertyName("text")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Text Text { get; set; }
    }
}
