// This file is auto generated at 2021-03-24T04:51:22

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WebExtension.Net.Manifest
{
    // MultiType Definition
    /// <summary>
    /// 
    /// </summary>
    public class MatchPattern
    {
        private readonly string valuestring;
        /// <summary>Creates a new instance of MatchPattern.</summary>
        public MatchPattern(string valuestring)
        {
            this.valuestring = valuestring;
        }
        
        private readonly MatchPatternRestricted valueMatchPatternRestricted;
        /// <summary>Creates a new instance of MatchPattern.</summary>
        public MatchPattern(MatchPatternRestricted valueMatchPatternRestricted)
        {
            this.valueMatchPatternRestricted = valueMatchPatternRestricted;
        }
        
        private readonly MatchPatternUnestricted valueMatchPatternUnestricted;
        /// <summary>Creates a new instance of MatchPattern.</summary>
        public MatchPattern(MatchPatternUnestricted valueMatchPatternUnestricted)
        {
            this.valueMatchPatternUnestricted = valueMatchPatternUnestricted;
        }
        
    }
}

