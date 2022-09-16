using JsBind.Net;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace WebExtensions.Net.DeclarativeNetRequest
{
    // Type Class
    /// <summary></summary>
    [BindAllProperties]
    public partial class Result : BaseObject
    {
        /// <summary>The rules (if any) that match the hypothetical request.</summary>
        [JsonPropertyName("matchedRules")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public IEnumerable<MatchedRule> MatchedRules { get; set; }
    }
}
