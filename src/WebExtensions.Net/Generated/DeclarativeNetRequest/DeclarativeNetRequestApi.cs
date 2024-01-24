using JsBind.Net;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebExtensions.Net.DeclarativeNetRequest
{
    /// <inheritdoc />
    public partial class DeclarativeNetRequestApi : BaseApi, IDeclarativeNetRequestApi
    {
        /// <summary>Creates a new instance of <see cref="DeclarativeNetRequestApi" />.</summary>
        /// <param name="jsRuntime">The JS runtime adapter.</param>
        /// <param name="accessPath">The base API access path.</param>
        public DeclarativeNetRequestApi(IJsRuntimeAdapter jsRuntime, string accessPath) : base(jsRuntime, AccessPaths.Combine(accessPath, "declarativeNetRequest"))
        {
        }

        /// <inheritdoc />
        public string DYNAMIC_RULESET_ID => "_dynamic";

        /// <inheritdoc />
        public double GUARANTEED_MINIMUM_STATIC_RULES => GetProperty<double>(nameof(GUARANTEED_MINIMUM_STATIC_RULES));

        /// <inheritdoc />
        public double MAX_NUMBER_OF_DYNAMIC_AND_SESSION_RULES => GetProperty<double>(nameof(MAX_NUMBER_OF_DYNAMIC_AND_SESSION_RULES));

        /// <inheritdoc />
        public double MAX_NUMBER_OF_ENABLED_STATIC_RULESETS => GetProperty<double>(nameof(MAX_NUMBER_OF_ENABLED_STATIC_RULESETS));

        /// <inheritdoc />
        public double MAX_NUMBER_OF_REGEX_RULES => GetProperty<double>(nameof(MAX_NUMBER_OF_REGEX_RULES));

        /// <inheritdoc />
        public double MAX_NUMBER_OF_STATIC_RULESETS => GetProperty<double>(nameof(MAX_NUMBER_OF_STATIC_RULESETS));

        /// <inheritdoc />
        public string SESSION_RULESET_ID => "_session";

        /// <inheritdoc />
        public virtual ValueTask<int> GetAvailableStaticRuleCount()
        {
            return InvokeAsync<int>("getAvailableStaticRuleCount");
        }

        /// <inheritdoc />
        public virtual ValueTask<IEnumerable<Rule>> GetDynamicRules()
        {
            return InvokeAsync<IEnumerable<Rule>>("getDynamicRules");
        }

        /// <inheritdoc />
        public virtual ValueTask<IEnumerable<string>> GetEnabledRulesets()
        {
            return InvokeAsync<IEnumerable<string>>("getEnabledRulesets");
        }

        /// <inheritdoc />
        public virtual ValueTask<IEnumerable<Rule>> GetSessionRules()
        {
            return InvokeAsync<IEnumerable<Rule>>("getSessionRules");
        }

        /// <inheritdoc />
        public virtual ValueTask<IsRegexSupportedCallbackResult> IsRegexSupported(RegexOptions regexOptions)
        {
            return InvokeAsync<IsRegexSupportedCallbackResult>("isRegexSupported", regexOptions);
        }

        /// <inheritdoc />
        public virtual ValueTask<TestMatchOutcomeCallbackResult> TestMatchOutcome(Request request, TestMatchOutcomeOptions options)
        {
            return InvokeAsync<TestMatchOutcomeCallbackResult>("testMatchOutcome", request, options);
        }

        /// <inheritdoc />
        public virtual ValueTask UpdateDynamicRules(UpdateDynamicRulesOptions options)
        {
            return InvokeVoidAsync("updateDynamicRules", options);
        }

        /// <inheritdoc />
        public virtual ValueTask UpdateEnabledRulesets(UpdateRulesetOptions updateRulesetOptions)
        {
            return InvokeVoidAsync("updateEnabledRulesets", updateRulesetOptions);
        }

        /// <inheritdoc />
        public virtual ValueTask UpdateSessionRules(UpdateSessionRulesOptions options)
        {
            return InvokeVoidAsync("updateSessionRules", options);
        }
    }
}
